namespace Inheritance
{
    class Student : Person
    {
        public byte point;

        public Student(string name, string surname, byte age, byte point) : base(name, surname, age)
        {
            this.point = point;
        }
    }
}
