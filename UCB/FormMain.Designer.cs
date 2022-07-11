namespace UCB
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.numericUpDownCountThreads = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA0 = new System.Windows.Forms.NumericUpDown();
            this.labelA0 = new System.Windows.Forms.Label();
            this.numericUpDownDeltaA = new System.Windows.Forms.NumericUpDown();
            this.labelDeltaA = new System.Windows.Forms.Label();
            this.labelAN = new System.Windows.Forms.Label();
            this.textBoxAn = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxBorderA = new System.Windows.Forms.GroupBox();
            this.labelCountOfSimulations = new System.Windows.Forms.Label();
            this.numericUpDownCountOfSimulations = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMainSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDownD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaA)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxBorderA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountOfSimulations)).BeginInit();
            this.groupBoxMainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 2.5D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Maximum = 7.5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "d";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Interval = 0.2D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "l(d)";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 27);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(699, 446);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(717, 380);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Запуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(144, 22);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownK.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownK.TabIndex = 3;
            this.numericUpDownK.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownK.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Location = new System.Drawing.Point(12, 499);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(932, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(423, 479);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(107, 17);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Выполнено 0%";
            this.labelProgress.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(717, 433);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 40);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(46, 81);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(92, 17);
            this.labelInfo1.TabIndex = 10;
            this.labelInfo1.Text = "Горизонт N: ";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(30, 117);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(130, 17);
            this.labelInfo2.TabIndex = 13;
            this.labelInfo2.Text = "Число вариантов: ";
            // 
            // numericUpDownCountThreads
            // 
            this.numericUpDownCountThreads.Location = new System.Drawing.Point(166, 115);
            this.numericUpDownCountThreads.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCountThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountThreads.Name = "numericUpDownCountThreads";
            this.numericUpDownCountThreads.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownCountThreads.TabIndex = 12;
            this.numericUpDownCountThreads.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownCountThreads.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownA0
            // 
            this.numericUpDownA0.DecimalPlaces = 2;
            this.numericUpDownA0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownA0.Location = new System.Drawing.Point(166, 26);
            this.numericUpDownA0.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownA0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownA0.Name = "numericUpDownA0";
            this.numericUpDownA0.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownA0.TabIndex = 16;
            this.numericUpDownA0.Value = new decimal(new int[] {
            95,
            0,
            0,
            131072});
            this.numericUpDownA0.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelA0
            // 
            this.labelA0.AutoSize = true;
            this.labelA0.Location = new System.Drawing.Point(4, 28);
            this.labelA0.Name = "labelA0";
            this.labelA0.Size = new System.Drawing.Size(156, 17);
            this.labelA0.TabIndex = 15;
            this.labelA0.Text = "Начальное значение: ";
            // 
            // numericUpDownDeltaA
            // 
            this.numericUpDownDeltaA.DecimalPlaces = 2;
            this.numericUpDownDeltaA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDeltaA.Location = new System.Drawing.Point(166, 55);
            this.numericUpDownDeltaA.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDeltaA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownDeltaA.Name = "numericUpDownDeltaA";
            this.numericUpDownDeltaA.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownDeltaA.TabIndex = 18;
            this.numericUpDownDeltaA.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownDeltaA.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // labelDeltaA
            // 
            this.labelDeltaA.AutoSize = true;
            this.labelDeltaA.Location = new System.Drawing.Point(32, 57);
            this.labelDeltaA.Name = "labelDeltaA";
            this.labelDeltaA.Size = new System.Drawing.Size(128, 17);
            this.labelDeltaA.TabIndex = 17;
            this.labelDeltaA.Text = "Шаг изменения а: ";
            // 
            // labelAN
            // 
            this.labelAN.AutoSize = true;
            this.labelAN.Location = new System.Drawing.Point(12, 87);
            this.labelAN.Name = "labelAN";
            this.labelAN.Size = new System.Drawing.Size(148, 17);
            this.labelAN.TabIndex = 19;
            this.labelAN.Text = "Конечное значение: ";
            // 
            // textBoxAn
            // 
            this.textBoxAn.Enabled = false;
            this.textBoxAn.Location = new System.Drawing.Point(166, 84);
            this.textBoxAn.Name = "textBoxAn";
            this.textBoxAn.ReadOnly = true;
            this.textBoxAn.Size = new System.Drawing.Size(53, 23);
            this.textBoxAn.TabIndex = 20;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(956, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьВсёToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьВсёToolStripMenuItem
            // 
            this.сохранитьВсёToolStripMenuItem.Name = "сохранитьВсёToolStripMenuItem";
            this.сохранитьВсёToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьВсёToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сохранитьВсёToolStripMenuItem.Text = "Сохранить всё";
            this.сохранитьВсёToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсёToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(835, 373);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(108, 100);
            this.groupBoxResult.TabIndex = 23;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результаты";
            // 
            // groupBoxBorderA
            // 
            this.groupBoxBorderA.Controls.Add(this.numericUpDownA0);
            this.groupBoxBorderA.Controls.Add(this.labelA0);
            this.groupBoxBorderA.Controls.Add(this.textBoxAn);
            this.groupBoxBorderA.Controls.Add(this.labelDeltaA);
            this.groupBoxBorderA.Controls.Add(this.labelInfo2);
            this.groupBoxBorderA.Controls.Add(this.numericUpDownCountThreads);
            this.groupBoxBorderA.Controls.Add(this.labelAN);
            this.groupBoxBorderA.Controls.Add(this.numericUpDownDeltaA);
            this.groupBoxBorderA.Location = new System.Drawing.Point(717, 228);
            this.groupBoxBorderA.Name = "groupBoxBorderA";
            this.groupBoxBorderA.Size = new System.Drawing.Size(227, 146);
            this.groupBoxBorderA.TabIndex = 24;
            this.groupBoxBorderA.TabStop = false;
            this.groupBoxBorderA.Text = "Диапазон поиска а";
            // 
            // labelCountOfSimulations
            // 
            this.labelCountOfSimulations.AutoSize = true;
            this.labelCountOfSimulations.Location = new System.Drawing.Point(8, 109);
            this.labelCountOfSimulations.Name = "labelCountOfSimulations";
            this.labelCountOfSimulations.Size = new System.Drawing.Size(132, 17);
            this.labelCountOfSimulations.TabIndex = 25;
            this.labelCountOfSimulations.Text = "Число симуляций: ";
            // 
            // numericUpDownCountOfSimulations
            // 
            this.numericUpDownCountOfSimulations.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownCountOfSimulations.Location = new System.Drawing.Point(144, 107);
            this.numericUpDownCountOfSimulations.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDownCountOfSimulations.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownCountOfSimulations.Name = "numericUpDownCountOfSimulations";
            this.numericUpDownCountOfSimulations.ReadOnly = true;
            this.numericUpDownCountOfSimulations.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownCountOfSimulations.TabIndex = 27;
            this.numericUpDownCountOfSimulations.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // groupBoxMainSettings
            // 
            this.groupBoxMainSettings.Controls.Add(this.numericUpDownD);
            this.groupBoxMainSettings.Controls.Add(this.label4);
            this.groupBoxMainSettings.Controls.Add(this.numericUpDownP);
            this.groupBoxMainSettings.Controls.Add(this.label3);
            this.groupBoxMainSettings.Controls.Add(this.textBoxN);
            this.groupBoxMainSettings.Controls.Add(this.numericUpDownM);
            this.groupBoxMainSettings.Controls.Add(this.label2);
            this.groupBoxMainSettings.Controls.Add(this.label1);
            this.groupBoxMainSettings.Controls.Add(this.numericUpDownCountOfSimulations);
            this.groupBoxMainSettings.Controls.Add(this.labelInfo1);
            this.groupBoxMainSettings.Controls.Add(this.labelCountOfSimulations);
            this.groupBoxMainSettings.Controls.Add(this.numericUpDownK);
            this.groupBoxMainSettings.Location = new System.Drawing.Point(717, 27);
            this.groupBoxMainSettings.Name = "groupBoxMainSettings";
            this.groupBoxMainSettings.Size = new System.Drawing.Size(226, 195);
            this.groupBoxMainSettings.TabIndex = 27;
            this.groupBoxMainSettings.TabStop = false;
            this.groupBoxMainSettings.Text = "Настройки";
            // 
            // numericUpDownD
            // 
            this.numericUpDownD.DecimalPlaces = 2;
            this.numericUpDownD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownD.Location = new System.Drawing.Point(144, 160);
            this.numericUpDownD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownD.Name = "numericUpDownD";
            this.numericUpDownD.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownD.TabIndex = 33;
            this.numericUpDownD.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Дисперсия D: ";
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.DecimalPlaces = 2;
            this.numericUpDownP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownP.Location = new System.Drawing.Point(144, 133);
            this.numericUpDownP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownP.TabIndex = 22;
            this.numericUpDownP.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Вероятность p: ";
            // 
            // textBoxN
            // 
            this.textBoxN.Enabled = false;
            this.textBoxN.Location = new System.Drawing.Point(144, 78);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(76, 23);
            this.textBoxN.TabIndex = 31;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(144, 49);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownM.TabIndex = 30;
            this.numericUpDownM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Размер пакета M: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Число пакетов K: ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(95, 75);
            this.textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 531);
            this.Controls.Add(this.groupBoxMainSettings);
            this.Controls.Add(this.groupBoxBorderA);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaA)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxBorderA.ResumeLayout(false);
            this.groupBoxBorderA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountOfSimulations)).EndInit();
            this.groupBoxMainSettings.ResumeLayout(false);
            this.groupBoxMainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.NumericUpDown numericUpDownCountThreads;
        private System.Windows.Forms.NumericUpDown numericUpDownA0;
        private System.Windows.Forms.Label labelA0;
        private System.Windows.Forms.NumericUpDown numericUpDownDeltaA;
        private System.Windows.Forms.Label labelDeltaA;
        private System.Windows.Forms.Label labelAN;
        private System.Windows.Forms.TextBox textBoxAn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxBorderA;
        private System.Windows.Forms.Label labelCountOfSimulations;
        private System.Windows.Forms.GroupBox groupBoxMainSettings;
        private System.Windows.Forms.NumericUpDown numericUpDownCountOfSimulations;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВсёToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}