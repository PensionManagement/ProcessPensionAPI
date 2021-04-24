﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessPensionAPI.Models
{
    public class PensionerInput
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string PAN { get; set; }
        public string AadhaarNo { get; set; }
        public int PensionType { get; set; }
    }
}
