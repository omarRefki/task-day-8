﻿using System.ComponentModel.DataAnnotations.Schema;

namespace day8solid.Models
{
    public class workOn
    {
        [ForeignKey("Employee")]
        public int? ESSN { get; set; }
        [ForeignKey("Project")]
        public int? Pnum { get; set; }

        public int? hour { get; set;}

       
       
        public virtual project? Project { get; set; }

       
      
        
        public virtual employee? Employee { get; set;}
    }
}
