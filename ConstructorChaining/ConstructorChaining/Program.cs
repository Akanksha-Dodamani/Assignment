namespace Constructor_Chaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Constructor chaining----");
            SingleClass singleClass = new SingleClass();
            SingleClass singleClass1 = new SingleClass(100);

            Console.WriteLine("----Boxing Unboxing----");
            BoxingUnboxing.BoxUnboxMethod();
        }
    }
    public class SingleClass
    {
        public SingleClass(int num) : this("s")
        {
            Console.WriteLine("In Constructor");
        }
        public SingleClass() : this(10)
        {
            Console.WriteLine("In Default Constructor");
        }
        public SingleClass(string str)
        {
            Console.WriteLine("In String Constructor");
        }
    }
    public class BoxingUnboxing
    {
        public static void BoxUnboxMethod()
        {
            string sentence = "Hello";
            Object BoxedObj = sentence;
            Console.Write("Boxed sentence: " + BoxedObj);
            Console.WriteLine();

            string unboxedSentence = (string)BoxedObj;
            Console.Write("Unboxed sentence: " + unboxedSentence);
            Console.WriteLine();
        }
    }
}
