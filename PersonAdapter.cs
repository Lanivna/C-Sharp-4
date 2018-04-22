using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4
{
    class PersonAdapter
    {
        internal static Person CreateUser(string firstName, string lastName, string email, DateTime dateOfBirth)
        {

            return new Person(firstName, lastName, email, dateOfBirth);
        }
    }
}
