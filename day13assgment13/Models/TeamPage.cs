using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace day13assgment13.Models
{
    [Table("Teampage")]
    public class TeamPage
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string NOCW { get; set; }

    }
}