using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(250)]
        public string WriterName { get; set; }
        [StringLength(250)]
        public string WriterSurname { get; set; }
        [StringLength(250)]
        public string WriterMail { get; set; }
        [StringLength(255)]
        public string WriterPassword { get; set; }
        public DateTime WriterCreateDate { get; set; }
        public bool WriterStatus { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
