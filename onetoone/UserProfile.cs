using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onetoone
{
    class UserProfile
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public User User { get; set;}
        
    }
}
