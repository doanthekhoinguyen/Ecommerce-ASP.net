using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models.EF
{
    public class Mixtape
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public int LabelStyle { get; set; }
        public string LinkA { get; set; }
        public string LinkB { get; set; }
    }
}