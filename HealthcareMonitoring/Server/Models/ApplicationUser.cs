using Microsoft.AspNetCore.Identity;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthcareMonitoring.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNo { get; set; }

        public string? NRIC {  get; set; }
        public string? Gender { get; set; }

        public string? Address { get; set; }
        public DateTime? DOB { get; set; }

    }
}