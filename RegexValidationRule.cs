using System;
using System.Globalization;
using System.Text.RegularExpressions;   //  A Regex névtere
using System.Windows.Controls;

namespace ValidationRegEx
{
    public class RegexValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value,
        CultureInfo cultureInfo)
        {
            ValidationResult result = ValidationResult.ValidResult;
            if (!String.IsNullOrEmpty(this.RegexText))
            {
                
                string text = value as string ?? String.Empty;

                
                if (!Regex.IsMatch(text, this.RegexText, this.RegexOptions))
                    result = new ValidationResult(false, this.ErrorMessage);
            }
            return result;
        }
    }
    public static class RegexValidator
    {
        // There's more to come...
    }
}
