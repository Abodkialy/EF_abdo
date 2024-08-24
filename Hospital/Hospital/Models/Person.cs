using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public enum Gender
    {

        male,
        female
    }
    public class Person
    {

        public string FName { get; set; }

        public string LName { get; set; }

        public string EmailAddress { get; set; }

        public int Phone { get; set; }

        public Gender Gender { get; set; }

        //Date of Birth
        public string DoB { get; set; }
        public Address Address { get; set; }
    }
}
