using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLModulzaro
{
    class TreatmentSheetViewModel
    {
        public Patient Patient { get; set; }
        public Treatment NewTreatment { get; set; }
        public List<string> BNOList { get; set; }
        public TreatmentSheetViewModel()
        {
            NewTreatment = new Treatment();


            BNOList = new List<string>();
            BNOList.Add("BNO A001");
            BNOList.Add("BNO A005");
            BNOList.Add("BNO A018");
            BNOList.Add("BNO A079");
            BNOList.Add("BNO A090");
            BNOList.Add("BNO A111");
        }

        internal bool Valid()
        {
            return !string.IsNullOrEmpty(NewTreatment.BNOkey) && !string.IsNullOrEmpty(NewTreatment.Note);
        }
    }
}
