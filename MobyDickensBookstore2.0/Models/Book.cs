using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobyDickensBookstore2._0.Models
{
    public class Book
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [RegularExpression(@"\d{10,13}")]
        public long ISBN { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        public string Author { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}