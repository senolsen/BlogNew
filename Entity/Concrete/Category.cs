using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(250)]
        public string CategoryName { get; set; }
        [StringLength(250)]
        public string CategoryDescription { get; set; }
        public DateTime CategoryCreateDate { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
