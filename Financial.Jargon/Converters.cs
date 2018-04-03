using System;
using System.Collections;
using System.Globalization;

namespace Financial.Jargon
{
    public class Converters
    {
        /// <summary>
        /// Checks a month abbreviation for length and case.
        /// </summary>
        /// <param name="ma">Month abbreviation.</param>
        /// <returns>Month abbreviation.</returns>
        /// <exception cref="ArgumentException"></exception>
        private string CheckMonthAbbreviation(string ma)
        {
            if (ma.Length == 3 && !string.IsNullOrEmpty(ma))
                return char.ToUpper(ma[0]) + ma.Substring(1);

            throw new ArgumentException(
                $"The abbreviation {ma} that was provided is {ma.Length} long and it needs to be 3 letters long");
        }

        /// <summary>
        /// Formats a month number as a two character string.
        /// </summary>
        /// <param name="s">Month number.</param>
        /// <returns>Month number.</returns>
        /// <exception cref="ArgumentException"></exception>
        private string PadMonthString(string s)
        {
            int sLen = s.Length;
            if (sLen > 2 || string.IsNullOrEmpty(s))
                throw new ArgumentException(
                    $"The month number {s} string is {s.Length} and it can must be 1 or 2 letters long");
            if (sLen == 1)
            {
                s = $"0{s.ToUpper()}";
            }
            return s.ToUpper();
        }

        #region Exchange Codes
        /// <summary>
        /// Returns a standardized exchange name from a specific exchange code.
        /// </summary>
        /// <param name="exchangeCode">Shortened name for an exchange</param>
        /// <returns></returns>
        public string ExchangeNameFromCode(string exchangeCode)
        {
            Hashtable ht = new Hashtable
            {
                {"CBOT", "CME"},
                {"CBT", "CME"},
                {"NYMEX", "CME"},
                {"NYM", "CME"},
                {"COMEX","CME"},
                {"CMX","CME"},
                {"CME", "CME"},
                {"IPE", "ICE"},
                {"ICE", "ICE"},
                {"NYBOT", "ICE"},
                {"WCE", "ICE"},
            };
            return (string)ht[exchangeCode.ToUpper()];
        }

        #endregion

        #region Month Characters

        /// <summary>
        /// Gets the three letter month abbreviation from a financial month character.
        /// </summary>
        /// <param name="monthchar">Financial month character.</param>
        /// <returns>Month abbreviation.</returns>
        public string ShortMonthFromMonthchar(char monthchar)
        {
            monthchar = char.ToUpper(monthchar);
            Hashtable ht = new Hashtable
            {
                {'F', "Jan"},
                {'G', "Feb"},
                {'H', "Mar"},
                {'J', "Apr"},
                {'K', "Mar"},
                {'M', "Jun"},
                {'N', "Jul"},
                {'Q', "Aug"},
                {'U', "Sep"},
                {'V', "Oct"},
                {'X', "Nov"},
                {'Z', "Dec"}
            };
            return ht[char.ToUpper(monthchar)].ToString();
        }

        /// <summary>
        /// Gets the month name from a financial month character.
        /// </summary>
        /// <param name="monthchar">Financial month character.</param>
        /// <returns>Month name.</returns>
        public string MonthFromMonthchar(char monthchar)
        {
            monthchar = char.ToUpper(monthchar);
            Hashtable ht = new Hashtable
            {
                {'F', "January"},
                {'G', "February"},
                {'H', "March"},
                {'J', "April"},
                {'K', "May"},
                {'M', "June"},
                {'N', "July"},
                {'Q', "August"},
                {'U', "September"},
                {'V', "October"},
                {'X', "November"},
                {'Z', "December"}
            };
            return ht[char.ToUpper(monthchar)].ToString();
        }

        /// <summary>
        /// Gets the two digit month number from a financial month character.
        /// </summary>
        /// <param name="monthchar">Financial month character.</param>
        /// <returns>Month number.</returns>
        public string MonthNumberFromMonthchar(char monthchar)
        {
            monthchar = char.ToUpper(monthchar);
            Hashtable ht = new Hashtable
            {
                {'F', "01"},
                {'G', "02"},
                {'H', "03"},
                {'J', "04"},
                {'K', "05"},
                {'M', "06"},
                {'N', "07"},
                {'Q', "08"},
                {'U', "09"},
                {'V', "10"},
                {'X', "11"},
                {'Z', "12"}
            };
            return ht[char.ToUpper(monthchar)].ToString();
        }

        #endregion

        #region Month Abbreviations

        /// <summary>
        /// Gets the two digit month number from a three letter month abbreviation.
        /// </summary>
        /// <param name="abbreviatedMonth">Month abbreviation.</param>
        /// <returns>Month number.</returns>
        public string MonthNumberFromShortMonth(string abbreviatedMonth)
        {
            Hashtable ht = new Hashtable
            {
                {"Jan", "01"},
                {"Feb", "02"},
                {"Mar", "03"},
                {"Apr", "04"},
                {"May", "05"},
                {"Jun", "06"},
                {"Jul", "07"},
                {"Aug", "08"},
                {"Sep", "09"},
                {"Oct", "10"},
                {"Nov", "11"},
                {"Dec", "12"}
            };
            return ht[CheckMonthAbbreviation(abbreviatedMonth)].ToString();
        }

        /// <summary>
        /// Gets the month name from a three letter month abbreviation.
        /// </summary>
        /// <param name="abbreviatedMonth">Month abbreviation.</param>
        /// <returns>Month name.</returns>
        public string MonthFromShortMonth(string abbreviatedMonth)
        {
            Hashtable ht = new Hashtable
            {
                {"Jan", "January"},
                {"Feb", "February"},
                {"Mar", "March"},
                {"Apr", "April"},
                {"May", "May"},
                {"Jun", "June"},
                {"Jul", "July"},
                {"Aug", "August"},
                {"Sep", "September"},
                {"Oct", "October"},
                {"Nov", "November"},
                {"Dec", "December"}
            };
            return ht[CheckMonthAbbreviation(abbreviatedMonth)].ToString();
        }

        /// <summary>
        /// Gets the financial month character from a three letter month abbreviation.
        /// </summary>
        /// <param name="abbreviatedMonth">Month abbreviation</param>
        /// <returns>Financial month character.</returns>
        public char MonthCharFromShortMonth(string abbreviatedMonth)
        {
            Hashtable ht = new Hashtable
            {
                {"Jan", 'F'},
                {"Feb", 'G'},
                {"Mar", 'H'},
                {"Apr", 'J'},
                {"May", 'K'},
                {"Jun", 'M'},
                {"Jul", 'N'},
                {"Aug", 'Q'},
                {"Sep", 'U'},
                {"Oct", 'V'},
                {"Nov", 'X'},
                {"Dec", 'Z'}
            };
            return (char)ht[CheckMonthAbbreviation(abbreviatedMonth)];
        }

        #endregion

        #region Month Names

        /// <summary>
        /// Gets the financial month character from a month name.
        /// </summary>
        /// <param name="month">Month name.</param>
        /// <returns>Financial month character.</returns>
        public char MonthCharFromMonth(string month)
        {
            Hashtable ht = new Hashtable
            {
                {"January" ,'F'},
                {"February" ,'G'},
                {"March" ,'H'},
                {"April" ,'J'},
                {"May" ,'K'},
                {"June" ,'M'},
                {"July" ,'N'},
                {"August" ,'Q'},
                {"September" ,'U'},
                {"October" ,'V'},
                {"November" ,'X'},
                {"December" ,'Z'}
            };
            return (char)ht[char.ToUpper(month[0]) + month.Substring(1)];
        }

        /// <summary>
        /// Gets the three letter month abbreviation from a month name.
        /// </summary>
        /// <param name="month">Month name.</param>
        /// <returns>Month abbreviation.</returns>
        public string ShortMonthFromMonth(string month)
        {
            Hashtable ht = new Hashtable
            {
                {"January" , "Jan"},
                {"February" , "Feb"},
                {"March" , "Mar"},
                {"April" , "Apr"},
                {"May" , "Mar"},
                {"June" , "Jun"},
                {"July" , "Jul"},
                {"August" , "Aug"},
                {"September" , "Sep"},
                {"October" , "Oct"},
                {"November" , "Nov"},
                {"December" , "Dec"}
            };
            return (string)ht[char.ToUpper(month[0]) + month.Substring(1)];
        }

        /// <summary>
        /// Gets the two digit month from a month name.
        /// </summary>
        /// <param name="month">Month name</param>
        /// <returns>Month number.</returns>
        public string MonthNumberFromMonth(string month)
        {
            Hashtable ht = new Hashtable
            {
                {"January", "01"},
                {"February", "02"},
                {"March", "03"},
                {"April", "04"},
                {"May", "05"},
                {"June", "06"},
                {"July", "07"},
                {"August", "08"},
                {"September", "09"},
                {"October", "10"},
                {"November", "11"},
                {"December", "12"}
            };
            return (string)ht[char.ToUpper(month[0]) + month.Substring(1)];
        }

        #endregion

        #region Month Numbers

        /// <summary>
        /// Gets the month name from two digit month number.
        /// </summary>
        /// <param name="monthNumber">Month number.</param>
        /// <returns>Month name.</returns>
        public string MonthFromMonthNumber(string monthNumber)
        {
            Hashtable ht = new Hashtable
            {
                {"01", "January"},
                {"02", "February"},
                {"03", "March"},
                {"04", "April"},
                {"05", "May"},
                {"06", "June"},
                {"07", "July"},
                {"08", "August"},
                {"09", "September"},
                {"10", "October"},
                {"11", "November"},
                {"12", "December"}
            };
            return ht[PadMonthString(monthNumber)].ToString();
        }

        /// <summary>
        /// Gets the financial month character from a month number.
        /// </summary>
        /// <param name="monthNumber">Month number.</param>
        /// <returns>Financial month character.</returns>
        public char MonthCharFromMonthNumber(string monthNumber)
        {
            Hashtable ht = new Hashtable
            {
                {"01", 'F'},
                {"02", 'G'},
                {"03", 'H'},
                {"04", 'J'},
                {"05", 'K'},
                {"06", 'M'},
                {"07", 'N'},
                {"08", 'Q'},
                {"09", 'U'},
                {"10", 'V'},
                {"11", 'X'},
                {"12", 'Z'}
            };
            return (char)ht[PadMonthString(monthNumber)];
        }

        /// <summary>
        /// Gets the three letter month abbreviation from a month number.
        /// </summary>
        /// <param name="monthNumber">Month number.</param>
        /// <returns>Month abbreviation.</returns>
        public string ShortMonthFromMonthNumber(string monthNumber)
        {
            Hashtable ht = new Hashtable
            {
                {"01", "Jan"},
                {"02", "Feb"},
                {"03", "Mar"},
                {"04", "Apr"},
                {"05", "Mar"},
                {"06", "Jun"},
                {"07", "Jul"},
                {"08", "Aug"},
                {"09", "Sep"},
                {"10", "Oct"},
                {"11", "Nov"},
                {"12", "Dec"}
            };
            return ht[PadMonthString(monthNumber)].ToString();
        }

        #endregion

        #region Month Dates
        /// <summary>
        /// Gets the financial month character from a date.
        /// </summary>
        /// <param name="dt">Date.</param>
        /// <returns>Financial month character.</returns>
        public char MonthCharFromDate(DateTime dt)
        {
            Hashtable ht = new Hashtable
            {
                {1, 'F'},
                {2, 'G'},
                {3, 'H'},
                {4, 'J'},
                {5, 'K'},
                {6, 'M'},
                {7, 'N'},
                {8, 'Q'},
                {9, 'U'},
                {10, 'V'},
                {11, 'X'},
                {12, 'Z'}
            };
            return (char)ht[dt.Month];
        }

        /// <summary>
        /// Gets the two digit month number from a date.
        /// </summary>
        /// <param name="dt">Date.</param>
        /// <returns>Month number.</returns>
        public string MonthNumberFromDate(DateTime dt)
        {
            string dateAsString = dt.Month.ToString();

            if (dateAsString.Length == 1)
            {
                return $"0{dateAsString}";
            }

            return dateAsString;
        }

        /// <summary>
        /// Gets the three letter month abbreviation from a date.
        /// </summary>
        /// <param name="dt">Date.</param>
        /// <returns>Month abbreviation.</returns>
        public string ShortMonthFromDate(DateTime dt)
        {
            Hashtable ht = new Hashtable
            {
                {1, "Jan"},
                {2, "Feb"},
                {3, "Mar"},
                {4, "Apr"},
                {5, "Mar"},
                {6, "Jun"},
                {7, "Jul"},
                {8, "Aug"},
                {9, "Sep"},
                {10, "Oct"},
                {11, "Nov"},
                {12, "Dec"}
            };
            return ht[dt.Month].ToString();
        }

        /// <summary>
        /// Gets the month name from a date.
        /// </summary>
        /// <param name="dt">Date.</param>
        /// <returns>Month name.</returns>
        public string MonthFromDate(DateTime dt)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dt.Month);
        }

        #endregion
    }
}
