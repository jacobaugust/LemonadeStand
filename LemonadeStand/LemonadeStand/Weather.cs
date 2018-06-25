using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string finalWeather;
        public string temperature;
        public string condition;

        public string description;

        public Weather()
        {
            
        }

        public void TemperatureGeneration()
        {
            Random rnd = new Random();
            int numberSelectionOne = rnd.Next(55, 99);
            temperature = numberSelectionOne.ToString();
        }


        public void WeatherConditionRoll()
        {
            Random rnd = new Random();
            int numberSelectionTwo = rnd.Next(1, 7);


                switch (numberSelectionTwo)
                {
                    case 1:
                        condition = "overcast";
                        break;
                    case 2:
                        condition = "cloudy";
                        break;
                    case 3:
                        condition = "rain";
                        break;
                    case 4:
                        condition = "hot";
                        break;
                    case 5:
                        condition = "hazy";
                        break;
                    case 6:
                       condition = "muggy";
                        break;
                default:
                        break;

                }

        }

        public void FinalWeather()
        {
            finalWeather = "" + temperature + " degrees\n\n" + condition + "";
        }


    }
}

