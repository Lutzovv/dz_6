﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex3
{
    public interface ITax
    {
        static string ClassName { get; }

        string ItemName { get; set; }
        double ItemPrice { get; set; }

        public string AddTax();
    }
}
