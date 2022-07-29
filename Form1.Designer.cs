using System.Windows.Forms;

namespace Test_IBA_AG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Reader = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox_Channels = new System.Windows.Forms.GroupBox();
            this.listBoxChannels = new System.Windows.Forms.ListBox();
            this.groupBox_Generator = new System.Windows.Forms.GroupBox();
            this.pictureBoxRow = new System.Windows.Forms.PictureBox();
            this.pictureBoxChannel = new System.Windows.Forms.PictureBox();
            this.button_Generate = new System.Windows.Forms.Button();
            this.textBoxRowCount = new System.Windows.Forms.TextBox();
            this.textBoxChannelCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxGenerate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Details = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.userControlGraph1 = new Test_IBA_AG.UserControlGraph();
            this.groupBox_Statistics = new System.Windows.Forms.GroupBox();
            this.listBoxStatistics = new System.Windows.Forms.ListBox();
            this.groupBox_Common_settings = new System.Windows.Forms.GroupBox();
            this.groupBox_Decimal_delimiter = new System.Windows.Forms.GroupBox();
            this.radioButton_auto_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_comma_dec = new System.Windows.Forms.RadioButton();
            this.radioButton_Dot_dec = new System.Windows.Forms.RadioButton();
            this.groupBox_Field_separator = new System.Windows.Forms.GroupBox();
            this.radioButton_auto = new System.Windows.Forms.RadioButton();
            this.radioButton_semicolon = new System.Windows.Forms.RadioButton();
            this.radioButton_comma = new System.Windows.Forms.RadioButton();
            this.radioButton_tab = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Reader.SuspendLayout();
            this.groupBox_Channels.SuspendLayout();
            this.groupBox_Generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannel)).BeginInit();
            this.groupBox_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Statistics.SuspendLayout();
            this.groupBox_Common_settings.SuspendLayout();
            this.groupBox_Decimal_delimiter.SuspendLayout();
            this.groupBox_Field_separator.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Reader
            // 
            this.groupBox_Reader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Reader.Controls.Add(this.buttonClose);
            this.groupBox_Reader.Controls.Add(this.buttonOpen);
            this.groupBox_Reader.Controls.Add(this.groupBox_Channels);
            this.groupBox_Reader.Location = new System.Drawing.Point(10, 10);
            this.groupBox_Reader.Name = "groupBox_Reader";
            this.groupBox_Reader.Size = new System.Drawing.Size(194, 306);
            this.groupBox_Reader.TabIndex = 0;
            this.groupBox_Reader.TabStop = false;
            this.groupBox_Reader.Text = "CSV Reader";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(102, 20);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(64, 20);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 20);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(64, 20);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // groupBox_Channels
            // 
            this.groupBox_Channels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Channels.Controls.Add(this.listBoxChannels);
            this.groupBox_Channels.Location = new System.Drawing.Point(5, 45);
            this.groupBox_Channels.Name = "groupBox_Channels";
            this.groupBox_Channels.Size = new System.Drawing.Size(183, 255);
            this.groupBox_Channels.TabIndex = 0;
            this.groupBox_Channels.TabStop = false;
            this.groupBox_Channels.Text = "Channels";
            // 
            // listBoxChannels
            // 
            this.listBoxChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxChannels.FormattingEnabled = true;
            this.listBoxChannels.Location = new System.Drawing.Point(6, 25);
            this.listBoxChannels.Name = "listBoxChannels";
            this.listBoxChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxChannels.Size = new System.Drawing.Size(171, 212);
            this.listBoxChannels.TabIndex = 0;
            this.listBoxChannels.SelectedIndexChanged += new System.EventHandler(this.listBoxChannels_SelectedIndexChanged);
            // 
            // groupBox_Generator
            // 
            this.groupBox_Generator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Generator.Controls.Add(this.pictureBoxRow);
            this.groupBox_Generator.Controls.Add(this.pictureBoxChannel);
            this.groupBox_Generator.Controls.Add(this.button_Generate);
            this.groupBox_Generator.Controls.Add(this.textBoxRowCount);
            this.groupBox_Generator.Controls.Add(this.textBoxChannelCount);
            this.groupBox_Generator.Controls.Add(this.label2);
            this.groupBox_Generator.Controls.Add(this.checkBoxGenerate);
            this.groupBox_Generator.Controls.Add(this.label1);
            this.groupBox_Generator.Location = new System.Drawing.Point(10, 322);
            this.groupBox_Generator.Name = "groupBox_Generator";
            this.groupBox_Generator.Size = new System.Drawing.Size(194, 112);
            this.groupBox_Generator.TabIndex = 1;
            this.groupBox_Generator.TabStop = false;
            this.groupBox_Generator.Text = "CSV Generator";
            // 
            // pictureBoxRow
            // 
            this.pictureBoxRow.Location = new System.Drawing.Point(175, 39);
            this.pictureBoxRow.Name = "pictureBoxRow";
            this.pictureBoxRow.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxRow.TabIndex = 7;
            this.pictureBoxRow.TabStop = false;
            this.pictureBoxRow.Visible = false;
            // 
            // pictureBoxChannel
            // 
            this.pictureBoxChannel.Location = new System.Drawing.Point(175, 16);
            this.pictureBoxChannel.Name = "pictureBoxChannel";
            this.pictureBoxChannel.Size = new System.Drawing.Size(18, 20);
            this.pictureBoxChannel.TabIndex = 6;
            this.pictureBoxChannel.TabStop = false;
            this.pictureBoxChannel.Visible = false;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(57, 83);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(75, 23);
            this.button_Generate.TabIndex = 5;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // textBoxRowCount
            // 
            this.textBoxRowCount.Location = new System.Drawing.Point(91, 39);
            this.textBoxRowCount.Name = "textBoxRowCount";
            this.textBoxRowCount.Size = new System.Drawing.Size(84, 20);
            this.textBoxRowCount.TabIndex = 4;
            this.textBoxRowCount.Text = "1000";
            this.textBoxRowCount.TextChanged += new System.EventHandler(this.textBoxRowCount_TextChanged);
            // 
            // textBoxChannelCount
            // 
            this.textBoxChannelCount.Location = new System.Drawing.Point(91, 16);
            this.textBoxChannelCount.Name = "textBoxChannelCount";
            this.textBoxChannelCount.Size = new System.Drawing.Size(84, 20);
            this.textBoxChannelCount.TabIndex = 3;
            this.textBoxChannelCount.Text = "7";
            this.textBoxChannelCount.TextChanged += new System.EventHandler(this.textBoxChannelCount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Row count";
            // 
            // checkBoxGenerate
            // 
            this.checkBoxGenerate.AutoSize = true;
            this.checkBoxGenerate.Location = new System.Drawing.Point(15, 65);
            this.checkBoxGenerate.Name = "checkBoxGenerate";
            this.checkBoxGenerate.Size = new System.Drawing.Size(129, 17);
            this.checkBoxGenerate.TabIndex = 1;
            this.checkBoxGenerate.Text = "Add cccasional NaNs";
            this.checkBoxGenerate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Channel count";
            // 
            // groupBox_Details
            // 
            this.groupBox_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Details.Controls.Add(this.splitContainer1);
            this.groupBox_Details.Location = new System.Drawing.Point(210, 10);
            this.groupBox_Details.Name = "groupBox_Details";
            this.groupBox_Details.Size = new System.Drawing.Size(880, 595);
            this.groupBox_Details.TabIndex = 2;
            this.groupBox_Details.TabStop = false;
            this.groupBox_Details.Text = "Details";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 19);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userControlGraph1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Statistics);
            this.splitContainer1.Size = new System.Drawing.Size(868, 570);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 3;
            // 
            // userControlGraph1
            // 
            this.userControlGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlGraph1.Location = new System.Drawing.Point(0, 1);
            this.userControlGraph1.Name = "userControlGraph1";
            this.userControlGraph1.Size = new System.Drawing.Size(865, 416);
            this.userControlGraph1.TabIndex = 2;
            // 
            // groupBox_Statistics
            // 
            this.groupBox_Statistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Statistics.Controls.Add(this.listBoxStatistics);
            this.groupBox_Statistics.Location = new System.Drawing.Point(0, 3);
            this.groupBox_Statistics.Name = "groupBox_Statistics";
            this.groupBox_Statistics.Size = new System.Drawing.Size(868, 147);
            this.groupBox_Statistics.TabIndex = 1;
            this.groupBox_Statistics.TabStop = false;
            this.groupBox_Statistics.Text = "Statistics";
            // 
            // listBoxStatistics
            // 
            this.listBoxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStatistics.FormattingEnabled = true;
            this.listBoxStatistics.Location = new System.Drawing.Point(7, 18);
            this.listBoxStatistics.Name = "listBoxStatistics";
            this.listBoxStatistics.Size = new System.Drawing.Size(856, 108);
            this.listBoxStatistics.TabIndex = 0;
            // 
            // groupBox_Common_settings
            // 
            this.groupBox_Common_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_Common_settings.Controls.Add(this.groupBox_Decimal_delimiter);
            this.groupBox_Common_settings.Controls.Add(this.groupBox_Field_separator);
            this.groupBox_Common_settings.Location = new System.Drawing.Point(10, 440);
            this.groupBox_Common_settings.Name = "groupBox_Common_settings";
            this.groupBox_Common_settings.Size = new System.Drawing.Size(194, 159);
            this.groupBox_Common_settings.TabIndex = 0;
            this.groupBox_Common_settings.TabStop = false;
            this.groupBox_Common_settings.Text = "Common settings";
            // 
            // groupBox_Decimal_delimiter
            // 
            this.groupBox_Decimal_delimiter.Controls.Add(this.radioButton_auto_dec);
            this.groupBox_Decimal_delimiter.Controls.Add(this.radioButton_comma_dec);
            this.groupBox_Decimal_delimiter.Controls.Add(this.radioButton_Dot_dec);
            this.groupBox_Decimal_delimiter.Location = new System.Drawing.Point(5, 96);
            this.groupBox_Decimal_delimiter.Name = "groupBox_Decimal_delimiter";
            this.groupBox_Decimal_delimiter.Size = new System.Drawing.Size(183, 57);
            this.groupBox_Decimal_delimiter.TabIndex = 1;
            this.groupBox_Decimal_delimiter.TabStop = false;
            this.groupBox_Decimal_delimiter.Text = "Decimal delimiter";
            // 
            // radioButton_auto_dec
            // 
            this.radioButton_auto_dec.AutoSize = true;
            this.radioButton_auto_dec.Checked = true;
            this.radioButton_auto_dec.Location = new System.Drawing.Point(135, 24);
            this.radioButton_auto_dec.Name = "radioButton_auto_dec";
            this.radioButton_auto_dec.Size = new System.Drawing.Size(47, 17);
            this.radioButton_auto_dec.TabIndex = 4;
            this.radioButton_auto_dec.TabStop = true;
            this.radioButton_auto_dec.Text = "Auto";
            this.radioButton_auto_dec.UseVisualStyleBackColor = true;
            // 
            // radioButton_comma_dec
            // 
            this.radioButton_comma_dec.AutoSize = true;
            this.radioButton_comma_dec.Location = new System.Drawing.Point(61, 24);
            this.radioButton_comma_dec.Name = "radioButton_comma_dec";
            this.radioButton_comma_dec.Size = new System.Drawing.Size(72, 17);
            this.radioButton_comma_dec.TabIndex = 3;
            this.radioButton_comma_dec.Text = "Comma (,)";
            this.radioButton_comma_dec.UseVisualStyleBackColor = true;
            // 
            // radioButton_Dot_dec
            // 
            this.radioButton_Dot_dec.AutoSize = true;
            this.radioButton_Dot_dec.Location = new System.Drawing.Point(5, 24);
            this.radioButton_Dot_dec.Name = "radioButton_Dot_dec";
            this.radioButton_Dot_dec.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Dot_dec.TabIndex = 2;
            this.radioButton_Dot_dec.Text = "Dot (.)";
            this.radioButton_Dot_dec.UseVisualStyleBackColor = true;
            // 
            // groupBox_Field_separator
            // 
            this.groupBox_Field_separator.Controls.Add(this.radioButton_auto);
            this.groupBox_Field_separator.Controls.Add(this.radioButton_semicolon);
            this.groupBox_Field_separator.Controls.Add(this.radioButton_comma);
            this.groupBox_Field_separator.Controls.Add(this.radioButton_tab);
            this.groupBox_Field_separator.Location = new System.Drawing.Point(6, 19);
            this.groupBox_Field_separator.Name = "groupBox_Field_separator";
            this.groupBox_Field_separator.Size = new System.Drawing.Size(183, 71);
            this.groupBox_Field_separator.TabIndex = 0;
            this.groupBox_Field_separator.TabStop = false;
            this.groupBox_Field_separator.Text = "Field separator";
            // 
            // radioButton_auto
            // 
            this.radioButton_auto.AutoSize = true;
            this.radioButton_auto.Checked = true;
            this.radioButton_auto.Location = new System.Drawing.Point(97, 42);
            this.radioButton_auto.Name = "radioButton_auto";
            this.radioButton_auto.Size = new System.Drawing.Size(47, 17);
            this.radioButton_auto.TabIndex = 3;
            this.radioButton_auto.TabStop = true;
            this.radioButton_auto.Text = "Auto";
            this.radioButton_auto.UseVisualStyleBackColor = true;
            // 
            // radioButton_semicolon
            // 
            this.radioButton_semicolon.AutoSize = true;
            this.radioButton_semicolon.Location = new System.Drawing.Point(5, 42);
            this.radioButton_semicolon.Name = "radioButton_semicolon";
            this.radioButton_semicolon.Size = new System.Drawing.Size(86, 17);
            this.radioButton_semicolon.TabIndex = 2;
            this.radioButton_semicolon.Text = "Semicolon (;)";
            this.radioButton_semicolon.UseVisualStyleBackColor = true;
            // 
            // radioButton_comma
            // 
            this.radioButton_comma.AutoSize = true;
            this.radioButton_comma.Location = new System.Drawing.Point(97, 18);
            this.radioButton_comma.Name = "radioButton_comma";
            this.radioButton_comma.Size = new System.Drawing.Size(72, 17);
            this.radioButton_comma.TabIndex = 1;
            this.radioButton_comma.Text = "Comma (,)";
            this.radioButton_comma.UseVisualStyleBackColor = true;
            // 
            // radioButton_tab
            // 
            this.radioButton_tab.AutoSize = true;
            this.radioButton_tab.Location = new System.Drawing.Point(5, 19);
            this.radioButton_tab.Name = "radioButton_tab";
            this.radioButton_tab.Size = new System.Drawing.Size(44, 17);
            this.radioButton_tab.TabIndex = 0;
            this.radioButton_tab.Text = "Tab";
            this.radioButton_tab.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1102, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 630);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_Common_settings);
            this.Controls.Add(this.groupBox_Details);
            this.Controls.Add(this.groupBox_Generator);
            this.Controls.Add(this.groupBox_Reader);
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "Form1";
            this.Text = "CSV Viewer";
            this.groupBox_Reader.ResumeLayout(false);
            this.groupBox_Channels.ResumeLayout(false);
            this.groupBox_Generator.ResumeLayout(false);
            this.groupBox_Generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannel)).EndInit();
            this.groupBox_Details.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Statistics.ResumeLayout(false);
            this.groupBox_Common_settings.ResumeLayout(false);
            this.groupBox_Decimal_delimiter.ResumeLayout(false);
            this.groupBox_Decimal_delimiter.PerformLayout();
            this.groupBox_Field_separator.ResumeLayout(false);
            this.groupBox_Field_separator.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox_Reader;
        private GroupBox groupBox_Generator;
        private GroupBox groupBox_Details;
        private GroupBox groupBox_Channels;
        private GroupBox groupBox_Common_settings;
        private GroupBox groupBox_Statistics;
        private GroupBox groupBox_Decimal_delimiter;
        private GroupBox groupBox_Field_separator;
        private StatusStrip statusStrip1;
        private Button buttonClose;
        private Button buttonOpen;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button_Generate;
        private TextBox textBoxRowCount;
        private TextBox textBoxChannelCount;
        private Label label2;
        private CheckBox checkBoxGenerate;
        private Label label1;
        private RadioButton radioButton_auto_dec;
        private RadioButton radioButton_comma_dec;
        private RadioButton radioButton_Dot_dec;
        private RadioButton radioButton_auto;
        private RadioButton radioButton_semicolon;
        private RadioButton radioButton_comma;
        private RadioButton radioButton_tab;
        private ListBox listBoxChannels;
        private ListBox listBoxStatistics;
        private UserControlGraph userControlGraph1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBoxChannel;
        private PictureBox pictureBoxRow;
        private ToolTip toolTip1;
    }
}








