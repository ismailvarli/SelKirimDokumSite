using System.ComponentModel.DataAnnotations;

namespace SelKirimDokumSite.Models
{
    public class AppointmentRequest
    {
        [Required] public string Name { get; set; } = "";
        [Required] public string Phone { get; set; } = "";
        [EmailAddress] public string? Email { get; set; }
        [Required] public string Address { get; set; } = "";
        [Required] public string Service { get; set; } = "";
        public string? Message { get; set; }
        // New fields
        public string? City { get; set; }
        public string? District { get; set; }
        public string? DesiredDate { get; set; }
        public string? Budget { get; set; }
        public string? ProjectArea { get; set; }
        public string? Floors { get; set; }
    }
}