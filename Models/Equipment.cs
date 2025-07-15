using System.ComponentModel.DataAnnotations;

namespace AgricultureEMS.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        [Required]
        public string EquipmentName { get; set; }
        public string? Status { get; set; } // Available, In Use, Under Maintenance
    }
}