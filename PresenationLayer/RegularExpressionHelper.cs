using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BIT
{
    public class RegularExpressionHelper
    {
        bool invalid = false;

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        public bool IsValidEmail(string input)
        {
            invalid = false;
            if (String.IsNullOrEmpty(input))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                input = Regex.Replace(input, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(input,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsAlpha(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z ]+$");
        }

        public static bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool IsPhoneFormat(string input)
        {
            //Allows following numbers
            //1300, 1800, 1900, 1902 +6 digits
            //02, 03, 07, 08 +8 digits
            //13 + 4 digits
            //04 + 8 or 9 digits.
            //14 + 9 digits (satellite phones)
            //Allows spaces at correct intervals
            //Allows no spaces


            invalid = false;
            if (String.IsNullOrEmpty(input))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                input = Regex.Replace(input, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid phone format. 
            try
            {
                return Regex.IsMatch(input,
                      @"(^1300(| )[0-9]{3}(| )[0-9]{3}$)|(^1800|1900|1902(| )[0-9]{3}(| )[0-9]{3}$)|(^0[2|3|7|8]{1}(| )[0-9]{4}(| )[0-9]{4}$)|(^13(| )[0-9]{4}$)|(^04[0-9]{2,3}(| )[0-9]{3}(| )[0-9]{3}$)",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool IsMobileFormat(string input)
        {
            //Australian Mobile phone numbers only
            
            invalid = false;
            if (String.IsNullOrEmpty(input))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                input = Regex.Replace(input, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid mobile format. 
            try
            {
                return Regex.IsMatch(input,
                      @"^(?:\+?61|0)4 ?(?:(?:[01] ?[0-9]|2 ?[0-57-9]|3 ?[1-9]|4 ?[7-9]|5 ?[018]) ?[0-9]|3 ?0 ?[0-5])(?: ?[0-9]){5}$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool IsAlphaNumericWithUnderscore(string input)
        {
            //Numbers Or Letters Or Underscores only

            invalid = false;
            if (String.IsNullOrEmpty(input))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                input = Regex.Replace(input, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid description format. 
            try
            {
                return Regex.IsMatch(input,
                      @"^[a-zA-Z0-9_?., =&%/*()+]+$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
