using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(250)]
        public string ContactName { get; set; }
        [StringLength(250)]
        public string ContactMail { get; set; }
        [StringLength(250)]
        public string ContactSubject { get; set; }
        [StringLength(500)]
        public string ContactMessage { get; set; }
    }
}
