using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    // Extension method, added to a class afterwards, finds method that works with that class
    //Can't add to ceiled methods
    /// <summary>
    /// Repository for library functions
    /// </summary>
    public static class StringExtensions
    {

        /// <summary>
        /// Capitalize first letter of string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Capitalize(this String str)
        {
            //Grab first letter in index
            string first = str[0].ToString().ToUpper();

            //Gives a capitalized character
            return first[0] + str.Substring(1);
        }



        /// <summary>
        /// This in parameter means it's an extension method
        /// </summary>
        /// <param name="str">String is an alisis, upper case and lower case means the same thing</param>
        /// <returns></returns>
        public static string ToCamelCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            string[] parts = str.Split(" ");

            foreach(string part in parts)
            {
                sb.Append(part.ToLower().Capitalize());
            }
            return sb.ToString();

        }

        public static int WordCount(this string s)
        {
            return s.Split(new char[] 
                {' ', '.', '\n', '\t'},
                StringSplitOptions.RemoveEmptyEntries)
                .Length;
        }

        public static string Smurf(this string s, string toReplace)
        {
            return s.Replace(toReplace, "Smurf");
        }




    } // end of Extension methods class
} 
