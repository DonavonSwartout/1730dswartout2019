using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dswartout1730ex2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan timeElapsed = dateA - dateB;
                result = timeElapsed.Days.ToString() +" days";
            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                bool pastDue = false;
                if (dateA > dateB)
                    pastDue = true;

                if (pastDue == true)
                    result = (dateA - dateB).Days.ToString() + " days past due";

                if (pastDue == false)
                    result = "On time";
            }
            catch { }

            return result;
        }
        public static string StringCalc01(string str)
        {
            string result = "Invalid input";
            str.Trim();

            if (str == "")
                result = "Invalid input";
            else
            str = str.Remove(0, 2);
            str = str.Insert(0, "cr");
            result = str;
                

            return result;
        }
        public static string StringCalc02(string str)
        {
            string result = "Invalid input";
            str.Trim();

            try
            {
                str = str.Remove(1, 1);
                str = str.Insert(1, "rit");
                result = str;
            }
            catch { }
            if (str.Length < 1)
                result = "Invalid input";

            return result;
        }
        public static string StringCalc03(string str)
        {
            string result = "Invalid input";
            str.Trim();

            string letters = str.Substring(2, 4).ToUpper();
            result = letters;

            return result;
        }
        public static string StringCalc04(string str)
        {
            string result = "Invalid input";
            str.Trim();

            str = str.PadLeft(10);
            str = str.Replace(" ", "*");
            result = str;

            return result;
        }
        public static string StringCalc05(string str)
        {
            string result = "Invalid input";
            str.Trim();

            str = str.Replace("(", "");
            str = str.Replace(")", "");
            str = str.Replace(" ", "");
            str = str.Replace("-", "");
            result = str;

            return result;
        }
        public static string StringCalc06(string str)
        {
            string result = "Invalid input";
            str.Trim();

            str = str.Replace("(", "");
            str = str.Replace(")", "");
            str = str.Replace(" ", "");
            str = str.Replace("-", "");

            if (str.Length == 10)
            {
                str = str.Insert(3, ".");
                str = str.Insert(7, ".");
            }
            else if (str.Length == 7)
                str = str.Insert(3, ".");
            else
                str = "Invalid input";

            result = str;

            return result;
        }
        public static string StringCalc07(string str)
        {
            string result = "Invalid input";
            str.Trim();

            str = str.ToLower();
            bool found = str.Contains("pioneer");
            if (found == true)
                result = "Found";
            else
                result = "Not found";

            return result;
        }
        public static string StringCalc08(string str)
        {
            string result = "Invalid input";
            int index1 = str.IndexOf(",");
            str.Trim();

            if (str.Length == 0)
                str = "Invalid input";
            else
            str = str.Substring(index1 + 2);
            result = str;

            return result;
        }
        public static string StringCalc09(string str)
        {
            string result = "Invalid input";
            int index1 = str.LastIndexOf(" ");
            bool found = str.Contains(" ");
            str.Trim();

            if (found == false)
                str = "Invalid input";
            else
                str = str.Substring(index1 + 1);
            result = str;

            return result;
        }
        public static string StringCalc10(string str1, string str2, string str3)
        {
            string result = "Invalid input";
            str1.Trim();
            str2.Trim();
            str3.Trim();

            StringBuilder SB1 = new StringBuilder(20);
            SB1.Append(str1);
            SB1.Append(", ");
            SB1.Append(str2);
            SB1.Append(", ");
            SB1.Append(str3);
            result = SB1.ToString();

            return result;
        }
    }
}