using System.ComponentModel;

namespace DrMinaClinic.DAL.VMs
{
    public class PregnancyDetailVm
    {
        [Browsable(false)]
        public bool Living { get; set; }

        [DisplayName("Living")]
        public string LivingString => Living ? "✔" : "✘";

        [DisplayName("AF")]
        public string Af { get; set; }

        [Browsable(false)]
        public bool Sex { get; set; }

        [DisplayName("Sex")]
        public string SexString => Sex ? "Male" : "Female";

        [DisplayName("Placenta")]
        public string Placenta { get; set; }

        [DisplayName("Weight")]
        public double Weight { get; set; }

        [DisplayName("Presentation")]
        public string Presentation { get; set; }

        [DisplayName("Other")]
        public string Other { get; set; }
    }
}