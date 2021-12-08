using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Core.KidsLearning.Control.Exten
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MyProperties
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }
    }
}
