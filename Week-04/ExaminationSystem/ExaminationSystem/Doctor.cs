using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Doctor
    {
        public Doctor(string name, string id, string password)
        {
            this.name = name;
            Id = id;
            Password = password;
        }

        public string name {  get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
    }
}
