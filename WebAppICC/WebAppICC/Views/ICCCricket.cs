using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppICC.Views
{
    [Table("ICCCricket")]
    public class ICCCricket
    {
        [Key]
        public int ID { get; set; }            
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string NOWC { get; set; }
        
        
    }
}