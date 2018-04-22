using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace C_Sharp_4
{
    static class DBAdapter
    {
        public static List<Person> People { get; }

        static DBAdapter()
        {
            var file = Path.Combine(DataPath(), Person.Filename);
            if (File.Exists(file))
            {
                try
                {
                    People = SerializeHelper.Deserialize < List < Person >> (file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sorry, can't get the user from file{ex.Message}");
                    throw;
                }
            }
            else
            {
                People = new List<Person>();
                for (int i = 0; i < 50; ++i)
                {
                    Person addNewPerson = new Person($"Name{i}", $"Surname{i}", new DateTime(1999, 7, 28));
                    People.Add(addNewPerson);
                }
            }
        }

        internal static Person CreatePerson(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            Person person = null;
            if (person != null)
                People.Add(person);
            return person;
        }

        internal static void Save()
        {
            SerializeHelper.Serialize(People, Path.Combine(DataPath(), Person.Filename));
        }

        private static string DataPath()
        {
            string dir = StationManager.WorkingDirectory;
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir;
        }
    }
}
