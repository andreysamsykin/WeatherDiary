using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;

namespace WeatherDiary
{
    public partial class GenerateDiary : Form
    {
        public GenerateDiary()
        {
            InitializeComponent();

            //значение по умолчанию для EndDatePicker - сегодняшнее
            EndDatePicker.Value = DateTime.Today;

            //значение по умолчанию для StartDatePicker - вчерашнее
            StartDatePicker.Value = DateTime.Today.AddDays(-1);

            //инициализация комбобоксов
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

            //запрет на ввод собственных символов в комбобоксы ветра, облачности, времени года
            WindDirectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CloudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SeasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            chooseMode();
        }

        //если не выбрано ничего, высота 112
        private void chooseMode()
        {
            if (DateRadioBTN.Checked == false || DateGapRadioBTN.Checked == false || SeasonRadioBTN.Checked == false ||
                WeatherRadioBTN.Checked == false || TimeRadioBTN.Checked == false || PlaceRadioBTN.Checked == false)
            {
                this.Height = 112;
            }
        }

        private void GenerateDiary_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Result f = new Result(this);
            f.Show();



        }
        


        //кнопка закрывает форму
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //искать по конкретной дате
        private void DateRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (DateRadioBTN.Checked)
            {
                StartDatePicker.Visible = true;
                StartDateLabel.Visible = false;
                EndDateLabel.Visible = false;
                EndDatePicker.Visible = false;
                SeasonBox.Visible = false;
                groupBox_WeatherCond.Visible = false;
                TimeMTBox.Visible = false;
                TimeLabel.Visible = false;
                SeasonBox.Visible = false;
                SeasonLabel.Visible = false;
                DayLengthMTBox.Visible = false;
                DayLongLabel.Visible = false;
                WatchPlace.Visible = false;
                WatchPlacetextBox.Visible = false;
                this.Height = 330;
            }

        }

        //искать по промежутку времени
        private void DateGapRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (DateGapRadioBTN.Checked)
            {
                StartDatePicker.Visible = true;
                StartDateLabel.Visible = true;
                EndDateLabel.Visible = true;
                EndDatePicker.Visible = true;
                SeasonBox.Visible = false;
                groupBox_WeatherCond.Visible = false;
                TimeMTBox.Visible = false;
                TimeLabel.Visible = false;
                SeasonBox.Visible = false;
                SeasonLabel.Visible = false;
                DayLengthMTBox.Visible = false;
                DayLongLabel.Visible = false;
                WatchPlace.Visible = false;
                WatchPlacetextBox.Visible = false;
                this.Height = 330;
            }

        }

        //искать по погодным условиям
        private void WeatherRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (WeatherRadioBTN.Checked)
            {
               
                StartDatePicker.Visible = false;
                StartDateLabel.Visible = false;
                EndDateLabel.Visible = false;
                EndDatePicker.Visible = false;
                SeasonBox.Visible = false;
                groupBox_WeatherCond.Visible = true;
                TimeMTBox.Visible = false;
                TimeLabel.Visible = false;
                SeasonBox.Visible = false;
                SeasonLabel.Visible = false;
                DayLengthMTBox.Visible = false;
                DayLongLabel.Visible = false;
                WatchPlace.Visible = false;
                WatchPlacetextBox.Visible = false;
                this.Height = 763;
            }
        }

        //искать только по времени
        private void TimeRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            StartDatePicker.Visible = false;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            EndDatePicker.Visible = false;
            SeasonBox.Visible = false;
            groupBox_WeatherCond.Visible = false;
            TimeMTBox.Visible = true;
            TimeLabel.Visible = true;
            SeasonBox.Visible = false;
            SeasonLabel.Visible = false;
            DayLengthMTBox.Visible = false;
            DayLongLabel.Visible = false;
            WatchPlace.Visible = false;
            WatchPlacetextBox.Visible = false;
            this.Height = 330;
        }

        //искать только по месту наблюдения
        private void PlaceRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            StartDatePicker.Visible = false;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            EndDatePicker.Visible = false;
            SeasonBox.Visible = false;
            groupBox_WeatherCond.Visible = false;
            TimeMTBox.Visible = false;
            TimeLabel.Visible = false;
            SeasonBox.Visible = false;
            SeasonLabel.Visible = false;
            DayLengthMTBox.Visible = false;
            DayLongLabel.Visible = false;
            WatchPlace.Visible = true;
            WatchPlacetextBox.Visible = true;
            this.Height = 330;
        }

        //искать только по времени года
        private void SeasonRadioBTN_CheckedChanged(object sender, EventArgs e)
        {
            StartDatePicker.Visible = false;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            EndDatePicker.Visible = false;
            groupBox_WeatherCond.Visible = false;
            TimeMTBox.Visible = false;
            TimeLabel.Visible = false;
            SeasonBox.Visible = true;
            SeasonLabel.Visible = true;
            DayLengthMTBox.Visible = false;
            DayLongLabel.Visible = false;
            WatchPlace.Visible = false;
            WatchPlacetextBox.Visible = false;
            this.Height = 330;
        }

        private void NothingCB_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
