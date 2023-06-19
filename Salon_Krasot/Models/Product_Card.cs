using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Salon_Krasot.Models
{
    public class Product_Card
    {
        public BitmapImage Photo { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }   

    }
}
