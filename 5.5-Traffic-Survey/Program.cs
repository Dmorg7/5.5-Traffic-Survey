using System;

namespace _5._5_Traffic_Survey
{
    // author: Benjamin Daniel Morgan
    // date: 30/01/18

    class Traffic
    {
        int[] trafficCount = new int[MAX];                                                     // define int array called trafficCount
        const int MAX = 24;
        string input;

        static void Main(string[] args)
        {
            Traffic ReportTraffic = new Traffic();
            ReportTraffic.report();

        }
        public void report()
        {
            Traffic myTraffic = new Traffic();
            myTraffic.enterCounts();
            myTraffic.showTotal();
            myTraffic.busiest();
            myTraffic.showData();
        }
        public int[] enterCounts()
        {
            Console.WriteLine("Enter the 24 counts");

            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                trafficCount[i] = Convert.ToInt32(Console.ReadLine());
            }

            return trafficCount;
        }
        public void showTotal()
        {
            int sum = trafficCount.Sum();
            Console.WriteLine("The total number of cars are: " + sum);

        }
        public void busiest()
        {
            int max = trafficCount.Max();
            int maxIndex = trafficCount.ToList().IndexOf(max);
            Console.WriteLine("The busiest time of the day had " + max + " cars" + "The buiest time of the day was hour " + (maxIndex + 1) + ":00");
        }
        public void showData()
        {
            int maxIndex = trafficCount.ToList().IndexOf(max);

            Console.WriteLine("Traffic Report");
            Console.WriteLine("==============");
            Console.WriteLine("Hour: " + "Car Count: " + "Percentage of Total: ");
            Console.WriteLine("===================================================");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("Number. " + (i + 1) + " is " + trafficCount[i] + "%");
            }
            Console.WriteLine("Total Car Count for the day is: ");
            Console.WriteLine("Busiest Hour: " + (maxIndex + 1));
            Console.WriteLine("===================================================");
        }

    } // end of Traffic class
}
