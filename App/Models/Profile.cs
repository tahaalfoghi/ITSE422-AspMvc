using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    // this is profile class that represents as a table in the database
    // the class contains multiple properties that represent the table columns
    public class Profile
    {
        // [Key] here is the primary key of the table
        // then the [Required] attribute make sure that the columns must has a value in the table [NotNull]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
}