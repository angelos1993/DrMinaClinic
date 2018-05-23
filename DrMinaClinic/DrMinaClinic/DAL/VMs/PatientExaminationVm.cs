using System.ComponentModel;

namespace DrMinaClinic.DAL.VMs
{
    public class PatientExaminationVm
    {
        [DisplayName("ID")]
        public string PatientId { get; set; }

        [DisplayName("Patient Name")]
        public string PatientName { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }
    }
}