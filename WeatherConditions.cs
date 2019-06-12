using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace WeatherDiary
{
    [DataContract]
    public class WeatherConditions
    {
        [DataMember]
        public DateTime choosedDate { get; set; }
        [DataMember]
        public string dayLength { get; set; }
        [DataMember]
        public string time { get; set; }
        [DataMember]
        public string season { get; set; }
        [DataMember]
        public string watchPlace { get; set; }
        [DataMember]
        public double temperature { get; set; }
        [DataMember]
        public double atmPressure { get; set; }
        [DataMember]
        public string wind { get; set; }
        [DataMember]
        public double windSpeed { get; set; }
        [DataMember]
        public string cloudness { get; set; }
        [DataMember]
        public double humidity { get; set; }
        [DataMember]
        public double percipitationAmmount { get; set; }
        [DataMember]
        public string percipitations { get; set; }


        //конструктор 
       public WeatherConditions(DateTime aChoosedDate, string aDayLength, string aTime,
        string aSeason, string aWatchPlace, double aTemperature, double aAtmPressure, string aWind, 
                                    double aWindSpeed, string aCloudness,
                                     double aHumidity, double aPercipitationAmmount, string aPercipitations) {
            choosedDate = aChoosedDate;
            dayLength = aDayLength;
            time = aTime;
            season = aSeason;
            watchPlace = aWatchPlace;
            temperature = aTemperature;
            atmPressure = aAtmPressure;
            wind = aWind;
            windSpeed = aWindSpeed;
            cloudness = aCloudness;
            humidity = aHumidity;
            percipitationAmmount = aPercipitationAmmount;
            percipitations = aPercipitations;}

        public void WriteToFile() { }
    }
}
