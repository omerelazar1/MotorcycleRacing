using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleRacingModel
{
    public class Users:BaseEntity
    {
        private string email;
        private string firstName;
        private string lastName;
        private bool isAdmin;
        private string pass;
        private int phone;

        public string Email { get => email; set => email = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Phone { get => phone; set => phone = value; }
    }
}
