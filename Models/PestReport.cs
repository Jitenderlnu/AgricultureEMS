using System;
using System.ComponentModel.DataAnnotations;

namespace AgricultureEMS.Models
{
    public class PestReport
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DateReported { get; set; }
        public int FieldId { get; set; }
        public Field? Field { get; set; }
    }
}