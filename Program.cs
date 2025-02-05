namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Information = new Person();

            //Add People
            Information.AddPerson = (new Person(1, "Ian", "Brooks", "Red", 30, true));
            Information.AddPerson = (new Person(1, "Ian", "Brooks", "Red", 30, true));
            Information.AddPerson = (new Person(1, "Ian", "Brooks", "Red", 30, true));
        }
    }
}
