using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpleprograms
{
    internal class ElectricReading
    {
        private int consumer_number,previous_reading,current_reading;
        private string? consumer_name,consumer_type;

        public ElectricReading(string? consumer_name, int consumer_number, string? consumer_type, int previous_reading, int current_reading)
        {
            this.Consumer_number = consumer_number;
            this.Previous_reading = previous_reading;
            this.Current_reading = current_reading;
            this.Consumer_name = consumer_name;
            this.Consumer_type = consumer_type;
        }

        public int Consumer_number { get => consumer_number; set => consumer_number = value; }
        public int Previous_reading { get => previous_reading; set => previous_reading = value; }
        public int Current_reading { get => current_reading; set => current_reading = value; }
        public string? Consumer_name { get => consumer_name; set => consumer_name = value; }
        public string? Consumer_type { get => consumer_type; set => consumer_type = value; }

        public int CalculateBill()
        {
            int bill_amount =0;
            int consumption = Current_reading - Previous_reading;
            if (Consumer_type.Equals("Domestic"))
            {
                if (consumption <= 100)
                {
                    bill_amount = 0;
                }
                else if(consumption> 100 && consumption <= 200)
                {
                    bill_amount= (consumption - 100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    bill_amount = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    bill_amount = (consumption - 100) * 10;
                }
            }
            else if (Consumer_type.Equals("Commercial"))
            {

                if (consumption <= 100)
                {
                    bill_amount = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    bill_amount = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    bill_amount = (consumption - 100) * 50;
                }
                else if (consumption > 500)
                {
                    bill_amount = (consumption - 100) * 100;
                }
            }
            return bill_amount;
        }
        
    }
}
