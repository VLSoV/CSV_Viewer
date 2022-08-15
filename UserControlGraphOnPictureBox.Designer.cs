namespace Test_IBA_AG
{
    partial class UserControlGraphOnPictureBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Display_options = new System.Windows.Forms.GroupBox();
            this.checkBoxCross = new System.Windows.Forms.CheckBox();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.checkBoxAxes = new System.Windows.Forms.CheckBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Display_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.groupBox_Display_options);
            this.groupBox4.Location = new System.Drawing.Point(0, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(715, 466);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graphs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 401);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // groupBox_Display_options
            // 
            this.groupBox_Display_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Display_options.Controls.Add(this.checkBoxCross);
            this.groupBox_Display_options.Controls.Add(this.checkBoxLegend);
            this.groupBox_Display_options.Controls.Add(this.checkBoxAxes);
            this.groupBox_Display_options.Controls.Add(this.checkBoxGrid);
            this.groupBox_Display_options.Location = new System.Drawing.Point(6, 420);
            this.groupBox_Display_options.Name = "groupBox_Display_options";
            this.groupBox_Display_options.Size = new System.Drawing.Size(703, 40);
            this.groupBox_Display_options.TabIndex = 0;
            this.groupBox_Display_options.TabStop = false;
            this.groupBox_Display_options.Text = "Display options";
            // 
            // checkBoxCross
            // 
            this.checkBoxCross.AutoSize = true;
            this.checkBoxCross.Checked = true;
            this.checkBoxCross.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCross.Location = new System.Drawing.Point(300, 17);
            this.checkBoxCross.Name = "checkBoxCross";
            this.checkBoxCross.Size = new System.Drawing.Size(84, 17);
            this.checkBoxCross.TabIndex = 3;
            this.checkBoxCross.Text = "Cursor cross";
            this.checkBoxCross.UseVisualStyleBackColor = true;
            this.checkBoxCross.CheckedChanged += new System.EventHandler(this.checkBoxCross_CheckedChanged);
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.Checked = true;
            this.checkBoxLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLegend.Location = new System.Drawing.Point(205, 17);
            this.checkBoxLegend.Name = "checkBoxLegend";
            this.checkBoxLegend.Size = new System.Drawing.Size(62, 17);
            this.checkBoxLegend.TabIndex = 2;
            this.checkBoxLegend.Text = "Legend";
            this.checkBoxLegend.UseVisualStyleBackColor = true;
            this.checkBoxLegend.CheckedChanged += new System.EventHandler(this.checkBox_legend_CheckedChanged);
            // 
            // checkBoxAxes
            // 
            this.checkBoxAxes.AutoSize = true;
            this.checkBoxAxes.Checked = true;
            this.checkBoxAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAxes.Location = new System.Drawing.Point(121, 17);
            this.checkBoxAxes.Name = "checkBoxAxes";
            this.checkBoxAxes.Size = new System.Drawing.Size(49, 17);
            this.checkBoxAxes.TabIndex = 1;
            this.checkBoxAxes.Text = "Axes";
            this.checkBoxAxes.UseVisualStyleBackColor = true;
            this.checkBoxAxes.CheckedChanged += new System.EventHandler(this.checkBox_axes_CheckedChanged);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Checked = true;
            this.checkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrid.Location = new System.Drawing.Point(35, 17);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(45, 17);
            this.checkBoxGrid.TabIndex = 0;
            this.checkBoxGrid.Text = "Grid";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBox_grid_CheckedChanged);
            // 
            // UserControlGraphOnPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "UserControlGraphOnPictureBox";
            this.Size = new System.Drawing.Size(715, 466);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Display_options.ResumeLayout(false);
            this.groupBox_Display_options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_Display_options;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.CheckBox checkBoxAxes;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxCross;
    }
}
