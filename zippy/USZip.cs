﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace zippy
{
    class USZip : ZipCodeValidator
    {
        public override void init()
        {
            pattern = @"^\d{5}(\-\d{4})?$";
        }
    }
}
