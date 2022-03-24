using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationRegEx.utilities
{
    public enum For
    {
        Int,
        Double,
        Number,
        Phone,
        Email
    }

    public static class RegExPatterns
    {

        public static string Int => @"^[0-9]+$";
        public static string Double => @"^-?(?:0|[1-9][0-9]*)\.?[0-9]+$";
        public static string Number => @"^[0-9]+([\\.][0-9]+)?$";
        public static string Phone => @"((?:\+?3|0)6)(?:-|\()?(\d{1,2})(?:-|\))?(\d{3})-?(\d{3,4})";
        public static string Email => @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    }

    public static class Validations
    {
        public static bool IsValid(this string text, For validation)
        {
            return validation switch
            {
                For.Int => Int(text),
                For.Double => Double(text),
                For.Number => Number(text),
                For.Phone => Phone(text),
                For.Email => Email(text),
                _ => false,
            };
        }

        private static bool Number(string text)
        {
            return new Regex(RegExPatterns.Number).IsMatch(text);
        }

        private static bool Int(string text)
        {
            return new Regex(RegExPatterns.Int).IsMatch(text);
        }

        private static bool Double(string text)
        {
            return new Regex(RegExPatterns.Double).IsMatch(text);
        }

        private static bool Phone(string text)
        {
            return new Regex(RegExPatterns.Phone).IsMatch(text);
        }
        private static bool Email(string text)
        {
            return new Regex(RegExPatterns.Email).IsMatch(text);
        }
    }
}
