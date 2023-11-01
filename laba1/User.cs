using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class User
    {
        [Required]
        public required Guid Guid { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        public required int Age { get; set; }

        [Required]
        public required DateTime RegistrDate { get; set; }
        
    }
}
