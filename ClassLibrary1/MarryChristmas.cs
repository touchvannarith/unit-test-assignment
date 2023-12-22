using System;

namespace ClassLibrary1
{
    public class MarryChristmas
    {
        public string MarryChristmasDay()
        {
            return GetDate().Month == 12 && GetDate().Day == 25 ? "Today is Marry Christmas" : "Today is not Marry Christmas";
        }

        protected virtual DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}