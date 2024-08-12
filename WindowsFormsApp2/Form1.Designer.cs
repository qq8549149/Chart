namespace MyChart
{
    partial class 图表测试demo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.时钟 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.选择框 = new System.Windows.Forms.CheckBox();
            this.查询 = new System.Windows.Forms.Button();
            this.修改 = new System.Windows.Forms.Button();
            this.生成 = new System.Windows.Forms.Button();
            this.删除 = new System.Windows.Forms.Button();
            this.排序 = new System.Windows.Forms.Button();
            this.插入 = new System.Windows.Forms.Button();
            this.数值 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.位置 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.样式 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作位置:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 时钟
            // 
            this.时钟.Interval = 1000;
            this.时钟.Tick += new System.EventHandler(this.时钟_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.样式);
            this.panel1.Controls.Add(this.选择框);
            this.panel1.Controls.Add(this.查询);
            this.panel1.Controls.Add(this.修改);
            this.panel1.Controls.Add(this.生成);
            this.panel1.Controls.Add(this.删除);
            this.panel1.Controls.Add(this.排序);
            this.panel1.Controls.Add(this.插入);
            this.panel1.Controls.Add(this.数值);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.位置);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 113);
            this.panel1.TabIndex = 3;
            // 
            // 选择框
            // 
            this.选择框.AutoSize = true;
            this.选择框.Location = new System.Drawing.Point(1077, 81);
            this.选择框.Name = "选择框";
            this.选择框.Size = new System.Drawing.Size(232, 22);
            this.选择框.TabIndex = 11;
            this.选择框.Text = "自动生成(和上面不通用)";
            this.选择框.UseVisualStyleBackColor = true;
            this.选择框.CheckedChanged += new System.EventHandler(this.选择框_CheckedChanged);
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(733, 25);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(100, 50);
            this.查询.TabIndex = 10;
            this.查询.Text = "查询一行";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 修改
            // 
            this.修改.Location = new System.Drawing.Point(852, 25);
            this.修改.Name = "修改";
            this.修改.Size = new System.Drawing.Size(100, 50);
            this.修改.TabIndex = 9;
            this.修改.Text = "修改一行";
            this.修改.UseVisualStyleBackColor = true;
            this.修改.Click += new System.EventHandler(this.修改_Click);
            // 
            // 生成
            // 
            this.生成.Location = new System.Drawing.Point(1209, 25);
            this.生成.Name = "生成";
            this.生成.Size = new System.Drawing.Size(100, 50);
            this.生成.TabIndex = 8;
            this.生成.Text = "生成数据";
            this.生成.UseVisualStyleBackColor = true;
            this.生成.Click += new System.EventHandler(this.生成_Click);
            // 
            // 删除
            // 
            this.删除.Location = new System.Drawing.Point(614, 25);
            this.删除.Name = "删除";
            this.删除.Size = new System.Drawing.Size(100, 50);
            this.删除.TabIndex = 7;
            this.删除.Text = "删除一行";
            this.删除.UseVisualStyleBackColor = true;
            this.删除.Click += new System.EventHandler(this.删除_Click);
            // 
            // 排序
            // 
            this.排序.Location = new System.Drawing.Point(971, 25);
            this.排序.Name = "排序";
            this.排序.Size = new System.Drawing.Size(100, 50);
            this.排序.TabIndex = 6;
            this.排序.Text = "数据排序";
            this.排序.UseVisualStyleBackColor = true;
            this.排序.Click += new System.EventHandler(this.排序_Click);
            // 
            // 插入
            // 
            this.插入.Location = new System.Drawing.Point(495, 25);
            this.插入.Name = "插入";
            this.插入.Size = new System.Drawing.Size(100, 50);
            this.插入.TabIndex = 5;
            this.插入.Text = "随意插入";
            this.插入.UseVisualStyleBackColor = true;
            this.插入.Click += new System.EventHandler(this.插入_Click);
            // 
            // 数值
            // 
            this.数值.Location = new System.Drawing.Point(132, 59);
            this.数值.Name = "数值";
            this.数值.Size = new System.Drawing.Size(100, 28);
            this.数值.TabIndex = 4;
            this.数值.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "插入数值:";
            // 
            // 位置
            // 
            this.位置.Location = new System.Drawing.Point(132, 25);
            this.位置.Name = "位置";
            this.位置.Size = new System.Drawing.Size(100, 28);
            this.位置.TabIndex = 2;
            this.位置.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "末尾添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(-2, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 976);
            this.panel2.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisX.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisX.MajorGrid.Interval = 0D;
            chartArea4.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea4.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorGrid.LineWidth = 2;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisX.MaximumAutoSize = 50F;
            chartArea4.AxisX.MinorGrid.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Tomato;
            chartArea4.AxisX.Title = "横坐标";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.Chartreuse;
            chartArea4.AxisX.ToolTip = "2131";
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisX2.Title = "123";
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisY.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(62)))), ((int)(((byte)(4)))));
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.MajorGrid.LineWidth = 2;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisY.MinorGrid.LineColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea4.AxisY.Title = "纵坐标";
            chartArea4.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.LimeGreen;
            chartArea4.AxisY2.Title = "321";
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.CursorX.SelectionColor = System.Drawing.Color.Transparent;
            chartArea4.CursorY.SelectionColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.HeaderSeparatorColor = System.Drawing.Color.LimeGreen;
            legend4.ItemColumnSeparatorColor = System.Drawing.Color.LimeGreen;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend4.Name = "Legend1";
            legend4.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend4.TitleForeColor = System.Drawing.Color.LimeGreen;
            legend4.TitleSeparatorColor = System.Drawing.Color.LimeGreen;
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series4.BackImage = "LimeGreen";
            series4.BackImageTransparentColor = System.Drawing.Color.LimeGreen;
            series4.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            series4.BorderColor = System.Drawing.Color.LimeGreen;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.LimeGreen;
            series4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.Transparent;
            series4.LabelBorderColor = System.Drawing.Color.Transparent;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.LabelForeColor = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.LegendText = "电压";
            series4.LegendToolTip = "电压变化";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.Name = "电压";
            series4.YValuesPerPoint = 6;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1329, 976);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "测试";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // 样式
            // 
            this.样式.Location = new System.Drawing.Point(1090, 25);
            this.样式.Name = "样式";
            this.样式.Size = new System.Drawing.Size(100, 50);
            this.样式.TabIndex = 12;
            this.样式.Text = "换个样式";
            this.样式.UseVisualStyleBackColor = true;
            this.样式.Click += new System.EventHandler(this.样式_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "清空数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 图表测试demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 1096);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "图表测试demo";
            this.Text = "图表测试demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.图表测试demo_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer 时钟;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox 位置;
        private System.Windows.Forms.TextBox 数值;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 排序;
        private System.Windows.Forms.Button 插入;
        private System.Windows.Forms.Button 删除;
        private System.Windows.Forms.Button 生成;
        private System.Windows.Forms.Button 修改;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.CheckBox 选择框;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button 样式;
        private System.Windows.Forms.Button button2;
    }
}

