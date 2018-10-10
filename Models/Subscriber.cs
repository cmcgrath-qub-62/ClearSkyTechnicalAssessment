using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClearSkyLogicTechnicalAssessment.Models
{
    [Table("subscribers")]
    public class Subscriber
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

}