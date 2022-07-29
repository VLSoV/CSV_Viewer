using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_IBA_AG
{
    /// <summary>
    /// Contains chart component and 3 checkbox components to control grid, axis and legend.
    /// </summary>
    public partial class UserControlGraph : UserControl
    {
        Color[] colores = new Color[6] { Color.Blue, Color.Red, Color.Green, Color.DarkBlue, Color.DarkRed, Color.DarkGreen };
        public Color LegendBackColor = Color.FromArgb(128, 255, 255, 0);
        public UserControlGraph()
        {
            InitializeComponent();

            // bold axes for axesCheckBox
            HorizontalLineAnnotation axisX = new HorizontalLineAnnotation();
            axisX.AxisY = chart1.ChartAreas[0].AxisY;
            axisX.LineWidth = 3;
            axisX.Y = 0;
            axisX.IsInfinitive = true;
            chart1.Annotations.Add(axisX);

            VerticalLineAnnotation axisY = new VerticalLineAnnotation();
            axisY.AxisX = chart1.ChartAreas[0].AxisX;
            axisY.LineWidth = 3;
            axisY.X = 0;
            axisY.IsInfinitive = true;
            chart1.Annotations.Add(axisY);
        }
        /// <summary>
        /// Add new channel or updates existing channel on the chart.
        /// </summary>
        /// <param name="channel">Channel which necessary to add or update.</param>
        public void Add(Channel channel)
        {
            int indexStart = 0;
            if (chart1.Series.IndexOf(channel.Name) == -1)
            {
                chart1.Series.Add(channel.Name);
                chart1.Series[channel.Name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                chart1.Series[channel.Name].Color = colores[(chart1.Series.Count - 1) % 6];
            }
            else
            {
                indexStart = chart1.Series[channel.Name].Points.Count;
            }

            for (int i = indexStart; i < channel.Count; i++)
            {
                if (!double.IsNaN(channel[i]))
                    chart1.Series[channel.Name].Points.AddXY(i, channel[i]);
            }
        }
        /// <summary>
        /// Clears chart.
        /// </summary>
        public void ClearSeries()
        {
            chart1.Series.Clear();
        }

        private void checkBox_grid_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrid.Checked)
            {
                chart1.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                chart1.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
                chart1.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            }
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = checkBox_grid.Checked;
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = checkBox_grid.Checked;
            //chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = checkBox_grid.Checked;
            //chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = checkBox_grid.Checked;
        }

        private void checkBox_axes_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Annotations[0].Visible = checkBoxAxes.Checked;
            chart1.Annotations[1].Visible = checkBoxAxes.Checked;
        }

        private void checkBox_legend_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Legends[0].Enabled = checkBoxLegend.Checked;
        }

        private void chart1_CustomizeLegend(object sender, CustomizeLegendEventArgs e)
        {
            chart1.Legends[0].BackColor = LegendBackColor;
            for (int i = 0; i < e.LegendItems.Count; i++)
            {
                e.LegendItems[i].Cells[0].Margins = new Margins(0, 0, 0, 0);
                e.LegendItems[i].Cells[1].Margins = new Margins(0, 0, 0, 0);
                e.LegendItems[i].Cells[0].SeriesSymbolSize = new Size(0, 0);
                e.LegendItems[i].Cells[1].ForeColor = colores[i % 6];
            }
        }

    }
}
