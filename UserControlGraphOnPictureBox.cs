﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_IBA_AG
{
    /// <summary>
    /// Contains chart component and 3 checkbox components to control grid, axis and legend.
    /// </summary>
    public partial class UserControlGraphOnPictureBox : UserControl
    {
        Dictionary<string, List<PointF>> _points = new Dictionary<string, List<PointF>>();
        Bitmap _chart = new Bitmap(1,1);

        Color[] colores = new Color[6] { Color.Blue, Color.Red, Color.Green, Color.DarkBlue, Color.DarkRed, Color.DarkGreen };
        public Color LegendBackColor = Color.FromArgb(128, 255, 255, 0);
        public PointF LegendCoordinates = new PointF(30,20);
        Font _textFont = new Font("Arial", 8, FontStyle.Bold);
        float _legendWidth;
        float _minYValue;
        float _maxYValue;
        float _minXValue;
        float _maxXValue;
        float _koefX = 1;
        float _koefY = 1;
        float _YLocationXAxes = 0;
        float _cursorXLocation = -1;
        float _cursorYLocation = -1;

        public UserControlGraphOnPictureBox()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Add new channel or updates existing channel on the chart.
        /// </summary>
        /// <param name="channel">Channel which necessary to add or update.</param>
        public void Add(Channel channel)
        {
            int indexStart = 0;
            if (!_points.ContainsKey(channel.Name))
            {
                _points.Add(channel.Name, new List<PointF>());
            }
            else
            {
                indexStart = (int)_points[channel.Name].DefaultIfEmpty<PointF>().Last().X + 1;
            }

            for (int i = indexStart; i < channel.Count; i++)
            {
                if (!float.IsNaN((float)channel[i]) && !float.IsInfinity((float)channel[i]))
                {
                    _points[channel.Name].Add(new PointF(i, (float)channel[i]));
                }
            }

            _minYValue = 0;
            _maxYValue = 0;
            _minXValue = 0;
            _maxXValue = 0;
            foreach (var line in _points)
            {
                if (_minYValue > line.Value.DefaultIfEmpty<PointF>().Min(item => item.Y))
                {
                    _minYValue = line.Value.DefaultIfEmpty<PointF>().Min(item => item.Y);
                }
                if (_maxYValue < line.Value.DefaultIfEmpty<PointF>().Max(item => item.Y))
                {
                    _maxYValue = line.Value.DefaultIfEmpty<PointF>().Max(item => item.Y);
                }
                if (_maxXValue < line.Value.DefaultIfEmpty<PointF>().Max(item => item.X))
                {
                    _maxXValue = line.Value.DefaultIfEmpty<PointF>().Max(item => item.X);
                }
            }
            CalculateCoefficients();
            _YLocationXAxes = pictureBox1.Height + _minYValue * _koefY;
            CreateChart();
        }
        private void CalculateCoefficients()
        {
            if (_maxXValue != _minXValue) 
                _koefX = pictureBox1.Width / (_maxXValue - _minXValue);
            if (_maxYValue != _minYValue) 
                _koefY = pictureBox1.Height / (_maxYValue - _minYValue);
        }
        private void CreateChart()
        {
            _chart = new Bitmap(pictureBox1.Width+1, pictureBox1.Height+1);
            Graphics graphics = Graphics.FromImage(_chart);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Invoke((MethodInvoker)(() =>
            {
                int colorNumber = 0;
                foreach (var graph in _points)
                {
                    AddGraph(graph.Value.ToArray(), graph.Key, graphics, new Pen(colores[colorNumber % 6], 1));
                    colorNumber++;
                }
                pictureBox1.Refresh();
            }));
        }
        private void AddGraph(PointF[] data, string name, Graphics graphics, Pen pen)
        {
            if (data.Length == 0)
                return;
            for (int i = 0; i < data.Length; i++)
            {
                data[i].X = data[i].X * _koefX;
                data[i].Y = _YLocationXAxes - data[i].Y * _koefY;
            }
            graphics.DrawLines(pen, data);
        }
        private void DrawAxes(Graphics graphics)
        {
            if (checkBoxAxes.Checked)
            {
                Pen blackPen = new Pen(Color.Black, 3);
                float y = _YLocationXAxes;
                if (y < 1) y = 1;
                if (y > pictureBox1.Height-2) y = pictureBox1.Height-2;
                graphics.DrawLine(blackPen, 0, y, pictureBox1.Width, y);  // x axis
                graphics.DrawLine(blackPen, 1, 0, 1, pictureBox1.Height); // y axis
            }
        }
        private void DrawGrid(Graphics graphics)
        {
            if (checkBoxGrid.Checked)
            {
                if ((_maxXValue == 0 && _minXValue == 0) || (_maxYValue == 0 && _minYValue == 0))
                    return;
                Pen grayPen = new Pen(Color.Gray, 1);
                float h = graphics.MeasureString("ANY TEXT", _textFont).Height;

                int numberVertikalLines = pictureBox1.Width / 100;
                int numberHorizontalLines = pictureBox1.Height / 100;

                float stepX = CalculateGridStep((_maxXValue - _minXValue) / numberVertikalLines);
                float stepY = CalculateGridStep((_maxYValue - _minYValue) / numberHorizontalLines);

                float stepXLocation = stepX * _koefX;
                float stepYLocation = stepY * _koefY;

                for (float x = 0; x < pictureBox1.Width; x += stepXLocation)
                {
                    graphics.DrawLine(grayPen, x, 0, x, pictureBox1.Height);

                    float y;
                    if (_YLocationXAxes > pictureBox1.Height - h) 
                        y = pictureBox1.Height - h - 1;
                    else 
                        y = _YLocationXAxes + 1;
                    graphics.DrawString($"{ x / _koefX, 0:0.###e+00}", _textFont, new SolidBrush(Color.Gray), x+1, y);
                }

                for (float y = 0; y < pictureBox1.Width; y += stepYLocation)
                {
                    graphics.DrawLine(grayPen, 0, _YLocationXAxes + y, pictureBox1.Width, _YLocationXAxes + y);
                    graphics.DrawLine(grayPen, 0, _YLocationXAxes - y, pictureBox1.Width, _YLocationXAxes - y);

                    graphics.DrawString($"{ -y / _koefY, 0:0.###e+00}", _textFont, new SolidBrush(Color.Gray), 1, _YLocationXAxes + y + 1);
                    graphics.DrawString($"{ +y / _koefY, 0:0.###e+00}", _textFont, new SolidBrush(Color.Gray), 1, _YLocationXAxes - y + 1);

                }
            }
        }
        private float CalculateGridStep(float approximateStep)
        {
            int mantissa = (int)Math.Pow(10, Math.Truncate(Math.Log10(approximateStep)));
            float[] Distances = new float[4]
                {
                    Math.Abs(approximateStep - mantissa),
                    Math.Abs(approximateStep - 2 * mantissa),
                    Math.Abs(approximateStep - 5 * mantissa),
                    Math.Abs(approximateStep - 10 * mantissa)
                };
            if (Distances[0] == Distances.Min()) return mantissa;
            if (Distances[1] == Distances.Min()) return 2 * mantissa;
            if (Distances[2] == Distances.Min()) return 5 * mantissa;
            if (Distances[3] == Distances.Min()) return 10 * mantissa;
            throw new Exception("Step cannot be determined!");
        }
        private void DrawCross(Graphics graphics)
        {
            if (!checkBoxCross.Checked || (_cursorXLocation == -1 && _cursorYLocation == -1)) 
                return;
            Pen violetPen = new Pen(Color.Violet, 2);
            float x = _cursorXLocation;
            float y = _cursorYLocation;
            graphics.DrawLine(violetPen, 0, y, pictureBox1.Width, y);  // x axis
            graphics.DrawLine(violetPen, x, 0, x, pictureBox1.Height); // y axis

            string coordinates = $"{ (x - 1) / _koefX, 0:0.###e+00}; { (pictureBox1.Height - y) / _koefY + _minYValue, 0:0.###e+00}";// to do
            float h = graphics.MeasureString("ANY TEXT", _textFont).Height;
            graphics.DrawString(coordinates, _textFont, new SolidBrush(Color.Black), x, y - h);
        }
        private void DrawLegend(Graphics graphics)
        {
            if (checkBoxLegend.Checked)
            {
                _legendWidth = 0;
                foreach (var graph in _points)
                {
                    if (_legendWidth < graphics.MeasureString(graph.Key, _textFont).Width)
                        _legendWidth = graphics.MeasureString(graph.Key, _textFont).Width;
                }
                float x = LegendCoordinates.X;
                float y = LegendCoordinates.Y;
                float h = graphics.MeasureString("ANY TEXT", _textFont).Height;
                graphics.FillRectangle(new SolidBrush(LegendBackColor), new RectangleF(x, y, _legendWidth, h * _points.Count));

                int colorNumber = 0;
                foreach (var graph in _points)
                {
                    graphics.DrawString(graph.Key, _textFont, new SolidBrush(colores[colorNumber % 6]), x, y);
                    y += h;
                    colorNumber++;
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CalculateCoefficients();
            _YLocationXAxes = pictureBox1.Height + _minYValue * _koefY;
            DrawGrid(e.Graphics);
            DrawAxes(e.Graphics);
            e.Graphics.DrawImage(_chart, new Rectangle(0,0,pictureBox1.Width, pictureBox1.Height));
            DrawCross(e.Graphics);
            DrawLegend(e.Graphics);
        }

        /// <summary>
        /// Clears chart.
        /// </summary>
        public void ClearSeries()
        {
            _points.Clear();
            _chart = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Refresh();
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBoxCross.Checked)
            {
                _cursorXLocation = e.X + 1;
                _cursorYLocation = e.Y + 1;
                pictureBox1.Refresh();
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (checkBoxCross.Checked)
            {
                System.Windows.Forms.Cursor.Hide();
            }
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBoxCross.Checked)
            {
                System.Windows.Forms.Cursor.Show();
                _cursorXLocation = -1;
                _cursorYLocation = -1;
                pictureBox1.Refresh();
            }
        }
        private void checkBox_grid_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void checkBox_axes_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void checkBox_legend_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void checkBoxCross_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

    }
}
