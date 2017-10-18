using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KLModulzaro
{
    class DatientDataViewModel
    {
        public Patient Patient { get; set; }
        

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Patient.Name) && !string.IsNullOrEmpty(Patient.TAJ) && !string.IsNullOrEmpty(Patient.Birthplace) && Patient.Birthday != DateTime.Now;
        }
    }
}
