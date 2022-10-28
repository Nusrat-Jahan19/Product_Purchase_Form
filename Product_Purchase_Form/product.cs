using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class product
    {
        [Required]
        public string username { get; set; }

        [Required]
        public int password { get; set; }

        [Required]
        [Range(1,100)]
        public float price1 { get; set; }

        [Required]
        [Range(1, 100)]
        public float price2 { get; set; }

        [Required]
        [Range(1, 100)]
        public float price3 { get; set; }

        [Required]
        [Range(1, 100)]
        public float price4 { get; set; }

        [Required]
        [Range(1, 100)]
        public float price5 { get; set; }

        [Required]
        [Range(1, 10)]
        public int amount1 { get; set; }

        [Required]
        [Range(1, 10)]
        public int amount2 { get; set; }

        [Required]
        [Range(1, 10)]
        public int amount3 { get; set; }

        [Required]
        [Range(1, 10)]
        public int amount4 { get; set; }

        [Required]
        [Range(1, 10)]
        public int amount5 { get; set; }
    }
}
