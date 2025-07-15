using System;
using System.ComponentModel.DataAnnotations;

namespace AgricultureEMS.Models
{
    public class Crop
    {
        public int Id { get; set; }
        [Required]
        public string CropName { get; set; }
        public string? Variety { get; set; }
        public DateTime PlantedDate { get; set; }
        public int FieldId { get; set; }
        public Field? Field { get; set; }
    }
}