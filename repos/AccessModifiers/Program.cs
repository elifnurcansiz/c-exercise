namespace AccessModifiers
{    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        { _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
           return _birthdate;
        }

        internal bool GetBirtdate()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            NewMethod(person);
            Console.WriteLine(person.GetBirtdate());
            

        }

        private static void NewMethod(Person person)
        {
            person.SetBirthDate(new DateTime(1982, 1, 1));
        }
    }
}