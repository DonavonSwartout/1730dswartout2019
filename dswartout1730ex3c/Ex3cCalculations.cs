using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dswartout1730ex3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int[] indexes = { 0, 1, 2, 3, 4, 5, 6 };
            string day = "";

            if (index < 1)
                return "Invalid index";
            else if (index > 7)
                return "Invalid index";
            else
                index -= 1;
            day = days[index];
            
            return day;
        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            string result = "Invalid input";

            search = search.Trim();
            search = search.ToUpper();
            int index = Array.IndexOf(days, search);
            if (index < 0)
                result = "Invalid input";
            else
                result = hours[index];

            return result;
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            if (count > numbers.GetLength(0))
                return sum;
            else
                for (int i = 0; i < count; i++)
                    sum += numbers[i];

            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            double avg = 0.0;
            int count = numbers.GetLength(0);
            avg = Ex3cCalculations.Calc3(numbers, count);
            if (avg < 0)
                avg = -1.0;
            else
                avg = (avg / count);

            return avg;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<Double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double number in numbers)
                {
                    if (number > avg)
                    {
                        aboveAvgList.Add(number);
                    }
                    else
                    {
                        aboveAvgList.Remove(number);
                    }
                }
            }
            else
            {
                double[] invalid = { 0.0 };
                return invalid;
            }


            return aboveAvgList.ToArray();
        }
    }
}
