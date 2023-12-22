
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class HappyXmas : IHappyXmas
    {
        private readonly IHappyXmas _happyXmas;

        public HappyXmas(IHappyXmas happyXmas)
        {
            _happyXmas = happyXmas;
        }

        public string XmasDay(DateTime datetime)
        {
            return datetime.Month == 12 && datetime.Day == 25 ? "Today is Marry Christmas" : "Today is not Marry Christmas";
        }
    }
}
