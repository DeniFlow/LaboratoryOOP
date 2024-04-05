using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    public class Decorator : DateStyle
    {
        protected DateStyle component;
        public override string GetInfo()
        {
           return component.GetInfo() + "DV-22-14";
        }
        public Decorator(DateStyle d)
        {
            component = d;
        }
    }
}
