namespace WeatherDiary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.WatchPlace = new System.Windows.Forms.Label();
            this.WatchPlacetextBox = new System.Windows.Forms.TextBox();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.DayLongLabel = new System.Windows.Forms.Label();
            this.DayLengthMTBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeMTBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WatchPlaceError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_WeatherCond.SuspendLayout();
            this.PercipitationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercipitationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchPlaceError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox_WeatherCond.Location = new System.Drawing.Point(12, 218);
            this.groupBox_WeatherCond.Name = "groupBox_WeatherCond";
            this.groupBox_WeatherCond.Size = new System.Drawing.Size(592, 408);
            this.groupBox_WeatherCond.TabIndex = 0;
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
            this.HailCB.Location = new System.Drawing.Point(153, 96);
            this.HailCB.Name = "HailCB";
            this.HailCB.Size = new System.Drawing.Size(78, 28);
            this.HailCB.TabIndex = 5;
            this.HailCB.Text = "Град;";
            this.HailCB.UseVisualStyleBackColor = true;
            // 
            // FogCB
            // 
            this.FogCB.AutoSize = true;
            this.FogCB.Location = new System.Drawing.Point(153, 62);
            this.FogCB.Name = "FogCB";
            this.FogCB.Size = new System.Drawing.Size(89, 28);
            this.FogCB.TabIndex = 4;
            this.FogCB.Text = "Туман;";
            this.FogCB.UseVisualStyleBackColor = true;
            // 
            // ThunderstormCB
            // 
            this.ThunderstormCB.AutoSize = true;
            this.ThunderstormCB.Location = new System.Drawing.Point(153, 28);
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
            this.NothingCB.Location = new System.Drawing.Point(6, 28);
            this.NothingCB.Name = "NothingCB";
            this.NothingCB.Size = new System.Drawing.Size(147, 28);
            this.NothingCB.TabIndex = 0;
            this.NothingCB.Text = "Без осадков;";
            this.NothingCB.UseVisualStyleBackColor = true;
            this.NothingCB.CheckedChanged += new System.EventHandler(this.NothingCB_CheckedChanged_1);
            // 
            // PercipitationUpDown
            // 
            this.PercipitationUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PercipitationUpDown.Location = new System.Drawing.Point(323, 253);
            this.PercipitationUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.PercipitationUpDown.Name = "PercipitationUpDown";
            this.PercipitationUpDown.Size = new System.Drawing.Size(120, 29);
            this.PercipitationUpDown.TabIndex = 23;
            this.PercipitationUpDown.ValueChanged += new System.EventHandler(this.PercipitationUpDown_ValueChanged);
            // 
            // HumidityUpDown
            // 
            this.HumidityUpDown.DecimalPlaces = 1;
            this.HumidityUpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.HumidityUpDown.Location = new System.Drawing.Point(323, 184);
            this.HumidityUpDown.Name = "HumidityUpDown";
            this.HumidityUpDown.Size = new System.Drawing.Size(120, 29);
            this.HumidityUpDown.TabIndex = 22;
            this.HumidityUpDown.ValueChanged += new System.EventHandler(this.HumidityUpDown_ValueChanged);
            // 
            // WindUpDown
            // 
            this.WindUpDown.DecimalPlaces = 1;
            this.WindUpDown.Location = new System.Drawing.Point(326, 123);
            this.WindUpDown.Maximum = new decimal(new int[] {
            113,
            0,
            0,
            0});
            this.WindUpDown.Name = "WindUpDown";
            this.WindUpDown.Size = new System.Drawing.Size(120, 29);
            this.WindUpDown.TabIndex = 21;
            this.WindUpDown.ValueChanged += new System.EventHandler(this.WindUpDown_ValueChanged);
            // 
            // PressureUpDown
            // 
            this.PressureUpDown.DecimalPlaces = 1;
            this.PressureUpDown.Increment = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.PressureUpDown.Location = new System.Drawing.Point(326, 60);
            this.PressureUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.PressureUpDown.Name = "PressureUpDown";
            this.PressureUpDown.Size = new System.Drawing.Size(120, 29);
            this.PressureUpDown.TabIndex = 20;
            this.PressureUpDown.ValueChanged += new System.EventHandler(this.PressureUpDown_ValueChanged);
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
            this.TemperatureUpDown.ValueChanged += new System.EventHandler(this.TemperatureUpDown_ValueChanged);
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(322, 154);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(134, 24);
            this.HumidityLabel.TabIndex = 18;
            this.HumidityLabel.Text = "Влажность, %";
            // 
            // PercipitationAmmountLabel
            // 
            this.PercipitationAmmountLabel.AutoSize = true;
            this.PercipitationAmmountLabel.Location = new System.Drawing.Point(319, 226);
            this.PercipitationAmmountLabel.Name = "PercipitationAmmountLabel";
            this.PercipitationAmmountLabel.Size = new System.Drawing.Size(186, 24);
            this.PercipitationAmmountLabel.TabIndex = 13;
            this.PercipitationAmmountLabel.Text = "Кол-во осадков, мм";
            // 
            // AtmPressureLabel
            // 
            this.AtmPressureLabel.AutoSize = true;
            this.AtmPressureLabel.Location = new System.Drawing.Point(322, 29);
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
            this.CloudBox.SelectedIndexChanged += new System.EventHandler(this.CloudBox_SelectedIndexChanged);
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Location = new System.Drawing.Point(319, 92);
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
            this.WindDirectionBox.SelectedIndexChanged += new System.EventHandler(this.WindDirectionBox_SelectedIndexChanged);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 29);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(363, 38);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(202, 65);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Записать";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(363, 129);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(202, 65);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Генерация дневника";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // WatchPlace
            // 
            this.WatchPlace.AutoSize = true;
            this.WatchPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchPlace.Location = new System.Drawing.Point(15, 165);
            this.WatchPlace.Name = "WatchPlace";
            this.WatchPlace.Size = new System.Drawing.Size(189, 24);
            this.WatchPlace.TabIndex = 4;
            this.WatchPlace.Text = "Место наблюдения:";
            // 
            // WatchPlacetextBox
            // 
            this.WatchPlacetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchPlacetextBox.Location = new System.Drawing.Point(220, 165);
            this.WatchPlacetextBox.Name = "WatchPlacetextBox";
            this.WatchPlacetextBox.Size = new System.Drawing.Size(100, 29);
            this.WatchPlacetextBox.TabIndex = 5;
            this.WatchPlacetextBox.TextChanged += new System.EventHandler(this.WatchPlacetextBox_TextChanged);
            // 
            // SeasonBox
            // 
            this.SeasonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Location = new System.Drawing.Point(176, 91);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(144, 32);
            this.SeasonBox.TabIndex = 2;
            this.SeasonBox.SelectedIndexChanged += new System.EventHandler(this.SeasonBox_SelectedIndexChanged);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeasonLabel.Location = new System.Drawing.Point(15, 94);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(119, 24);
            this.SeasonLabel.TabIndex = 3;
            this.SeasonLabel.Text = "Время года:";
            // 
            // DayLongLabel
            // 
            this.DayLongLabel.AutoSize = true;
            this.DayLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DayLongLabel.Location = new System.Drawing.Point(15, 132);
            this.DayLongLabel.Name = "DayLongLabel";
            this.DayLongLabel.Size = new System.Drawing.Size(183, 24);
            this.DayLongLabel.TabIndex = 13;
            this.DayLongLabel.Text = "Длительность дня:";
            // 
            // DayLengthMTBox
            // 
            this.DayLengthMTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DayLengthMTBox.Location = new System.Drawing.Point(220, 129);
            this.DayLengthMTBox.Mask = "00:00";
            this.DayLengthMTBox.Name = "DayLengthMTBox";
            this.DayLengthMTBox.Size = new System.Drawing.Size(100, 29);
            this.DayLengthMTBox.TabIndex = 14;
            this.DayLengthMTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DayLengthMTBox.ValidatingType = typeof(System.DateTime);
            // 
            // TimeMTBox
            // 
            this.TimeMTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TimeMTBox.Location = new System.Drawing.Point(220, 56);
            this.TimeMTBox.Mask = "00:00";
            this.TimeMTBox.Name = "TimeMTBox";
            this.TimeMTBox.Size = new System.Drawing.Size(100, 29);
            this.TimeMTBox.TabIndex = 15;
            this.TimeMTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeMTBox.ValidatingType = typeof(System.DateTime);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(15, 56);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(72, 24);
            this.TimeLabel.TabIndex = 16;
            this.TimeLabel.Text = "Время:";
            // 
            // WatchPlaceError
            // 
            this.WatchPlaceError.ContainerControl = this;
            // 
            // DateError
            // 
            this.DateError.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(616, 638);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeMTBox);
            this.Controls.Add(this.DayLengthMTBox);
            this.Controls.Add(this.WatchPlacetextBox);
            this.Controls.Add(this.DayLongLabel);
            this.Controls.Add(this.WatchPlace);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.SeasonBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox_WeatherCond);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WeatherDiary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_WeatherCond.ResumeLayout(false);
            this.groupBox_WeatherCond.PerformLayout();
            this.PercipitationGroupBox.ResumeLayout(false);
            this.PercipitationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercipitationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PressureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatchPlaceError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_WeatherCond;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label WatchPlace;
        private System.Windows.Forms.TextBox WatchPlacetextBox;
        private System.Windows.Forms.ComboBox SeasonBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.Label WindDirectionLabel;
        private System.Windows.Forms.ComboBox WindDirectionBox;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label CloudLabel;
        private System.Windows.Forms.ComboBox CloudBox;
        private System.Windows.Forms.Label DayLongLabel;
        private System.Windows.Forms.MaskedTextBox DayLengthMTBox;
        private System.Windows.Forms.Label PercipitationAmmountLabel;
        private System.Windows.Forms.Label AtmPressureLabel;
        private System.Windows.Forms.MaskedTextBox TimeMTBox;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.NumericUpDown PercipitationUpDown;
        private System.Windows.Forms.NumericUpDown HumidityUpDown;
        private System.Windows.Forms.NumericUpDown WindUpDown;
        private System.Windows.Forms.NumericUpDown PressureUpDown;
        private System.Windows.Forms.NumericUpDown TemperatureUpDown;
        private System.Windows.Forms.GroupBox PercipitationGroupBox;
        private System.Windows.Forms.CheckBox HailCB;
        private System.Windows.Forms.CheckBox FogCB;
        private System.Windows.Forms.CheckBox ThunderstormCB;
        private System.Windows.Forms.CheckBox SnowCB;
        private System.Windows.Forms.CheckBox RainCB;
        private System.Windows.Forms.CheckBox NothingCB;
        private System.Windows.Forms.ErrorProvider WatchPlaceError;
        private System.Windows.Forms.ErrorProvider DateError;
        protected System.Windows.Forms.Button SaveButton;
        protected System.Windows.Forms.Button GenerateButton;
    }
}

