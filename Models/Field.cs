using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgricultureEMS.Models
{
    public class Field
    {
        public int Id { get; set; }
        [Required]
        public string FieldName { get; set; }
        public double Area { get; set; }
        public ICollection<Crop>? Crops { get; set; }
    }
}