namespace Test_IBA_AG
{
    partial class UserControlGraphOnChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox_Display_options = new System.Windows.Forms.GroupBox();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.checkBoxAxes = new System.Windows.Forms.CheckBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox_Display_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Controls.Add(this.groupBox_Display_options);
            this.groupBox4.Location = new System.Drawing.Point(0, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(715, 466);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graphs";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.Blue;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(703, 395);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.CustomizeLegend += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CustomizeLegendEventArgs>(this.chart1_CustomizeLegend);
            // 
            // groupBox_Display_options
            // 
            this.groupBox_Display_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Display_options.Controls.Add(this.checkBoxLegend);
            this.groupBox_Display_options.Controls.Add(this.checkBoxAxes);
            this.groupBox_Display_options.Controls.Add(this.checkBoxGrid);
            this.groupBox_Display_options.Location = new System.Drawing.Point(6, 420);
            this.groupBox_Display_options.Name = "groupBox_Display_options";
            this.groupBox_Display_options.Size = new System.Drawing.Size(709, 40);
            this.groupBox_Display_options.TabIndex = 0;
            this.groupBox_Display_options.TabStop = false;
            this.groupBox_Display_options.Text = "Display options";
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.Checked = true;
            this.checkBoxLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLegend.Location = new System.Drawing.Point(207, 17);
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
            // UserControlGraphOnChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "UserControlGraphOnChart";
            this.Size = new System.Drawing.Size(715, 466);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox_Display_options.ResumeLayout(false);
            this.groupBox_Display_options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox_Display_options;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.CheckBox checkBoxAxes;
        private System.Windows.Forms.CheckBox checkBoxGrid;
    }
}
