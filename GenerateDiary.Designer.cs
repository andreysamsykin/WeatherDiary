namespace WeatherDiary
{
    partial class GenerateDiary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateDiary));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeMTBox = new System.Windows.Forms.MaskedTextBox();
            this.DayLengthMTBox = new System.Windows.Forms.MaskedTextBox();
            this.WatchPlacetextBox = new System.Windows.Forms.TextBox();
            this.DayLongLabel = new System.Windows.Forms.Label();
            this.WatchPlace = new System.Windows.Forms.Label();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox_WeatherCond = new System.Windows.Forms.GroupBox();
            this.PercipitationGroupBox = new System.Windows.Forms.GroupBox();
            this.HailCB = new System.Windows.Forms.CheckBox();
            this.FogCB = new System.Windows.Forms.CheckBox();
            this.ThunderstormCB = new System.Windows.Forms.CheckBox();
            this.SnowCB = new System.Windows.Forms.CheckBox();
            this.RainCB = new System.Windows.Forms.CheckBox();
            this.NothingCB = new System.Windows.Forms.CheckBox();
            this.PercipitationUpDown = new System.Windows.Forms.NumericUpDown();
            this.HumidityUpDown = new System.Windows.Forms.NumericUpDown();
            this.WindUpDown = new System.Windows.Forms.NumericUpDown();
            this.PressureUpDown = new System.Windows.Forms.NumericUpDown();
            this.TemperatureUpDown = new System.Windows.Forms.NumericUpDown();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.PercipitationAmmountLabel = new System.Windows.Forms.Label();
            this.AtmPressureLabel = new System.Windows.Forms.Label();
            this.CloudLabel = new System.Windows.Forms.Label();
            this.CloudBox = new System.Windows.Forms.ComboBox();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.WindDirectionLabel = new System.Windows.Forms.Label();
            this.WindDirectionBox = new System.Windows.Forms.ComboBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.DateRadioBTN = new System.Windows.Forms.RadioButton();
            this.DateGapRadioBTN = new System.Windows.Forms.RadioButton();
            this.WeatherRadioBTN = new System.Windows.Forms.RadioButton();
            this.TimeRadioBTN = new System.Windows.Forms.RadioButton();
            this.PlaceRadioBTN = new System.Windows.Forms.RadioButton();
            this.SeasonRadioBTN = new System.Windows.Forms.RadioButton();
            this.groupBox_WeatherCond.SuspendLayout();
            this.PercipitationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercipitationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(8, 142);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(72, 24);
            this.TimeLabel.TabIndex = 28;
            this.TimeLabel.Text = "Время:";
            // 
            // TimeMTBox
            // 
            this.TimeMTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimeMTBox.Location = new System.Drawing.Point(213, 142);
            this.TimeMTBox.Mask = "00:00";
            this.TimeMTBox.Name = "TimeMTBox";
            this.TimeMTBox.Size = new System.Drawing.Size(100, 29);
            this.TimeMTBox.TabIndex = 27;
            this.TimeMTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeMTBox.ValidatingType = typeof(System.DateTime);
            // 
            // DayLengthMTBox
            // 
            this.DayLengthMTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DayLengthMTBox.Location = new System.Drawing.Point(213, 215);
            this.DayLengthMTBox.Mask = "00:00";
            this.DayLengthMTBox.Name = "DayLengthMTBox";
            this.DayLengthMTBox.Size = new System.Drawing.Size(100, 29);
            this.DayLengthMTBox.TabIndex = 26;
            this.DayLengthMTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DayLengthMTBox.ValidatingType = typeof(System.DateTime);
            // 
            // WatchPlacetextBox
            // 
            this.WatchPlacetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchPlacetextBox.Location = new System.Drawing.Point(213, 251);
            this.WatchPlacetextBox.Name = "WatchPlacetextBox";
            this.WatchPlacetextBox.Size = new System.Drawing.Size(100, 29);
            this.WatchPlacetextBox.TabIndex = 24;
            // 
            // DayLongLabel
            // 
            this.DayLongLabel.AutoSize = true;
            this.DayLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DayLongLabel.Location = new System.Drawing.Point(8, 218);
            this.DayLongLabel.Name = "DayLongLabel";
            this.DayLongLabel.Size = new System.Drawing.Size(183, 24);
            this.DayLongLabel.TabIndex = 25;
            this.DayLongLabel.Text = "Длительность дня:";
            // 
            // WatchPlace
            // 
            this.WatchPlace.AutoSize = true;
            this.WatchPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchPlace.Location = new System.Drawing.Point(8, 251);
            this.WatchPlace.Name = "WatchPlace";
            this.WatchPlace.Size = new System.Drawing.Size(189, 24);
            this.WatchPlace.TabIndex = 23;
            this.WatchPlace.Text = "Место наблюдения:";
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeasonLabel.Location = new System.Drawing.Point(8, 180);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(119, 24);
            this.SeasonLabel.TabIndex = 21;
            this.SeasonLabel.Text = "Время года:";
            // 
            // SeasonBox
            // 
            this.SeasonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Location = new System.Drawing.Point(169, 177);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(144, 32);
            this.SeasonBox.TabIndex = 19;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(517, 216);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(202, 65);
            this.GenerateButton.TabIndex = 22;
            this.GenerateButton.Text = "Генерация дневника";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(517, 125);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(202, 65);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDatePicker.Location = new System.Drawing.Point(50, 79);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(305, 29);
            this.StartDatePicker.TabIndex = 18;
            // 
            // groupBox_WeatherCond
            // 
            this.groupBox_WeatherCond.Controls.Add(this.PercipitationGroupBox);
            this.groupBox_WeatherCond.Controls.Add(this.PercipitationUpDown);
            this.groupBox_WeatherCond.Controls.Add(this.HumidityUpDown);
            this.groupBox_WeatherCond.Controls.Add(this.WindUpDown);
            this.groupBox_WeatherCond.Controls.Add(this.PressureUpDown);
            this.groupBox_WeatherCond.Controls.Add(this.TemperatureUpDown);
            this.groupBox_WeatherCond.Controls.Add(this.HumidityLabel);
            this.groupBox_WeatherCond.Controls.Add(this.PercipitationAmmountLabel);
            this.groupBox_WeatherCond.Controls.Add(this.AtmPressureLabel);
            this.groupBox_WeatherCond.Controls.Add(this.CloudLabel);
            this.groupBox_WeatherCond.Controls.Add(this.CloudBox);
            this.groupBox_WeatherCond.Controls.Add(this.WindSpeedLabel);
            this.groupBox_WeatherCond.Controls.Add(this.WindDirectionLabel);
            this.groupBox_WeatherCond.Controls.Add(this.WindDirectionBox);
            this.groupBox_WeatherCond.Controls.Add(this.TemperatureLabel);
            this.groupBox_WeatherCond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_WeatherCond.Location = new System.Drawing.Point(50, 304);
            this.groupBox_WeatherCond.Name = "groupBox_WeatherCond";
            this.groupBox_WeatherCond.Size = new System.Drawing.Size(665, 408);
            this.groupBox_WeatherCond.TabIndex = 17;
            this.groupBox_WeatherCond.TabStop = false;
            this.groupBox_WeatherCond.Text = "Погодные условия";
            // 
            // PercipitationGroupBox
            // 
            this.PercipitationGroupBox.Controls.Add(this.HailCB);
            this.PercipitationGroupBox.Controls.Add(this.FogCB);
            this.PercipitationGroupBox.Controls.Add(this.ThunderstormCB);
            this.PercipitationGroupBox.Controls.Add(this.SnowCB);
            this.PercipitationGroupBox.Controls.Add(this.RainCB);
            this.PercipitationGroupBox.Controls.Add(this.NothingCB);
            this.PercipitationGroupBox.Location = new System.Drawing.Point(11, 235);
            this.PercipitationGroupBox.Name = "PercipitationGroupBox";
            this.PercipitationGroupBox.Size = new System.Drawing.Size(270, 156);
            this.PercipitationGroupBox.TabIndex = 24;
            this.PercipitationGroupBox.TabStop = false;
            this.PercipitationGroupBox.Text = "Осадки";
            // 
            // HailCB
            // 
            this.HailCB.AutoSize = true;
            this.HailCB.Location = new System.Drawing.Point(152, 97);
            this.HailCB.Name = "HailCB";
            this.HailCB.Size = new System.Drawing.Size(78, 28);
            this.HailCB.TabIndex = 5;
            this.HailCB.Text = "Град;";
            this.HailCB.UseVisualStyleBackColor = true;
            // 
            // FogCB
            // 
            this.FogCB.AutoSize = true;
            this.FogCB.Location = new System.Drawing.Point(152, 63);
            this.FogCB.Name = "FogCB";
            this.FogCB.Size = new System.Drawing.Size(89, 28);
            this.FogCB.TabIndex = 4;
            this.FogCB.Text = "Туман;";
            this.FogCB.UseVisualStyleBackColor = true;
            // 
            // ThunderstormCB
            // 
            this.ThunderstormCB.AutoSize = true;
            this.ThunderstormCB.Location = new System.Drawing.Point(152, 29);
            this.ThunderstormCB.Name = "ThunderstormCB";
            this.ThunderstormCB.Size = new System.Drawing.Size(87, 28);
            this.ThunderstormCB.TabIndex = 3;
            this.ThunderstormCB.Text = "Гроза;";
            this.ThunderstormCB.UseVisualStyleBackColor = true;
            // 
            // SnowCB
            // 
            this.SnowCB.AutoSize = true;
            this.SnowCB.Location = new System.Drawing.Point(7, 97);
            this.SnowCB.Name = "SnowCB";
            this.SnowCB.Size = new System.Drawing.Size(78, 28);
            this.SnowCB.TabIndex = 2;
            this.SnowCB.Text = "Снег;";
            this.SnowCB.UseVisualStyleBackColor = true;
            // 
            // RainCB
            // 
            this.RainCB.AutoSize = true;
            this.RainCB.Location = new System.Drawing.Point(7, 63);
            this.RainCB.Name = "RainCB";
            this.RainCB.Size = new System.Drawing.Size(96, 28);
            this.RainCB.TabIndex = 1;
            this.RainCB.Text = "Дождь;";
            this.RainCB.UseVisualStyleBackColor = true;
            // 
            // NothingCB
            // 
            this.NothingCB.AutoSize = true;
            this.NothingCB.Location = new System.Drawing.Point(7, 29);
            this.NothingCB.Name = "NothingCB";
            this.NothingCB.Size = new System.Drawing.Size(147, 28);
            this.NothingCB.TabIndex = 0;
            this.NothingCB.Text = "Без осадков;";
            this.NothingCB.UseVisualStyleBackColor = true;
            this.NothingCB.CheckedChanged += new System.EventHandler(this.NothingCB_CheckedChanged);
            // 
            // PercipitationUpDown
            // 
            this.PercipitationUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PercipitationUpDown.Location = new System.Drawing.Point(396, 253);
            this.PercipitationUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.PercipitationUpDown.Name = "PercipitationUpDown";
            this.PercipitationUpDown.Size = new System.Drawing.Size(120, 29);
            this.PercipitationUpDown.TabIndex = 23;
            // 
            // HumidityUpDown
            // 
            this.HumidityUpDown.DecimalPlaces = 1;
            this.HumidityUpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.HumidityUpDown.Location = new System.Drawing.Point(396, 184);
            this.HumidityUpDown.Name = "HumidityUpDown";
            this.HumidityUpDown.Size = new System.Drawing.Size(120, 29);
            this.HumidityUpDown.TabIndex = 22;
            // 
            // WindUpDown
            // 
            this.WindUpDown.DecimalPlaces = 1;
            this.WindUpDown.Location = new System.Drawing.Point(399, 123);
            this.WindUpDown.Maximum = new decimal(new int[] {
            113,
            0,
            0,
            0});
            this.WindUpDown.Name = "WindUpDown";
            this.WindUpDown.Size = new System.Drawing.Size(120, 29);
            this.WindUpDown.TabIndex = 21;
            // 
            // PressureUpDown
            // 
            this.PressureUpDown.DecimalPlaces = 1;
            this.PressureUpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.PressureUpDown.Location = new System.Drawing.Point(399, 60);
            this.PressureUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.PressureUpDown.Name = "PressureUpDown";
            this.PressureUpDown.Size = new System.Drawing.Size(120, 29);
            this.PressureUpDown.TabIndex = 20;
            // 
            // TemperatureUpDown
            // 
            this.TemperatureUpDown.DecimalPlaces = 1;
            this.TemperatureUpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.TemperatureUpDown.Location = new System.Drawing.Point(8, 60);
            this.TemperatureUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.TemperatureUpDown.Name = "TemperatureUpDown";
            this.TemperatureUpDown.Size = new System.Drawing.Size(120, 29);
            this.TemperatureUpDown.TabIndex = 19;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(395, 154);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(134, 24);
            this.HumidityLabel.TabIndex = 18;
            this.HumidityLabel.Text = "Влажность, %";
            // 
            // PercipitationAmmountLabel
            // 
            this.PercipitationAmmountLabel.AutoSize = true;
            this.PercipitationAmmountLabel.Location = new System.Drawing.Point(392, 226);
            this.PercipitationAmmountLabel.Name = "PercipitationAmmountLabel";
            this.PercipitationAmmountLabel.Size = new System.Drawing.Size(186, 24);
            this.PercipitationAmmountLabel.TabIndex = 13;
            this.PercipitationAmmountLabel.Text = "Кол-во осадков, мм";
            // 
            // AtmPressureLabel
            // 
            this.AtmPressureLabel.AutoSize = true;
            this.AtmPressureLabel.Location = new System.Drawing.Point(395, 29);
            this.AtmPressureLabel.Name = "AtmPressureLabel";
            this.AtmPressureLabel.Size = new System.Drawing.Size(264, 24);
            this.AtmPressureLabel.TabIndex = 15;
            this.AtmPressureLabel.Text = "Атмосферное давление, мм";
            // 
            // CloudLabel
            // 
            this.CloudLabel.AutoSize = true;
            this.CloudLabel.Location = new System.Drawing.Point(4, 154);
            this.CloudLabel.Name = "CloudLabel";
            this.CloudLabel.Size = new System.Drawing.Size(119, 24);
            this.CloudLabel.TabIndex = 11;
            this.CloudLabel.Text = "Облачность";
            // 
            // CloudBox
            // 
            this.CloudBox.FormattingEnabled = true;
            this.CloudBox.Location = new System.Drawing.Point(4, 181);
            this.CloudBox.Name = "CloudBox";
            this.CloudBox.Size = new System.Drawing.Size(188, 32);
            this.CloudBox.TabIndex = 10;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Location = new System.Drawing.Point(392, 92);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(192, 24);
            this.WindSpeedLabel.TabIndex = 9;
            this.WindSpeedLabel.Text = "Скорость ветра, м/с";
            // 
            // WindDirectionLabel
            // 
            this.WindDirectionLabel.AutoSize = true;
            this.WindDirectionLabel.Location = new System.Drawing.Point(4, 92);
            this.WindDirectionLabel.Name = "WindDirectionLabel";
            this.WindDirectionLabel.Size = new System.Drawing.Size(188, 24);
            this.WindDirectionLabel.TabIndex = 7;
            this.WindDirectionLabel.Text = "Направление ветра";
            // 
            // WindDirectionBox
            // 
            this.WindDirectionBox.FormattingEnabled = true;
            this.WindDirectionBox.Location = new System.Drawing.Point(4, 119);
            this.WindDirectionBox.Name = "WindDirectionBox";
            this.WindDirectionBox.Size = new System.Drawing.Size(188, 32);
            this.WindDirectionBox.TabIndex = 6;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(7, 29);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(158, 24);
            this.TemperatureLabel.TabIndex = 0;
            this.TemperatureLabel.Text = "Температура, °С";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDatePicker.Location = new System.Drawing.Point(414, 79);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(305, 29);
            this.EndDatePicker.TabIndex = 29;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StartDateLabel.Location = new System.Drawing.Point(8, 79);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(23, 24);
            this.StartDateLabel.TabIndex = 30;
            this.StartDateLabel.Text = "C";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.EndDateLabel.Location = new System.Drawing.Point(373, 79);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(32, 24);
            this.EndDateLabel.TabIndex = 31;
            this.EndDateLabel.Text = "по";
            // 
            // DateRadioBTN
            // 
            this.DateRadioBTN.AutoSize = true;
            this.DateRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DateRadioBTN.Location = new System.Drawing.Point(16, 12);
            this.DateRadioBTN.Name = "DateRadioBTN";
            this.DateRadioBTN.Size = new System.Drawing.Size(100, 28);
            this.DateRadioBTN.TabIndex = 32;
            this.DateRadioBTN.TabStop = true;
            this.DateRadioBTN.Text = "По дате";
            this.DateRadioBTN.UseVisualStyleBackColor = true;
            this.DateRadioBTN.CheckedChanged += new System.EventHandler(this.DateRadioBTN_CheckedChanged);
            // 
            // DateGapRadioBTN
            // 
            this.DateGapRadioBTN.AutoSize = true;
            this.DateGapRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DateGapRadioBTN.Location = new System.Drawing.Point(122, 12);
            this.DateGapRadioBTN.Name = "DateGapRadioBTN";
            this.DateGapRadioBTN.Size = new System.Drawing.Size(189, 28);
            this.DateGapRadioBTN.TabIndex = 33;
            this.DateGapRadioBTN.TabStop = true;
            this.DateGapRadioBTN.Text = "По диапазону дат";
            this.DateGapRadioBTN.UseVisualStyleBackColor = true;
            this.DateGapRadioBTN.CheckedChanged += new System.EventHandler(this.DateGapRadioBTN_CheckedChanged);
            // 
            // WeatherRadioBTN
            // 
            this.WeatherRadioBTN.AutoSize = true;
            this.WeatherRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.WeatherRadioBTN.Location = new System.Drawing.Point(317, 12);
            this.WeatherRadioBTN.Name = "WeatherRadioBTN";
            this.WeatherRadioBTN.Size = new System.Drawing.Size(238, 28);
            this.WeatherRadioBTN.TabIndex = 34;
            this.WeatherRadioBTN.TabStop = true;
            this.WeatherRadioBTN.Text = "По погодным условиям";
            this.WeatherRadioBTN.UseVisualStyleBackColor = true;
            this.WeatherRadioBTN.CheckedChanged += new System.EventHandler(this.WeatherRadioBTN_CheckedChanged);
            // 
            // TimeRadioBTN
            // 
            this.TimeRadioBTN.AutoSize = true;
            this.TimeRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimeRadioBTN.Location = new System.Drawing.Point(587, 15);
            this.TimeRadioBTN.Name = "TimeRadioBTN";
            this.TimeRadioBTN.Size = new System.Drawing.Size(136, 28);
            this.TimeRadioBTN.TabIndex = 35;
            this.TimeRadioBTN.TabStop = true;
            this.TimeRadioBTN.Text = "По времени";
            this.TimeRadioBTN.UseVisualStyleBackColor = true;
            this.TimeRadioBTN.CheckedChanged += new System.EventHandler(this.TimeRadioBTN_CheckedChanged);
            // 
            // PlaceRadioBTN
            // 
            this.PlaceRadioBTN.AutoSize = true;
            this.PlaceRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PlaceRadioBTN.Location = new System.Drawing.Point(12, 45);
            this.PlaceRadioBTN.Name = "PlaceRadioBTN";
            this.PlaceRadioBTN.Size = new System.Drawing.Size(226, 28);
            this.PlaceRadioBTN.TabIndex = 36;
            this.PlaceRadioBTN.TabStop = true;
            this.PlaceRadioBTN.Text = "По месту наблюдения";
            this.PlaceRadioBTN.UseVisualStyleBackColor = true;
            this.PlaceRadioBTN.CheckedChanged += new System.EventHandler(this.PlaceRadioBTN_CheckedChanged);
            // 
            // SeasonRadioBTN
            // 
            this.SeasonRadioBTN.AutoSize = true;
            this.SeasonRadioBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeasonRadioBTN.Location = new System.Drawing.Point(244, 45);
            this.SeasonRadioBTN.Name = "SeasonRadioBTN";
            this.SeasonRadioBTN.Size = new System.Drawing.Size(183, 28);
            this.SeasonRadioBTN.TabIndex = 37;
            this.SeasonRadioBTN.TabStop = true;
            this.SeasonRadioBTN.Text = "По времени года";
            this.SeasonRadioBTN.UseVisualStyleBackColor = true;
            this.SeasonRadioBTN.CheckedChanged += new System.EventHandler(this.SeasonRadioBTN_CheckedChanged);
            // 
            // GenerateDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(746, 724);
            this.Controls.Add(this.SeasonRadioBTN);
            this.Controls.Add(this.PlaceRadioBTN);
            this.Controls.Add(this.TimeRadioBTN);
            this.Controls.Add(this.WeatherRadioBTN);
            this.Controls.Add(this.DateGapRadioBTN);
            this.Controls.Add(this.DateRadioBTN);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeMTBox);
            this.Controls.Add(this.DayLengthMTBox);
            this.Controls.Add(this.WatchPlacetextBox);
            this.Controls.Add(this.DayLongLabel);
            this.Controls.Add(this.WatchPlace);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.groupBox_WeatherCond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateDiary";
            this.Text = "GenerateDiary";
            this.Load += new System.EventHandler(this.GenerateDiary_Load);
            this.groupBox_WeatherCond.ResumeLayout(false);
            this.groupBox_WeatherCond.PerformLayout();
            this.PercipitationGroupBox.ResumeLayout(false);
            this.PercipitationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercipitationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.MaskedTextBox TimeMTBox;
        public System.Windows.Forms.MaskedTextBox DayLengthMTBox;
        public System.Windows.Forms.TextBox WatchPlacetextBox;
        private System.Windows.Forms.Label DayLongLabel;
        private System.Windows.Forms.Label WatchPlace;
        private System.Windows.Forms.Label SeasonLabel;
        public System.Windows.Forms.ComboBox SeasonBox;
        protected System.Windows.Forms.Button GenerateButton;
        protected System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.DateTimePicker StartDatePicker;
        public System.Windows.Forms.GroupBox groupBox_WeatherCond;
        public System.Windows.Forms.GroupBox PercipitationGroupBox;
        public System.Windows.Forms.CheckBox HailCB;
        public System.Windows.Forms.CheckBox FogCB;
        public System.Windows.Forms.CheckBox ThunderstormCB;
        public System.Windows.Forms.CheckBox SnowCB;
        public System.Windows.Forms.CheckBox RainCB;
        public System.Windows.Forms.CheckBox NothingCB;
        public System.Windows.Forms.NumericUpDown PercipitationUpDown;
        public System.Windows.Forms.NumericUpDown HumidityUpDown;
        public System.Windows.Forms.NumericUpDown WindUpDown;
        public System.Windows.Forms.NumericUpDown PressureUpDown;
        public System.Windows.Forms.NumericUpDown TemperatureUpDown;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label PercipitationAmmountLabel;
        private System.Windows.Forms.Label AtmPressureLabel;
        private System.Windows.Forms.Label CloudLabel;
        public System.Windows.Forms.ComboBox CloudBox;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label WindDirectionLabel;
        public System.Windows.Forms.ComboBox WindDirectionBox;
        private System.Windows.Forms.Label TemperatureLabel;
        public System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        public System.Windows.Forms.RadioButton DateRadioBTN;
        public System.Windows.Forms.RadioButton DateGapRadioBTN;
        public System.Windows.Forms.RadioButton WeatherRadioBTN;
        public System.Windows.Forms.RadioButton TimeRadioBTN;
        public System.Windows.Forms.RadioButton PlaceRadioBTN;
        public System.Windows.Forms.RadioButton SeasonRadioBTN;
    }
}