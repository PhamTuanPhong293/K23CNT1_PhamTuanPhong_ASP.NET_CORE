using Microsoft.AspNetCore.Mvc;

namespace PtpLab6.Models
{
    public class PtpEmployee
    {
        public int PtpId { get; set; }
        public string PtpName { get; set; }
        public DateTime PtpBirthDay { get; set; }
        public string PtpEmail { get; set; }
        public string PtpPhone { get; set; }
        public double PtpSalary { get; set; }
        public bool PtpStatus { get; set; }
    }
}
