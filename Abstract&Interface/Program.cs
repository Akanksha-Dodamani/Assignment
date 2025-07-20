namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dogName = new Dog("Austin");
            dogName.Eat();
            dogName.Walk();
            dogName.ToString();
        }
    }
}
