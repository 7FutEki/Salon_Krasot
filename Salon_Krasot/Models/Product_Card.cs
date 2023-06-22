using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Salon_Krasot.Models
{
    public class Product_Card
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public string Manufacturer { get; set; }
        public bool Active { get; set; }   
        public double Price { get; set; }
        public string? Description { get; set; }

       
    }
}
