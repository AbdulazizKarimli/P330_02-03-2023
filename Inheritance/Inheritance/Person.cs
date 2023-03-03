namespace Inheritance
{
    //public, internal, private, protected
    //public -> class, all class members
    //internal -> class, all class members
    //private -> all class memebers
    //protected -> all class members
    public class Person
    {
        public string name;
        protected string surname;
        byte age;

        public Person(string name, string surname, byte age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }
}
