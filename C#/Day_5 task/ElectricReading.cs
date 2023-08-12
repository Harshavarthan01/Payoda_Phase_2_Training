using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class ElectricReading
    {
       private int consumerNumber, prevReading, curReading;
       private string? consumerName, consumerType;

       
        public ElectricReading(int consumerNumber, string? consumerName,  int curReading, int prevReading, string? consumerType)
        {
            ConsumerNumber = consumerNumber;
            PrevReading = prevReading;
            CurReading = curReading;
            ConsumerName = consumerName;
            ConsumerType = consumerType;
        }

        public int ConsumerNumber { get => ConsumerNumber1; set => ConsumerNumber1 = value; }
        public string? ConsumerName { get => ConsumerName1; set => ConsumerName1 = value; }
        public int ConsumerNumber1 { get => consumerNumber; set => consumerNumber = value; }
        public int PrevReading { get => prevReading; set => prevReading = value; }
        public int CurReading { get => curReading; set => curReading = value; }
        public string? ConsumerName1 { get => consumerName; set => consumerName = value; }
        public string? ConsumerType { get => consumerType; set => consumerType = value; }

        public int calculateBill() {
            int billAmount = 0;
            if (ConsumerType.Equals("Domestic"))
            {
                int consumption = CurReading - PrevReading;
                if (consumption <= 100)
                {
                    billAmount = 0;
                }
                else if (consumption > 100 && consumption <= 200) { 
                    billAmount = (consumption-100)*2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billAmount = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billAmount = (consumption - 100) * 10;
                }
            }
            else if(ConsumerType.Equals("Commercial")){
                int consumption = CurReading - PrevReading;
                if (consumption <= 100)
                {
                    billAmount = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billAmount = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billAmount = (consumption - 100) * 50;
                }
                else if (consumption > 500)
                {
                    billAmount = (consumption - 100) * 100;
                }
            }
            return billAmount;
        }

       
    }
}
