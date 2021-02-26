using System;

namespace SharedLib
{
    public class FuelEfficiency
    {
        public float calc_mpg(float miles, float gallons)
        {
            return miles / gallons;
        }
        
        public bool gasUse(float miles, float gallons)
        {
            bool gasUse = false;
            if(miles <= 100 && gallons >= 10)
            {
                gasUse = true;
                return gasUse;
            }
            else
            {
                return gasUse;
            }

          
        }

        public float calc_gallons(float miles, float mpg)
        {
            return miles / mpg;
            
        }

        public float calc_miles(float gallons, float mpg)
        {
            return mpg * gallons;
        }

        public bool calc_pay(float price, float gallons, float cardAmount)
        {
            bool validation = false;
            float total = price * gallons;
            if (total <= cardAmount)
            {
                validation = true;
                return validation;
            }
            else
            {
                return validation;
            }
        }

        public float calc_fuelUse(float gallons, float tank)
        {
            return gallons / tank;
        }
    }
}
