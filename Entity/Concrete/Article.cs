using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [StringLength(250)]
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        [StringLength(250)]
        public string ArticleImage { get; set; }
        public DateTime ArticleCreateDate { get; set; }
        public DateTime ArticleUpdateDate { get; set; }
        public bool ArticleStatus { get; set; }
        public int ArticleDisplay { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
