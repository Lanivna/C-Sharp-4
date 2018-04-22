using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows;
using C_Sharp_4.Annotations;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace C_Sharp_4
{
    [Serializable]
    internal class Person : INotifyPropertyChanged
    {
        internal const string Filename = "People.dat";
        private string _firstName;
        private string _lastName;
        private string _email;
        private static DateTime _dateOfBirth;
        private int _age;
        private string _sun;
        private string _chinese;

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            Email = email;
            _dateOfBirth = dateOfBirth;
            _age = AgeCount();
            _sun = SunZodiac();
            _chinese = ChineseZodiac();
        }

        internal Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;

        }

        internal string Email
        {
            get => _email;
            private set
            {
                if (new EmailAddressAttribute().IsValid(value))
                    _email = value;
                else
                    throw new InvalidEmailException(value);
            }
        }

        internal Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }



        public static DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            private set { _dateOfBirth = value; }
        }

        internal static int AgeCount()
        {
            DateTime today = DateTime.Today;
            int _age = today.Year - _dateOfBirth.Year;

            if ((_dateOfBirth.Month > DateTime.Today.Month) ||
                (_dateOfBirth.Month == DateTime.Today.Month && _dateOfBirth.Day > DateTime.Today.Day))
            { _age--; }
            if (_age < 0)
            {
                throw new BdayInFutureException(DateOfBirth);
            }

            if (_age > 135)
            {
                throw new DeadPersonException(DateOfBirth);
            }

            return _age;
        }

        public bool IsAdult
        {
            get
            {
                DateTime today = DateTime.Today;
                var age = today.Year - _dateOfBirth.Year;
                return age >= 18;
            }
        }


        public string SunSign
        {
            get { return _sun; }
            set { _sun = value; }
        }

        public string ChineseSign
        {
            get { return _chinese; }
            set { _chinese = value; }
        }

        private string SunZodiac()
        {
            if (((_dateOfBirth.Month == 3) && (_dateOfBirth.Day >= 21 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 4) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 20)))
            {
                return "Mars (Pluto)";
            }
            if (((_dateOfBirth.Month == 4) && (_dateOfBirth.Day >= 21 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 5) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 21)))
            {
                return "Venus/Earth";
            }

            if (((_dateOfBirth.Month == 5) && (_dateOfBirth.Day >= 21 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 6) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 21)))
            {
                return "Mercury";
            }
            if (((_dateOfBirth.Month == 6) && (_dateOfBirth.Day >= 22 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 7) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 22)))
            {
                return "Moon";
            }
            if (((_dateOfBirth.Month == 7) && (_dateOfBirth.Day >= 23 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 8) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 22)))
            {
                return "Sun";
            }
            if (((_dateOfBirth.Month == 8) && (_dateOfBirth.Day >= 23 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 9) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 21)))
            {
                return "Mercury";
            }
            if (((_dateOfBirth.Month == 9) && (_dateOfBirth.Day >= 22 || _dateOfBirth.Day <= 30)) ||
                ((_dateOfBirth.Month == 10) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 22)))
            {
                return "Venus";
            }
            if (((_dateOfBirth.Month == 10) && (_dateOfBirth.Day >= 23 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 11) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 21)))
            {
                return "Pluto(Mars)";
            }
            if (((_dateOfBirth.Month == 11) && (_dateOfBirth.Day >= 22 || _dateOfBirth.Day <= 30)) ||
                ((_dateOfBirth.Month == 12) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 21)))
            {
                return "Jupiter";
            }
            if (((_dateOfBirth.Month == 12) && (_dateOfBirth.Day >= 22 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 1) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 20)))
            {
                return "Saturn";
            }
            if (((_dateOfBirth.Month == 1) && (_dateOfBirth.Day >= 21 || _dateOfBirth.Day <= 30)) ||
                ((_dateOfBirth.Month == 2) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 19)))
            {
                return "Uranus (Saturn)";
            }
            if (((_dateOfBirth.Month == 2) && (_dateOfBirth.Day >= 20 || _dateOfBirth.Day <= 31)) ||
                ((_dateOfBirth.Month == 3) && (_dateOfBirth.Day >= 01 || _dateOfBirth.Day <= 20)))
            {
                return "Neptune (Jupiter)";
            }
            else
            {
                return "";
            }
        }


        private string ChineseZodiac()
        {
            switch ((_dateOfBirth.Year - 4) % 12)
            {
                case 0:
                    return "Rat";
                    break;
                case 1:
                    return "Ox";
                    break;
                case 2:
                    return "Tiger";
                    break;
                case 3:
                    return "Rabbit";
                    break;
                case 4:
                    return "Dragon";
                    break;
                case 5:
                    return "Snake";
                    break;
                case 6:
                    return "Horse";
                    break;
                case 7:
                    return "Goat";
                    break;
                case 8:
                    return "Monkey";
                    break;
                case 9:
                    return "Rooster";
                    break;
                case 10:
                    return "Do";
                    break;
                case 11:
                    return "Pig";
                    break;

                default:
                    return " ";
                    break;
            }
        }

        public bool IsBirthday
        {
            get { return _dateOfBirth.DayOfYear == DateTime.Today.DayOfYear; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email)
            : base($"Check your email, please{email}")
        {
            string message = "Check your email, please.";
            string caption = "Something doesn't seem right!";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(message, caption, button);
        }
    }
    public class BdayInFutureException : Exception
    {
        public BdayInFutureException(DateTime dateOfBirth)
            : base($"You are too young!{dateOfBirth}")

        {
            string message = "Oh, boy! You are too young to be alive.";
            string caption = "Something doesn't seem right!";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(message, caption, button);
        }
    }

    public class DeadPersonException : Exception
    {
        public DeadPersonException(DateTime dateOfBirth)
           : base($"You are too old!{dateOfBirth}")
        {
            string message = "Oh, boy! You are too old to be alive.";
            string caption = "Something doesn't seem right!";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result;

            result = MessageBox.Show(message, caption, button);
        }
    }



}
