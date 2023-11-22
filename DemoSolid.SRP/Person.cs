namespace DemoSolid.SRP
{
    public class Person
    {
        private string name;
        private string document;
        private string birthDate;

        public Person(string name, string document, string birthDate)
        {
            this.name = name;
            this.document = document;
            this.birthDate = birthDate;
        }
    }
}