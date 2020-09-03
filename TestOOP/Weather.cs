using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP
{
    public class Weather
    {
        public string WeatherBoy(int num)
        {
            var temperature = 50;
            
            if (num >= temperature)
            {
                return "Too Hot";
            }
            else
            {
                return "Mans Not Hot";
            }
        }

        public string WeatherScale(int num)
        {
            var weatherScale = 0;

            if (num <= 20)
            {
                weatherScale = 1;
            }
            else if (num <= 40)
            {
                weatherScale = 2;
            }
            else if (num <= 60)
            {
                weatherScale = 3;
            }
            else if (num <= 80)
            {
                weatherScale = 4;
            }
            else
            {
                weatherScale = 5;
            }




            switch (weatherScale)
            {
                case 1:

                    return "Wear 7 layers its cold";

                   break;

                case 2:

                    return "Bring a drink its muggy";

                    break;

                case 3:

                    return "Getting pretty toasty";

                    break;

                case 4:

                    return "Okay sun we get it you exist";

                    break;

                case 5:

                    return "If you were a person youd be declared medically dead";

                    break;
            }
            return null;
        }
    }
}
