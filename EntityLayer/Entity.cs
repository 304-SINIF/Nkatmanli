using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Entity
    {
        private int id;
        private string namesurname; 
        private string city;
        private string department; 
        private int wage;

        public int Id { get => id; set => id = value; }
        public string Namesurname { get => namesurname; set => namesurname = value; }
        public string City { get => city; set => city = value; }
        public string Department { get => department; set => department = value; }
        public int Wage { get => wage; set => wage = value; }
    }
}
