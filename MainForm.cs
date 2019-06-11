using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace WeatherDiary
{
    public partial class MainForm : Form
    {

        //конструктор главной формы
        public MainForm()
        {
            InitializeComponent();

            //значение по умолчанию для dateTimePicker - сегодняшнее
            dateTimePicker1.Value = DateTime.Today;

            //добавление полей в комбобоксы времени года, направления ветра и облачности
            SeasonBox.Items.Add("Зима");
            SeasonBox.Items.Add("Весна");
            SeasonBox.Items.Add("Лето");
            SeasonBox.Items.Add("Осень");


            WindDirectionBox.Items.Add("Штиль");
            WindDirectionBox.Items.Add("Северный");
            WindDirectionBox.Items.Add("Восточный");
            WindDirectionBox.Items.Add("Южный");
            WindDirectionBox.Items.Add("Западный");
            WindDirectionBox.Items.Add("Северо-восточный");
            WindDirectionBox.Items.Add("Северо-западный");
            WindDirectionBox.Items.Add("Юго-восточный");
            WindDirectionBox.Items.Add("Юго-западный");

            CloudBox.Items.Add("Переменная");
            CloudBox.Items.Add("Низкая");
            CloudBox.Items.Add("Сплошная");

            //валидация даты и места наблюдения - они должны быть не пустыми
            WatchPlacetextBox.Validating += WatchPlacetextBox_Validating;
            dateTimePicker1.Validating += Date_Validating;

            //запрет на ввод собственных символов в комбобоксы ветра, облачности, времени года
            WindDirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CloudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SeasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        DateTime today = DateTime.Now; //сегоднящняя дата
        DateTime choosedDate;  //дата, введенная в datePicker 
        string season; //время года
        string watchPlace; //место наблюдения
        string dayLength; //длитедьность дня
        string time; // время наблюдения
        double temperature; //температура
        double atmPressure; //давление
        string wind; //ветер
        double windSpeed; //скорость ветра
        string cloudness; //облачность
        double humidity; //влажность
        double percipitationAmmount; //кол-во осадков
        string percipitations; //осадки
        public List<WeatherConditions> classExemps = new List<WeatherConditions>(); //создаем список экземпляров класса для сериализации
        static string path = @"Weather.json";
        FileInfo fileInf = new FileInfo(path); //путь к файлу
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<WeatherConditions>)); //переменная сериализации

        //узнаем осадки
        private void getPercipitations()
        {
            string result = "";
            foreach (Control control in PercipitationGroupBox.Controls)
            {
                if (control as CheckBox != null)
                {
                    if ((control as CheckBox).Checked)
                    {
                        result += control.Text;
                    }
                }
            }
            percipitations = result;
        }

        //обработчик загрузки формы
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //получаем дату
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            choosedDate = dateTimePicker1.Value;
        }

        //при нажатии на кнопку сохранения записываем все в json файл и возвращаем поля в исходное состояние
        private void SaveButton_Click(object sender, EventArgs e)
        {
            getPercipitations();
            dayLength = DayLengthMTBox.Text.ToString();
            time = TimeMTBox.Text.ToString();

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<WeatherConditions>));

            if (fileInf.Exists == false || fileInf.Length == 0)
            {
                WeatherConditions n = new WeatherConditions(choosedDate, dayLength, time, season, watchPlace, temperature, atmPressure, wind, windSpeed, cloudness, humidity, percipitationAmmount, percipitations);
                classExemps.Add(n);


                using (FileStream fsw = new FileStream("Weather.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fsw, classExemps);
                }
            }



            else if (fileInf.Length != 0)
            {
                using (FileStream fsr = new FileStream("Weather.json", FileMode.OpenOrCreate))
                {
                    classExemps = (List<WeatherConditions>)jsonFormatter.ReadObject(fsr);
                }

                WeatherConditions n = new WeatherConditions(choosedDate, dayLength, time, season, watchPlace, temperature, atmPressure, wind, windSpeed, cloudness, humidity, percipitationAmmount, percipitations);
                classExemps.Add(n);


                using (FileStream fsw = new FileStream("Weather.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fsw, classExemps);
                }
            }

            //возвращение всех полей в исходное состояние
            TimeMTBox.Text = "0000";
            SeasonBox.SelectedItem = "";
            DayLengthMTBox.Text = "0000";
            WatchPlacetextBox.Text = "";
            TemperatureUpDown.Value = Convert.ToDecimal(0.0);
            PressureUpDown.Value = Convert.ToDecimal(0.0);
            WindDirectionBox.SelectedItem = "";
            WindUpDown.Value = Convert.ToDecimal(0.0);
            CloudBox.SelectedItem = "";
            HumidityUpDown.Value = Convert.ToDecimal(0.0);
            PercipitationUpDown.Value = Convert.ToDecimal(0.0);

            NothingCB.Checked = false;
            RainCB.Checked = false;
            SnowCB.Checked = false;
            ThunderstormCB.Checked = false;
            FogCB.Checked = false;
            HailCB.Checked = false;

        }

        //работа с чекбоксами осадков
        private void NothingCB_CheckedChanged_1(object sender, EventArgs e)
        {

            //Если выбран пункт "Без осадков", остальные чекбоксы становятся неактивными и с них снимается выделение 
            if (NothingCB.Checked)
            {
                PercipitationUpDown.Enabled = false;
                PercipitationUpDown.Value = Convert.ToDecimal(0.0);

                RainCB.Enabled = false;
                RainCB.Checked = false;

                SnowCB.Enabled = false;
                SnowCB.Checked = false;

                ThunderstormCB.Enabled = false;
                ThunderstormCB.Checked = false;

                FogCB.Enabled = false;
                FogCB.Checked = false;

                HailCB.Enabled = false;
                HailCB.Checked = false;
            }
            else
            {
                PercipitationUpDown.Enabled = true;
                RainCB.Enabled = true;
                SnowCB.Enabled = true;
                ThunderstormCB.Enabled = true;
                FogCB.Enabled = true;
                HailCB.Enabled = true;
            }
        }

        //при клике на кнопку "генерация" открывается новая форма 
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            fileInf = new FileInfo(path);
            //если файл не пустой и существует, открывается окно генерации дневника
            if (fileInf.Exists == true && fileInf.Length > 0)
            {
                GenerateDiary f = new GenerateDiary();
                f.ShowDialog();
            }
            //если файл не существует, ошибка
            else if (fileInf.Exists == false)
            {
                MessageBox.Show(
                                       "Файл с информацией о погоде не найден.",
                                       "ERROR!",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error,
                                       MessageBoxDefaultButton.Button1,
                                       MessageBoxOptions.DefaultDesktopOnly);
            }

            //если файл пустой, ошибка
            else if (fileInf.Length == 0)
            {
                MessageBox.Show(
                                        "Файл не содержит данных.",
                                        "ERROR!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
            }

            else
            {
                MessageBox.Show(
                                       "Неопознанная ошибка. Пожалуйста, обратитесь за помощью к разработчику ПО",
                                       "ERROR!",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Error,
                                       MessageBoxDefaultButton.Button1,
                                       MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        //валидация места наблюдения
        private void WatchPlacetextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WatchPlacetextBox.Text))
            {
                WatchPlaceError.SetError(WatchPlacetextBox, "Не указано место наблюдения");
            }
            else
            {
                WatchPlaceError.Clear();
            }
        }

        //валидация даты
        private void Date_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > today) //дата не может быть больше сегодняшней
            {
                DateError.SetError(dateTimePicker1, "Введенная дата не может быть больше текущей");
            }
            else
            {
                DateError.Clear();
            }
        }

        //записываем время года
        private void SeasonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            season = SeasonBox.SelectedItem.ToString();
        }

        //записываем место наблюдения
        private void WatchPlacetextBox_TextChanged(object sender, EventArgs e)
        {
            watchPlace = WatchPlacetextBox.Text;
        }

        //записываем температуру
        private void TemperatureUpDown_ValueChanged(object sender, EventArgs e)
        {
            temperature = Convert.ToDouble(TemperatureUpDown.Value);
        }

        //записываем давление
        private void PressureUpDown_ValueChanged(object sender, EventArgs e)
        {
            atmPressure = Convert.ToDouble(PressureUpDown.Value);
        }

        //запись ветра 
        private void WindDirectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(WindDirectionBox.SelectedItem) == "Штиль")
            {
                WindUpDown.Enabled = false;
                WindUpDown.Value = Convert.ToDecimal(0.0);
            }
            if (Convert.ToString(WindDirectionBox.SelectedItem) != "Штиль")
            {
                WindUpDown.Enabled = true;
                
            }

            wind = WindDirectionBox.SelectedItem.ToString();
        }

        //запись скорости ветра 
        private void WindUpDown_ValueChanged(object sender, EventArgs e)
        {
            windSpeed = Convert.ToDouble(WindUpDown.Value);
        }

        //запись облачности
        private void CloudBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cloudness = CloudBox.SelectedItem.ToString();
        }

        //запись влажности
        private void HumidityUpDown_ValueChanged(object sender, EventArgs e)
        {
            humidity = Convert.ToDouble(HumidityUpDown.Value);
        }

        //запись кол-ва осадков
        private void PercipitationUpDown_ValueChanged(object sender, EventArgs e)
        {
            percipitationAmmount = Convert.ToDouble(PercipitationUpDown.Value);
        }

    }
}
