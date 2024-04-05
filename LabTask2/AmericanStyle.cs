using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    public class AmericanStyle : DateStyle
    {
        CultureInfo culture = new CultureInfo("en-US",false);
        public override string GetInfo()
        {
            return DateTime.Now.ToString(culture);
        }
    }
}
