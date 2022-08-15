using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Test_IBA_AG
{
    public partial class Form1 : Form
    {
        string _fileName;
        List<Channel> _channels = new List<Channel>();
        bool _isIgnoreRedrawByListBoxEvent = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Defines field separator.
        /// </summary>
        /// <param name="firstLine">String with channel names.</param>
        /// <returns>If defined it returns symbol of field separation. If undefined it returns '\0'.</returns>
        public char DefineFieldSeparator(string firstLine)
        {
            if (radioButton_tab.Checked)
                return '\t';
            if (radioButton_comma.Checked)
                return ',';
            if (radioButton_semicolon.Checked)
                return ';';
            if (radioButton_auto.Checked)
            {
                if (firstLine.Contains("\t"))
                    return '\t';
                if (firstLine.Contains(","))
                    return ',';
                if (firstLine.Contains(";"))
                    return ';';
            }
            return '\0';
        }
        /// <summary>
        /// Defines decimal delimiter.
        /// </summary>
        /// <param name="line">String with values.</param>
        /// <returns>If defined it returns decimal delimiter. If undefined it returns '\0'</returns>
        public char DefineDecimalDelimiter(string line, char fieldSeparator)
        {
            if (radioButton_Dot_dec.Checked)
                return '.';
            if (radioButton_comma_dec.Checked)
                return ',';
            if (radioButton_auto_dec.Checked)
            {
                if (line.Contains("."))
                    return '.';
                if (line.Contains(",") && fieldSeparator != ',')
                    return ',';
            }
            return '\0';
        }
        /// <summary>
        /// Calculates and writes info about the channels into listBoxStatistics.
        /// </summary>
        private void WriteStatictics()
        {
            listBoxStatistics.Items.Clear();
            listBoxStatistics.Items.Add("File ‘" + _fileName + "’. Total channels: " + _channels.Count);
            for (int i = 0; i < _channels.Count; i++)
            {
                if (_channels[i].IsActive)
                {
                    listBoxStatistics.Items.Add(
                        "Channel: " + _channels[i].Name + 
                        ". Count = " + _channels[i].Count + 
                        " (NaNs = " + _channels[i].NaNs + 
                        ", Valid = " + _channels[i].Valid + 
                        "); Avg = " + _channels[i].Avg() + 
                        "; Range = [" + _channels[i].Min() + "..." + _channels[i].Max() + "]");
                }
            }
        }
        /// <summary>
        /// Redrawing chart on UserControlGraph component.
        /// </summary>
        /// <param name="channels">List with channels.</param>
        public void WriteGraph(List<Channel> channels)
        {
            //Invoke((MethodInvoker)(() =>
            //{
                for (int i = 0; i < channels.Count; i++)
                {
                    if (channels[i].IsActive)
                    {
                        userControlGraphOnPictureBox1.Add(channels[i]);
                    }
                }
             //}));
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            CloseChannels();
            SetStatus("Opening CSV file…");
            CSVReader _reader = new CSVReader(this);
            _fileName = _reader.SelectFile();
            if(_fileName != null)
                _reader.Read(_fileName);

            //userControlGraph1.LegendBackColor = Color.Transparent;
        }
        /// <summary>
        /// Selectes first 5 channel on listBoxChannels and changes necessary strings,
        /// or deletes all already loaded channels if opening has been cancelled.
        /// </summary>
        /// <param name="isCancelled">Flag indicating if the process has been canceled.</param>
        /// <param name="channels">List with channels.</param>
        public void EndOpening(bool isCancelled, List<Channel> channels)
        {
            if (isCancelled)
            {
                CloseChannels();
                SetStatus("Cancelled");
                return;
            }
            _channels = channels;
            this.Text = "CSV Viewer - " + _fileName;
            SetStatus("Completed successfully");
            buttonClose.Enabled = true;

            _isIgnoreRedrawByListBoxEvent = true; // for listBoxChannels_SelectedIndexChange() don't redraw all series in chart
            for (int i = 0; i < _channels.Count; i++)
            {
                listBoxChannels.Items.Add(_channels[i].Name);

                if (i < 5) // first 5 channels should be automatically selected in the list box
                    listBoxChannels.SetSelected(i, true);
            }
            _isIgnoreRedrawByListBoxEvent = false; // for listBoxChannels_SelectedIndexChange() can redraw all series in chart again
        }
        /// <summary>
        /// Change status bar.
        /// </summary>
        /// <param name="status">New twxt on status bar.</param>
        public void SetStatus(string status)
        {
            toolStripStatusLabel1.Text = status;
        }
        /// <summary>
        /// Closes all readed channels.
        /// </summary>
        private void CloseChannels()
        {
            this.Text = "CSV Viewer";
            listBoxChannels.Items.Clear();
            listBoxStatistics.Items.Clear();
            userControlGraphOnPictureBox1.ClearSeries();
            buttonClose.Enabled = false;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            CloseChannels();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            if (pictureBoxChannel.Visible || pictureBoxRow.Visible) // if at least one of textBoxes is incorrect
            {
                MessageBox.Show("Enter the correct parameters of the generating file!", "Incorrect parameters!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButton_comma.Checked && radioButton_comma_dec.Checked) // same decimal delimiter and field separators
                if (MessageBox.Show("Are you sure you want to use commma as field separator and decimal delimiter at the same time?", "Same decimal delimiter and field separators!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.No)
                    return;

            SetStatus("Generating CSV file…");
            CSVGenerator _generator = new CSVGenerator(this);
            _fileName = _generator.CreateFile();
            if(_fileName != null)
                _generator.Write(_fileName, int.Parse(textBoxChannelCount.Text), int.Parse(textBoxRowCount.Text), checkBoxGenerate.Checked);
        }

        private void listBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxChannels.Items.Count; i++)
            {
                _channels[i].IsActive = listBoxChannels.GetSelected(i);
            }
            WriteStatictics();

            if(!_isIgnoreRedrawByListBoxEvent) Invoke((MethodInvoker)(() => { userControlGraphOnPictureBox1.ClearSeries(); }));
            WriteGraph(_channels);
        }
        /// <summary>
        /// Paints error icon on pictureBox and sets toolTip on this pictureBox.
        /// </summary>
        private void PaintErrorIcon(PictureBox pictureBox, string errorString)
        {
            pictureBox.Visible = true;
            pictureBox.Image = new Bitmap(SystemIcons.Error.Size.Width, SystemIcons.Error.Size.Height);
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawIcon(SystemIcons.Error, new Rectangle(0, 0, 18, 18));
            }
            toolTip1.SetToolTip(pictureBox, errorString);
        }

        private void textBoxChannelCount_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBoxChannelCount.Text, out num))
            {
                if (num < 1)
                {
                    PaintErrorIcon(pictureBoxChannel, "number should be positive");
                }
                else
                {
                    pictureBoxChannel.Visible = false;
                }
            }
            else
            {
                PaintErrorIcon(pictureBoxChannel, "invalid number");
            }
        }

        private void textBoxRowCount_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBoxRowCount.Text, out num))
            {
                if (num < 1)
                {
                    PaintErrorIcon(pictureBoxRow, "number should be positive");

                }
                else
                {
                    pictureBoxRow.Visible = false;
                }
            }
            else
            {
                PaintErrorIcon(pictureBoxRow, "invalid number");
            }
        }
    }
}
