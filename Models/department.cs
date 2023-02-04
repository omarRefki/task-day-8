﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace day8solid.Models
{
    public class department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dnum { get; set; }
        public string? DName { get; set; }

        public virtual List<project>? Projects { get; set; } = new List<project>();

        public virtual List<Dlocations>? DLocations { get; set; }= new List<Dlocations>() ;
        public virtual List<employee>? Employees { get; set; } = new List<employee>();
        [ForeignKey("Employee")]
        public int? MangerId { get; set; }   
        public virtual employee? Employee { get; set; }
        public DateTime? hireDate { get; set; }

    }
}



