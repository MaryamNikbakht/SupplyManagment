using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FinalProject1.Validation
{
    class Validators
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool IsValidSize(string value, int size)
        {
            if (value.Length == size)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Validation for number of values
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumber(string value)
        {
            double n;
            if (double.TryParse(value, out n))
                return true;
            else
                return false;

        }
        /// <summary>
        /// Method for checking number and the lenght of number
        /// </summary>
        /// <param name="value"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static bool IsDigit(string value, int len)
        {
            Regex rx = new Regex(@"^{\d}{" + len + "}$");
            return rx.IsMatch(value);
        }
        /// <summary>
        /// Checking for string values and specifiec string values
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsString(string value)
        {
            Regex rx = new Regex(@"^[A-Za-z]+(\s[A-Za-z]+){0,1}$");
            return rx.IsMatch(value);

        }
    }
}
