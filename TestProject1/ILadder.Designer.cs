namespace Project1
{
    partial class ILadder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_AddGame = new System.Windows.Forms.Button();
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.listBox_PlayerList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLadderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_RemovePlayer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddGame
            // 
            this.button_AddGame.Location = new System.Drawing.Point(565, 511);
            this.button_AddGame.Name = "button_AddGame";
            this.button_AddGame.Size = new System.Drawing.Size(75, 23);
            this.button_AddGame.TabIndex = 0;
            this.button_AddGame.Text = "Add Game";
            this.button_AddGame.UseVisualStyleBackColor = true;
            this.button_AddGame.Click += new System.EventHandler(this.button_AddGame_Click);
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(523, 296);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(149, 23);
            this.button_AddPlayer.TabIndex = 1;
            this.button_AddPlayer.Text = "Add Player";
            this.button_AddPlayer.UseVisualStyleBackColor = true;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // listBox_PlayerList
            // 
            this.listBox_PlayerList.FormattingEnabled = true;
            this.listBox_PlayerList.Location = new System.Drawing.Point(523, 43);
            this.listBox_PlayerList.Name = "listBox_PlayerList";
            this.listBox_PlayerList.Size = new System.Drawing.Size(149, 238);
            this.listBox_PlayerList.TabIndex = 2;
            this.listBox_PlayerList.SelectedIndexChanged += new System.EventHandler(this.listBox_PlayerList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLadderToolStripMenuItem,
            this.loadLadderToolStripMenuItem,
            this.saveLadderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newLadderToolStripMenuItem
            // 
            this.newLadderToolStripMenuItem.Name = "newLadderToolStripMenuItem";
            this.newLadderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newLadderToolStripMenuItem.Text = "New Ladder";
            this.newLadderToolStripMenuItem.Click += new System.EventHandler(this.newLadderToolStripMenuItem_Click);
            // 
            // loadLadderToolStripMenuItem
            // 
            this.loadLadderToolStripMenuItem.Name = "loadLadderToolStripMenuItem";
            this.loadLadderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadLadderToolStripMenuItem.Text = "Load Ladder";
            this.loadLadderToolStripMenuItem.Click += new System.EventHandler(this.loadLadderToolStripMenuItem_Click);
            // 
            // saveLadderToolStripMenuItem
            // 
            this.saveLadderToolStripMenuItem.Enabled = false;
            this.saveLadderToolStripMenuItem.Name = "saveLadderToolStripMenuItem";
            this.saveLadderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveLadderToolStripMenuItem.Text = "Save Ladder";
            this.saveLadderToolStripMenuItem.Click += new System.EventHandler(this.saveLadderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "gls";
            this.saveFileDialog1.Filter = "Go Ladder Software Files (*.gls)|*.gls";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.ValidateNames = false;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "gls";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Go Ladder Software Files (*.gls)|*.gls";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Moccasin;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.IntervalOffset = -0.5D;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.IsMarksNextToAxis = false;
            chartArea6.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX.Maximum = 9.5D;
            chartArea6.AxisX.Minimum = 0.5D;
            chartArea6.AxisX.ScaleView.MinSize = 9D;
            chartArea6.AxisX.ScaleView.Size = 9D;
            chartArea6.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisX.ScaleView.Zoomable = false;
            chartArea6.AxisX.ScrollBar.Enabled = false;
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisY.Interval = 1D;
            chartArea6.AxisY.IntervalOffset = -0.5D;
            chartArea6.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.IsReversed = true;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.AxisY.MajorGrid.Interval = 1D;
            chartArea6.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea6.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Interval = 1D;
            chartArea6.AxisY.ScaleView.Position = -0.5D;
            chartArea6.AxisY.ScaleView.Size = 4D;
            chartArea6.AxisY.ScrollBar.Enabled = false;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.InnerPlotPosition.Auto = false;
            chartArea6.InnerPlotPosition.Height = 74.80259F;
            chartArea6.InnerPlotPosition.Width = 95F;
            chartArea6.InnerPlotPosition.X = 5F;
            chartArea6.InnerPlotPosition.Y = 25.19741F;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 20F;
            chartArea6.Position.Width = 90F;
            chartArea6.Position.X = 3F;
            chartArea6.Position.Y = 2F;
            chartArea7.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.IntervalOffset = -0.5D;
            chartArea7.AxisX.MajorGrid.Interval = 1D;
            chartArea7.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.AxisX.Maximum = 9.5D;
            chartArea7.AxisX.Minimum = 0.5D;
            chartArea7.AxisX.ScaleView.Size = 9D;
            chartArea7.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea7.AxisY.Interval = 1D;
            chartArea7.AxisY.IntervalOffset = -0.5D;
            chartArea7.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisY.IsReversed = true;
            chartArea7.AxisY.LabelStyle.Enabled = false;
            chartArea7.AxisY.MajorGrid.Interval = 1D;
            chartArea7.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea7.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea7.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.AxisY.MajorTickMark.Interval = 1D;
            chartArea7.AxisY.ScaleView.Position = -0.5D;
            chartArea7.AxisY.ScaleView.Size = 3D;
            chartArea7.AxisY.ScrollBar.Enabled = false;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.InnerPlotPosition.Auto = false;
            chartArea7.InnerPlotPosition.Height = 74.80259F;
            chartArea7.InnerPlotPosition.Width = 95F;
            chartArea7.InnerPlotPosition.X = 5F;
            chartArea7.InnerPlotPosition.Y = 25.19741F;
            chartArea7.Name = "ChartArea2";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 16F;
            chartArea7.Position.Width = 90F;
            chartArea7.Position.X = 3F;
            chartArea7.Position.Y = 24F;
            chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea8.AxisX.Interval = 1D;
            chartArea8.AxisX.IntervalOffset = -0.5D;
            chartArea8.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea8.AxisX.MajorTickMark.Enabled = false;
            chartArea8.AxisX.Maximum = 9.5D;
            chartArea8.AxisX.Minimum = 0.5D;
            chartArea8.AxisX.ScaleView.Size = 9D;
            chartArea8.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea8.AxisY.Interval = 1D;
            chartArea8.AxisY.IntervalOffset = -0.5D;
            chartArea8.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisY.IsReversed = true;
            chartArea8.AxisY.LabelStyle.Enabled = false;
            chartArea8.AxisY.MajorGrid.Interval = 1D;
            chartArea8.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea8.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.AxisY.MajorTickMark.Interval = 1D;
            chartArea8.AxisY.ScaleView.Position = -0.5D;
            chartArea8.AxisY.ScaleView.Size = 3D;
            chartArea8.AxisY.ScrollBar.Enabled = false;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea8.InnerPlotPosition.Auto = false;
            chartArea8.InnerPlotPosition.Height = 74.80259F;
            chartArea8.InnerPlotPosition.Width = 95F;
            chartArea8.InnerPlotPosition.X = 5F;
            chartArea8.InnerPlotPosition.Y = 25.19741F;
            chartArea8.Name = "ChartArea3";
            chartArea8.Position.Auto = false;
            chartArea8.Position.Height = 16F;
            chartArea8.Position.Width = 90F;
            chartArea8.Position.X = 3F;
            chartArea8.Position.Y = 42F;
            chartArea9.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea9.AxisX.Interval = 1D;
            chartArea9.AxisX.IntervalOffset = -0.5D;
            chartArea9.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea9.AxisX.MajorTickMark.Enabled = false;
            chartArea9.AxisX.Maximum = 9.5D;
            chartArea9.AxisX.Minimum = 0.5D;
            chartArea9.AxisX.ScaleView.Size = 9D;
            chartArea9.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea9.AxisY.Interval = 1D;
            chartArea9.AxisY.IntervalOffset = -0.5D;
            chartArea9.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.IsReversed = true;
            chartArea9.AxisY.LabelStyle.Enabled = false;
            chartArea9.AxisY.MajorGrid.Interval = 1D;
            chartArea9.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea9.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea9.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea9.AxisY.MajorTickMark.Enabled = false;
            chartArea9.AxisY.MajorTickMark.Interval = 1D;
            chartArea9.AxisY.ScaleView.Position = -0.5D;
            chartArea9.AxisY.ScaleView.Size = 2D;
            chartArea9.AxisY.ScrollBar.Enabled = false;
            chartArea9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea9.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea9.InnerPlotPosition.Auto = false;
            chartArea9.InnerPlotPosition.Height = 74.80259F;
            chartArea9.InnerPlotPosition.Width = 95F;
            chartArea9.InnerPlotPosition.X = 5F;
            chartArea9.InnerPlotPosition.Y = 25.19741F;
            chartArea9.Name = "ChartArea4";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 12F;
            chartArea9.Position.Width = 90F;
            chartArea9.Position.X = 3F;
            chartArea9.Position.Y = 62F;
            chartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea10.AxisX.Interval = 1D;
            chartArea10.AxisX.IntervalOffset = -0.5D;
            chartArea10.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea10.AxisX.MajorTickMark.Enabled = false;
            chartArea10.AxisX.Maximum = 9.5D;
            chartArea10.AxisX.Minimum = 0.5D;
            chartArea10.AxisX.ScaleView.Size = 9D;
            chartArea10.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea10.AxisY.Interval = 1D;
            chartArea10.AxisY.IntervalOffset = -0.5D;
            chartArea10.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.IsReversed = true;
            chartArea10.AxisY.LabelStyle.Enabled = false;
            chartArea10.AxisY.MajorGrid.Interval = 1D;
            chartArea10.AxisY.MajorGrid.IntervalOffset = 0.5D;
            chartArea10.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea10.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea10.AxisY.MajorTickMark.Enabled = false;
            chartArea10.AxisY.MajorTickMark.Interval = 1D;
            chartArea10.AxisY.ScaleView.Position = -0.5D;
            chartArea10.AxisY.ScaleView.Size = 2D;
            chartArea10.AxisY.ScrollBar.Enabled = false;
            chartArea10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea10.InnerPlotPosition.Auto = false;
            chartArea10.InnerPlotPosition.Height = 74.80259F;
            chartArea10.InnerPlotPosition.Width = 95F;
            chartArea10.InnerPlotPosition.X = 5F;
            chartArea10.InnerPlotPosition.Y = 25.19741F;
            chartArea10.Name = "ChartArea5";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 12F;
            chartArea10.Position.Width = 90F;
            chartArea10.Position.X = 3F;
            chartArea10.Position.Y = 77F;
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.ChartAreas.Add(chartArea7);
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.ChartAreas.Add(chartArea10);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 27);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series6.Name = "Series1";
            dataPoint2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.None;
            dataPoint2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Tile;
            dataPoint2.Color = System.Drawing.Color.Fuchsia;
            dataPoint2.CustomProperties = "PointID=18";
            dataPoint2.Label = "Example";
            dataPoint2.LegendText = "";
            dataPoint2.MarkerBorderColor = System.Drawing.Color.Red;
            dataPoint2.MarkerColor = System.Drawing.Color.Lime;
            dataPoint2.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            dataPoint2.MarkerSize = 8;
            dataPoint2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series6.Points.Add(dataPoint2);
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series7.ChartArea = "ChartArea2";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea3";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Series3";
            series9.ChartArea = "ChartArea4";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "Series4";
            series10.ChartArea = "ChartArea5";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "Series5";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(505, 549);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button_RemovePlayer
            // 
            this.button_RemovePlayer.Enabled = false;
            this.button_RemovePlayer.Location = new System.Drawing.Point(523, 334);
            this.button_RemovePlayer.Name = "button_RemovePlayer";
            this.button_RemovePlayer.Size = new System.Drawing.Size(149, 23);
            this.button_RemovePlayer.TabIndex = 5;
            this.button_RemovePlayer.Text = "Remove Player";
            this.button_RemovePlayer.UseVisualStyleBackColor = true;
            this.button_RemovePlayer.Click += new System.EventHandler(this.button_RemovePlayer_Click);
            // 
            // ILadder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 577);
            this.Controls.Add(this.button_RemovePlayer);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox_PlayerList);
            this.Controls.Add(this.button_AddPlayer);
            this.Controls.Add(this.button_AddGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ILadder";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddGame;
        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.ListBox listBox_PlayerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLadderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_RemovePlayer;

    }
}

