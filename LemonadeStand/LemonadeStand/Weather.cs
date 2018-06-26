using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string forecastWeather;
        public int forecastTemperature;
        public string forecastCondition;
        public int actualTemperature;
        public string actualCondition;
        public int motherNature;

        public Weather()
        {
            TemperatureGeneration();
            ForecastWeatherConditionRoll();
            ForecastWeather();
            ActualWeatherConditionRoll();
            ActualWeather();
        }

        public void TemperatureGeneration()
        {
            Random rnd = new Random();
            forecastTemperature = rnd.Next(55, 99);
        }


        public void ForecastWeatherConditionRoll()
        {
            int numberSelectionTwo;
            if (forecastTemperature <= 80)
            {
                Random rnd = new Random();
                numberSelectionTwo = rnd.Next(3);
            }
            else 
            {
                Random rnd = new Random();
                numberSelectionTwo = rnd.Next(1, 7);
            }
           

                switch (numberSelectionTwo)
                {
                    case 1:
                        forecastCondition = "overcast";
                        break;
                    case 2:
                        forecastCondition = "cloudy";
                        break;
                    case 3:
                        forecastCondition = "rain";
                        break;
                    case 4:
                        forecastCondition = "hot";
                        break;
                    case 5:
                        forecastCondition = "hazy";
                        break;
                    case 6:
                       forecastCondition = "muggy";
                        break;
                    default:
                        break;

                }

        }

        public void ActualWeatherConditionRoll()
        {
            int numberSelectionThree;
            if (actualTemperature <= 80)
            {
                Random rnd = new Random();
                numberSelectionThree = rnd.Next(3);
            }
            else
            {
                Random rnd = new Random();
                numberSelectionThree = rnd.Next(1, 7);
            }


            switch (numberSelectionThree)
            {
                case 1:
                    actualCondition = "overcast";
                    break;
                case 2:
                    actualCondition = "cloudy";
                    break;
                case 3:
                    actualCondition = "rain";
                    break;
                case 4:
                    actualCondition = "hot";
                    break;
                case 5:
                    actualCondition = "hazy";
                    break;
                case 6:
                    actualCondition = "muggy";
                    break;
                default:
                    break;

            }

        }

        public void ForecastWeather()
        {
            forecastWeather = "" + forecastTemperature + " degrees\n\n" + forecastCondition + "";
        }

        public void ActualWeather()
        {
            Random rnd = new Random();
            motherNature = rnd.Next(-11, 11);
            actualTemperature = forecastTemperature + motherNature;

        }
    }
}

