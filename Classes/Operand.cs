using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Math_Monkeys
{
    [XmlType("OperandsRange")]
    public struct OperandsRange
    {
        [XmlElement("RangeMax")]
        public int rangeMax;
        [XmlElement("RangeMin")]
        public int rangeMin;

        public OperandsRange(int min, int max)
        {
            this.rangeMin = min;
            this.rangeMax = max;
        }
    }
}
