using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Salon_Krasot.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get;set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateOnly DateBirthday { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public DateOnly DateFirstVisit { get; set; }
        public BitmapImage Photo { get; set; }

    }
}
