using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Linq;



namespace WeatherDiary
{
    public partial class Result : Form
    {
        public Result(GenerateDiary form)
        {
            InitializeComponent();
            GetData(form);
        }
        public List<WeatherConditions> classExemps = new List<WeatherConditions>();
        static string path = @"Weather.json";
        FileInfo fileInf = new FileInfo(path); //путь к файлу
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<WeatherConditions>)); //переменная сериализации
        //массив заголовков для таблицы
        string[] headers = new string[] { "Дата", "Длина дня", "Время", "Время года", "Место наблюдения", "Температура", "Давление", "Ветер", "Скорость ветра", "Облачность", "Влажность", "Кол-во осадков", "Осадки" };
        IEnumerable<WeatherConditions> iewc;
        string percipCheck = "";

        private void GetData(GenerateDiary form)
        {

            using (FileStream fsr = new FileStream("Weather.json", FileMode.OpenOrCreate))
            {
                classExemps = (List<WeatherConditions>)jsonFormatter.ReadObject(fsr);
            }

            dataGridView1.Columns.Clear();

            
            iewc = from c in classExemps where c.choosedDate == form.StartDatePicker.Value select c;
            //генерация по дате
            if (form.DateRadioBTN.Checked)
            {
                iewc = from c in classExemps where c.choosedDate == form.StartDatePicker.Value select c;
            }
            //по месту наблюдения
            else if (form.PlaceRadioBTN.Checked)
            {
                iewc = from c in classExemps where c.watchPlace == form.WatchPlacetextBox.Text select c;
            }
            //по времени года
            else if (form.SeasonRadioBTN.Checked)
            {
                iewc = from c in classExemps where c.season == form.SeasonBox.SelectedItem.ToString() select c;
            }
            //по времени наблюдения
            else if (form.TimeRadioBTN.Checked)
            {
                iewc = from c in classExemps where c.time == form.TimeMTBox.Text select c;
            }
            //по погодным условиям
            else if (form.WeatherRadioBTN.Checked)
            {
                WeatherConditionsMode(form);
            }
            //по промежутку времени
            else if (form.DateGapRadioBTN.Checked)
            {
                iewc = from c in classExemps where c.choosedDate >= form.StartDatePicker.Value && c.choosedDate <= form.EndDatePicker.Value select c;
            }

            FillDataGrid(iewc.ToList<WeatherConditions>());
        }

        //заполнение датагрида данными
        void FillDataGrid(List<WeatherConditions> iewc)
        {
            dataGridView1.DataSource = iewc;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = headers[i];
            }
        }

        //функция выборки по погоде
        void WeatherConditionsMode(GenerateDiary form)
        {
            //по температуре
            if (form.TemperatureUpDown.Value !=0)
            {
                iewc = from c in classExemps where Convert.ToDecimal(c.temperature) == form.TemperatureUpDown.Value select c;
            }
            //по навправлению ветра
            if (Convert.ToString(form.WindDirectionBox.SelectedItem) != "")
            {
                iewc = from c in classExemps where c.wind == form.WindDirectionBox.SelectedItem.ToString() select c;
            }
            //по облачности
            if (Convert.ToString(form.CloudBox.SelectedItem) != "")
            {
                iewc = from c in classExemps where c.cloudness == form.CloudBox.SelectedItem.ToString() select c;
            }
            //по давлению
            if (form.PressureUpDown.Value != 0)
            {
                iewc = from c in classExemps where Convert.ToDecimal(c.atmPressure) == form.PressureUpDown.Value select c;
            }
            //по силе ветра
            if (form.WindUpDown.Value != 0)
            {
                iewc = from c in classExemps where Convert.ToDecimal(c.windSpeed) == form.WindUpDown.Value select c;
            }
            //по влажности
            if (form.HumidityUpDown.Value != 0)
            {
                iewc = from c in classExemps where Convert.ToDecimal(c.humidity) == form.HumidityUpDown.Value select c;
            }
            //по кол-ву осадков
            if (form.PercipitationUpDown.Value != 0)
            {
                iewc = from c in classExemps where Convert.ToDecimal(c.percipitationAmmount) == form.PercipitationUpDown.Value select c;
            }

            //----------------------------------------------------------------------------------------------------------------------------
            //без осадков
            if (form.NothingCB.Checked)
            {
                percipCheck += form.NothingCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }
            //град
            if (form.HailCB.Checked)
            {
                percipCheck += form.HailCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }
            //туман
            if (form.FogCB.Checked)
            {
                percipCheck += form.FogCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }
            //гроза
            if (form.ThunderstormCB.Checked)
            {
                percipCheck += form.ThunderstormCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }
            //снег
            if (form.SnowCB.Checked)
            {
                percipCheck += form.SnowCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }
            //дождь
            if (form.RainCB.Checked)
            {
                percipCheck += form.RainCB.Text;
                iewc = from c in classExemps where c.percipitations == percipCheck select c;
            }


        }

        
    }
}
