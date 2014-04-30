namespace groupAssignment
{
    partial class frm_chart
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chart));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabChartPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabOptionsPage = new System.Windows.Forms.TabPage();
            this.grpbx_ma = new System.Windows.Forms.GroupBox();
            this.panel_ma2 = new System.Windows.Forms.Panel();
            this.panel_ma1 = new System.Windows.Forms.Panel();
            this.panel_ma3 = new System.Windows.Forms.Panel();
            this.cmbbx_ma3price = new System.Windows.Forms.ComboBox();
            this.cmbbx_ma2price = new System.Windows.Forms.ComboBox();
            this.numeric_ma1period = new System.Windows.Forms.NumericUpDown();
            this.cmbbx_ma1price = new System.Windows.Forms.ComboBox();
            this.lbl_ma3 = new System.Windows.Forms.Label();
            this.lbl_ma2 = new System.Windows.Forms.Label();
            this.lbl_ma1 = new System.Windows.Forms.Label();
            this.numeric_ma3period = new System.Windows.Forms.NumericUpDown();
            this.numeric_ma2period = new System.Windows.Forms.NumericUpDown();
            this.cmbbx_ma2type = new System.Windows.Forms.ComboBox();
            this.cmbbx_ma3type = new System.Windows.Forms.ComboBox();
            this.cmbbx_ma1type = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_down = new System.Windows.Forms.Panel();
            this.panel_up = new System.Windows.Forms.Panel();
            this.panel_background = new System.Windows.Forms.Panel();
            this.checkbx_showLastPrice = new System.Windows.Forms.CheckBox();
            this.lbl_showLastPrice = new System.Windows.Forms.Label();
            this.dateTime_to = new System.Windows.Forms.DateTimePicker();
            this.dateTime_from = new System.Windows.Forms.DateTimePicker();
            this.cmbbx_chartType = new System.Windows.Forms.ComboBox();
            this.lbl_backgroundColor = new System.Windows.Forms.Label();
            this.lbl_priceDownColor = new System.Windows.Forms.Label();
            this.lbl_historyFrom = new System.Windows.Forms.Label();
            this.lbl_priceUpColor = new System.Windows.Forms.Label();
            this.lbl_historyTo = new System.Windows.Forms.Label();
            this.lbl_chartType = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl.SuspendLayout();
            this.tabChartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabOptionsPage.SuspendLayout();
            this.grpbx_ma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma1period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma3period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma2period)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabChartPage);
            this.tabControl.Controls.Add(this.tabOptionsPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(907, 749);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabChartPage
            // 
            this.tabChartPage.Controls.Add(this.chart1);
            this.tabChartPage.Location = new System.Drawing.Point(4, 34);
            this.tabChartPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChartPage.Name = "tabChartPage";
            this.tabChartPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabChartPage.Size = new System.Drawing.Size(899, 711);
            this.tabChartPage.TabIndex = 0;
            this.tabChartPage.Text = "Chart";
            this.tabChartPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(3, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(893, 707);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.162304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Yellow;
            title1.Name = "close";
            title1.Position.Auto = false;
            title1.Position.Height = 3.778024F;
            title1.Position.Width = 75F;
            title1.Position.X = 25F;
            title1.Position.Y = 5F;
            title1.Text = "close:";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.162304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Yellow;
            title2.Name = "open";
            title2.Position.Auto = false;
            title2.Position.Height = 3.778024F;
            title2.Position.Width = 70F;
            title2.Position.X = 25F;
            title2.Position.Y = 8F;
            title2.Text = "open:";
            title3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.162304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.Yellow;
            title3.Name = "high";
            title3.Position.Auto = false;
            title3.Position.Height = 3.778024F;
            title3.Position.Width = 70F;
            title3.Position.X = 25F;
            title3.Position.Y = 11F;
            title3.Text = "high:";
            title4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.162304F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.Yellow;
            title4.Name = "low";
            title4.Position.Auto = false;
            title4.Position.Height = 3.778024F;
            title4.Position.Width = 70F;
            title4.Position.X = 25F;
            title4.Position.Y = 14F;
            title4.Text = "low:";
            title5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title5.ForeColor = System.Drawing.Color.Yellow;
            title5.Name = "time";
            title5.Position.Auto = false;
            title5.Position.Height = 3.778024F;
            title5.Position.Width = 70F;
            title5.Position.X = 25F;
            title5.Position.Y = 18F;
            title5.Text = "date";
            title6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title6.ForeColor = System.Drawing.Color.Yellow;
            title6.Name = "date";
            title6.Position.Auto = false;
            title6.Position.Height = 3.778024F;
            title6.Position.Width = 75F;
            title6.Position.X = 25F;
            title6.Position.Y = 22F;
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            this.chart1.Titles.Add(title4);
            this.chart1.Titles.Add(title5);
            this.chart1.Titles.Add(title6);
            this.chart1.CursorPositionChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chart1_CursorPositionChanged_1);
            this.chart1.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chart1_AxisViewChanged_1);
            // 
            // tabOptionsPage
            // 
            this.tabOptionsPage.Controls.Add(this.grpbx_ma);
            this.tabOptionsPage.Controls.Add(this.groupBox1);
            this.tabOptionsPage.Controls.Add(this.btn_update);
            this.tabOptionsPage.Location = new System.Drawing.Point(4, 34);
            this.tabOptionsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOptionsPage.Name = "tabOptionsPage";
            this.tabOptionsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOptionsPage.Size = new System.Drawing.Size(899, 711);
            this.tabOptionsPage.TabIndex = 1;
            this.tabOptionsPage.Text = "Options";
            this.tabOptionsPage.UseVisualStyleBackColor = true;
            // 
            // grpbx_ma
            // 
            this.grpbx_ma.Controls.Add(this.panel_ma2);
            this.grpbx_ma.Controls.Add(this.panel_ma1);
            this.grpbx_ma.Controls.Add(this.panel_ma3);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma3price);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma2price);
            this.grpbx_ma.Controls.Add(this.numeric_ma1period);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma1price);
            this.grpbx_ma.Controls.Add(this.lbl_ma3);
            this.grpbx_ma.Controls.Add(this.lbl_ma2);
            this.grpbx_ma.Controls.Add(this.lbl_ma1);
            this.grpbx_ma.Controls.Add(this.numeric_ma3period);
            this.grpbx_ma.Controls.Add(this.numeric_ma2period);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma2type);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma3type);
            this.grpbx_ma.Controls.Add(this.cmbbx_ma1type);
            this.grpbx_ma.Location = new System.Drawing.Point(24, 418);
            this.grpbx_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbx_ma.Name = "grpbx_ma";
            this.grpbx_ma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbx_ma.Size = new System.Drawing.Size(636, 256);
            this.grpbx_ma.TabIndex = 14;
            this.grpbx_ma.TabStop = false;
            this.grpbx_ma.Text = "Moving Averages";
            // 
            // panel_ma2
            // 
            this.panel_ma2.BackColor = System.Drawing.Color.Red;
            this.panel_ma2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ma2.Location = new System.Drawing.Point(452, 96);
            this.panel_ma2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ma2.Name = "panel_ma2";
            this.panel_ma2.Size = new System.Drawing.Size(67, 33);
            this.panel_ma2.TabIndex = 17;
            this.panel_ma2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_ma2_MouseClick);
            // 
            // panel_ma1
            // 
            this.panel_ma1.BackColor = System.Drawing.Color.Lime;
            this.panel_ma1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ma1.Location = new System.Drawing.Point(452, 48);
            this.panel_ma1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ma1.Name = "panel_ma1";
            this.panel_ma1.Size = new System.Drawing.Size(67, 31);
            this.panel_ma1.TabIndex = 17;
            this.panel_ma1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_ma1_MouseClick);
            // 
            // panel_ma3
            // 
            this.panel_ma3.BackColor = System.Drawing.Color.Fuchsia;
            this.panel_ma3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ma3.Location = new System.Drawing.Point(452, 145);
            this.panel_ma3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ma3.Name = "panel_ma3";
            this.panel_ma3.Size = new System.Drawing.Size(67, 33);
            this.panel_ma3.TabIndex = 18;
            this.panel_ma3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_ma3_MouseClick);
            // 
            // cmbbx_ma3price
            // 
            this.cmbbx_ma3price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma3price.FormattingEnabled = true;
            this.cmbbx_ma3price.Items.AddRange(new object[] {
            "close",
            "open",
            "high",
            "low"});
            this.cmbbx_ma3price.Location = new System.Drawing.Point(207, 145);
            this.cmbbx_ma3price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma3price.Name = "cmbbx_ma3price";
            this.cmbbx_ma3price.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma3price.TabIndex = 8;
            // 
            // cmbbx_ma2price
            // 
            this.cmbbx_ma2price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma2price.FormattingEnabled = true;
            this.cmbbx_ma2price.Items.AddRange(new object[] {
            "close",
            "open",
            "high",
            "low"});
            this.cmbbx_ma2price.Location = new System.Drawing.Point(207, 96);
            this.cmbbx_ma2price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma2price.Name = "cmbbx_ma2price";
            this.cmbbx_ma2price.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma2price.TabIndex = 7;
            // 
            // numeric_ma1period
            // 
            this.numeric_ma1period.Location = new System.Drawing.Point(344, 48);
            this.numeric_ma1period.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_ma1period.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_ma1period.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_ma1period.Name = "numeric_ma1period";
            this.numeric_ma1period.Size = new System.Drawing.Size(80, 31);
            this.numeric_ma1period.TabIndex = 9;
            this.numeric_ma1period.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // cmbbx_ma1price
            // 
            this.cmbbx_ma1price.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma1price.FormattingEnabled = true;
            this.cmbbx_ma1price.Items.AddRange(new object[] {
            "close",
            "open",
            "high",
            "low"});
            this.cmbbx_ma1price.Location = new System.Drawing.Point(207, 48);
            this.cmbbx_ma1price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma1price.Name = "cmbbx_ma1price";
            this.cmbbx_ma1price.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma1price.TabIndex = 6;
            // 
            // lbl_ma3
            // 
            this.lbl_ma3.AutoSize = true;
            this.lbl_ma3.Location = new System.Drawing.Point(19, 150);
            this.lbl_ma3.Name = "lbl_ma3";
            this.lbl_ma3.Size = new System.Drawing.Size(42, 26);
            this.lbl_ma3.TabIndex = 11;
            this.lbl_ma3.Text = "#3:";
            // 
            // lbl_ma2
            // 
            this.lbl_ma2.AutoSize = true;
            this.lbl_ma2.Location = new System.Drawing.Point(17, 100);
            this.lbl_ma2.Name = "lbl_ma2";
            this.lbl_ma2.Size = new System.Drawing.Size(42, 26);
            this.lbl_ma2.TabIndex = 10;
            this.lbl_ma2.Text = "#2:";
            // 
            // lbl_ma1
            // 
            this.lbl_ma1.AutoSize = true;
            this.lbl_ma1.Location = new System.Drawing.Point(17, 50);
            this.lbl_ma1.Name = "lbl_ma1";
            this.lbl_ma1.Size = new System.Drawing.Size(42, 26);
            this.lbl_ma1.TabIndex = 9;
            this.lbl_ma1.Text = "#1:";
            // 
            // numeric_ma3period
            // 
            this.numeric_ma3period.Location = new System.Drawing.Point(344, 145);
            this.numeric_ma3period.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_ma3period.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_ma3period.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_ma3period.Name = "numeric_ma3period";
            this.numeric_ma3period.Size = new System.Drawing.Size(80, 31);
            this.numeric_ma3period.TabIndex = 11;
            this.numeric_ma3period.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // numeric_ma2period
            // 
            this.numeric_ma2period.Location = new System.Drawing.Point(344, 96);
            this.numeric_ma2period.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_ma2period.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numeric_ma2period.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_ma2period.Name = "numeric_ma2period";
            this.numeric_ma2period.Size = new System.Drawing.Size(80, 31);
            this.numeric_ma2period.TabIndex = 10;
            this.numeric_ma2period.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // cmbbx_ma2type
            // 
            this.cmbbx_ma2type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma2type.FormattingEnabled = true;
            this.cmbbx_ma2type.Items.AddRange(new object[] {
            "none",
            "Simple",
            "Exponential",
            "Weighted"});
            this.cmbbx_ma2type.Location = new System.Drawing.Point(67, 98);
            this.cmbbx_ma2type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma2type.Name = "cmbbx_ma2type";
            this.cmbbx_ma2type.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma2type.TabIndex = 4;
            // 
            // cmbbx_ma3type
            // 
            this.cmbbx_ma3type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma3type.FormattingEnabled = true;
            this.cmbbx_ma3type.Items.AddRange(new object[] {
            "none",
            "Simple",
            "Exponential",
            "Weighted"});
            this.cmbbx_ma3type.Location = new System.Drawing.Point(67, 148);
            this.cmbbx_ma3type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma3type.Name = "cmbbx_ma3type";
            this.cmbbx_ma3type.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma3type.TabIndex = 5;
            // 
            // cmbbx_ma1type
            // 
            this.cmbbx_ma1type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_ma1type.FormattingEnabled = true;
            this.cmbbx_ma1type.Items.AddRange(new object[] {
            "none",
            "Simple",
            "Exponential",
            "Weighted"});
            this.cmbbx_ma1type.Location = new System.Drawing.Point(67, 48);
            this.cmbbx_ma1type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_ma1type.Name = "cmbbx_ma1type";
            this.cmbbx_ma1type.Size = new System.Drawing.Size(121, 33);
            this.cmbbx_ma1type.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_down);
            this.groupBox1.Controls.Add(this.panel_up);
            this.groupBox1.Controls.Add(this.panel_background);
            this.groupBox1.Controls.Add(this.checkbx_showLastPrice);
            this.groupBox1.Controls.Add(this.lbl_showLastPrice);
            this.groupBox1.Controls.Add(this.dateTime_to);
            this.groupBox1.Controls.Add(this.dateTime_from);
            this.groupBox1.Controls.Add(this.cmbbx_chartType);
            this.groupBox1.Controls.Add(this.lbl_backgroundColor);
            this.groupBox1.Controls.Add(this.lbl_priceDownColor);
            this.groupBox1.Controls.Add(this.lbl_historyFrom);
            this.groupBox1.Controls.Add(this.lbl_priceUpColor);
            this.groupBox1.Controls.Add(this.lbl_historyTo);
            this.groupBox1.Controls.Add(this.lbl_chartType);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(637, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // panel_down
            // 
            this.panel_down.BackColor = System.Drawing.Color.Lime;
            this.panel_down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_down.Location = new System.Drawing.Point(243, 172);
            this.panel_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_down.Name = "panel_down";
            this.panel_down.Size = new System.Drawing.Size(133, 33);
            this.panel_down.TabIndex = 18;
            this.panel_down.Click += new System.EventHandler(this.panel_down_Click);
            // 
            // panel_up
            // 
            this.panel_up.BackColor = System.Drawing.Color.Lime;
            this.panel_up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_up.Location = new System.Drawing.Point(243, 129);
            this.panel_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_up.Name = "panel_up";
            this.panel_up.Size = new System.Drawing.Size(133, 33);
            this.panel_up.TabIndex = 17;
            this.panel_up.Click += new System.EventHandler(this.panel_up_Click);
            // 
            // panel_background
            // 
            this.panel_background.BackColor = System.Drawing.Color.Lime;
            this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_background.Location = new System.Drawing.Point(243, 88);
            this.panel_background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(133, 31);
            this.panel_background.TabIndex = 16;
            this.panel_background.Click += new System.EventHandler(this.panel_background_Click);
            // 
            // checkbx_showLastPrice
            // 
            this.checkbx_showLastPrice.AutoSize = true;
            this.checkbx_showLastPrice.Checked = true;
            this.checkbx_showLastPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbx_showLastPrice.Location = new System.Drawing.Point(243, 298);
            this.checkbx_showLastPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbx_showLastPrice.Name = "checkbx_showLastPrice";
            this.checkbx_showLastPrice.Size = new System.Drawing.Size(196, 30);
            this.checkbx_showLastPrice.TabIndex = 14;
            this.checkbx_showLastPrice.Text = "Show &Last Price";
            this.checkbx_showLastPrice.UseVisualStyleBackColor = true;
            // 
            // lbl_showLastPrice
            // 
            this.lbl_showLastPrice.AutoSize = true;
            this.lbl_showLastPrice.Location = new System.Drawing.Point(19, 302);
            this.lbl_showLastPrice.Name = "lbl_showLastPrice";
            this.lbl_showLastPrice.Size = new System.Drawing.Size(0, 26);
            this.lbl_showLastPrice.TabIndex = 13;
            // 
            // dateTime_to
            // 
            this.dateTime_to.Location = new System.Drawing.Point(243, 256);
            this.dateTime_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_to.Name = "dateTime_to";
            this.dateTime_to.Size = new System.Drawing.Size(375, 31);
            this.dateTime_to.TabIndex = 12;
            // 
            // dateTime_from
            // 
            this.dateTime_from.Location = new System.Drawing.Point(243, 215);
            this.dateTime_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_from.Name = "dateTime_from";
            this.dateTime_from.Size = new System.Drawing.Size(375, 31);
            this.dateTime_from.TabIndex = 11;
            // 
            // cmbbx_chartType
            // 
            this.cmbbx_chartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_chartType.FormattingEnabled = true;
            this.cmbbx_chartType.Items.AddRange(new object[] {
            "Candlesticks",
            "Bars"});
            this.cmbbx_chartType.Location = new System.Drawing.Point(243, 45);
            this.cmbbx_chartType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbx_chartType.Name = "cmbbx_chartType";
            this.cmbbx_chartType.Size = new System.Drawing.Size(168, 33);
            this.cmbbx_chartType.TabIndex = 10;
            // 
            // lbl_backgroundColor
            // 
            this.lbl_backgroundColor.AutoSize = true;
            this.lbl_backgroundColor.Location = new System.Drawing.Point(16, 92);
            this.lbl_backgroundColor.Name = "lbl_backgroundColor";
            this.lbl_backgroundColor.Size = new System.Drawing.Size(181, 26);
            this.lbl_backgroundColor.TabIndex = 5;
            this.lbl_backgroundColor.Text = "&Background color";
            // 
            // lbl_priceDownColor
            // 
            this.lbl_priceDownColor.AutoSize = true;
            this.lbl_priceDownColor.Location = new System.Drawing.Point(16, 178);
            this.lbl_priceDownColor.Name = "lbl_priceDownColor";
            this.lbl_priceDownColor.Size = new System.Drawing.Size(201, 26);
            this.lbl_priceDownColor.TabIndex = 4;
            this.lbl_priceDownColor.Text = "Candle &Down Color";
            // 
            // lbl_historyFrom
            // 
            this.lbl_historyFrom.AutoSize = true;
            this.lbl_historyFrom.Location = new System.Drawing.Point(16, 219);
            this.lbl_historyFrom.Name = "lbl_historyFrom";
            this.lbl_historyFrom.Size = new System.Drawing.Size(198, 26);
            this.lbl_historyFrom.TabIndex = 3;
            this.lbl_historyFrom.Text = "Show History &From";
            // 
            // lbl_priceUpColor
            // 
            this.lbl_priceUpColor.AutoSize = true;
            this.lbl_priceUpColor.Location = new System.Drawing.Point(16, 135);
            this.lbl_priceUpColor.Name = "lbl_priceUpColor";
            this.lbl_priceUpColor.Size = new System.Drawing.Size(173, 26);
            this.lbl_priceUpColor.TabIndex = 2;
            this.lbl_priceUpColor.Text = "Candle &Up Color";
            // 
            // lbl_historyTo
            // 
            this.lbl_historyTo.AutoSize = true;
            this.lbl_historyTo.Location = new System.Drawing.Point(16, 261);
            this.lbl_historyTo.Name = "lbl_historyTo";
            this.lbl_historyTo.Size = new System.Drawing.Size(171, 26);
            this.lbl_historyTo.TabIndex = 1;
            this.lbl_historyTo.Text = "Show History &To";
            // 
            // lbl_chartType
            // 
            this.lbl_chartType.AutoSize = true;
            this.lbl_chartType.Location = new System.Drawing.Point(16, 51);
            this.lbl_chartType.Name = "lbl_chartType";
            this.lbl_chartType.Size = new System.Drawing.Size(118, 26);
            this.lbl_chartType.TabIndex = 0;
            this.lbl_chartType.Text = "&Chart Type";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(699, 31);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 49);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "&Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // frm_chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(907, 749);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_chart";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_chart_Load);
            this.tabControl.ResumeLayout(false);
            this.tabChartPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabOptionsPage.ResumeLayout(false);
            this.grpbx_ma.ResumeLayout(false);
            this.grpbx_ma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma1period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma3period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ma2period)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabChartPage;
        private System.Windows.Forms.TabPage tabOptionsPage;
        private System.Windows.Forms.Label lbl_backgroundColor;
        private System.Windows.Forms.Label lbl_priceDownColor;
        private System.Windows.Forms.Label lbl_historyFrom;
        private System.Windows.Forms.Label lbl_priceUpColor;
        private System.Windows.Forms.Label lbl_historyTo;
        private System.Windows.Forms.Label lbl_chartType;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_to;
        private System.Windows.Forms.DateTimePicker dateTime_from;
        private System.Windows.Forms.ComboBox cmbbx_chartType;
        private System.Windows.Forms.CheckBox checkbx_showLastPrice;
        private System.Windows.Forms.Label lbl_showLastPrice;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Panel panel_up;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox grpbx_ma;
        private System.Windows.Forms.Panel panel_ma2;
        private System.Windows.Forms.Panel panel_ma1;
        private System.Windows.Forms.Panel panel_ma3;
        private System.Windows.Forms.ComboBox cmbbx_ma3price;
        private System.Windows.Forms.ComboBox cmbbx_ma2price;
        private System.Windows.Forms.NumericUpDown numeric_ma1period;
        private System.Windows.Forms.ComboBox cmbbx_ma1price;
        private System.Windows.Forms.Label lbl_ma3;
        private System.Windows.Forms.Label lbl_ma2;
        private System.Windows.Forms.Label lbl_ma1;
        private System.Windows.Forms.NumericUpDown numeric_ma3period;
        private System.Windows.Forms.NumericUpDown numeric_ma2period;
        private System.Windows.Forms.ComboBox cmbbx_ma2type;
        private System.Windows.Forms.ComboBox cmbbx_ma3type;
        private System.Windows.Forms.ComboBox cmbbx_ma1type;




    }
}

