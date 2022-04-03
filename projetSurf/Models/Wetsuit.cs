using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Wetsuit
    {
        public Wetsuit()
        {
            Uses = new HashSet<Use>();
        }

        public int IdWetsuits { get; set; }
        public string GenderWetsuits { get; set; }
        public string TypeWetsuits { get; set; }
        public string ZipperWetsuits { get; set; }
        public string ThicknessWetsuits { get; set; }
        public string LengthSleevesWetsuits { get; set; }
        public string HoodWetsuits { get; set; }
        public string BrandWetsuits { get; set; }
        public DateTime DatePurchaseWetsuits { get; set; }
        public string StateWetsuits { get; set; }

        public virtual ICollection<Use> Uses { get; set; }
    }
}
