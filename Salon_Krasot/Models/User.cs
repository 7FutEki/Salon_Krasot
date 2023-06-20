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
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get;set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? DateBirthday { get; set; }
        public string? NumberPhone { get; set; }
        public string? Email { get; set; }
        public string? Sex { get; set; }
        public string? DateFirstVisit { get; set; }
        public byte? Photo { get; set; }

    }
}
