namespace ObjectOrientedProgramming
{
    public class ConstructorOrder
    {
        public ConstructorOrder()
        {
            Console.WriteLine("Hi this is Base Class.. ");
        }
    }
    public class A : ConstructorOrder
    {
        public A()
        {
            Console.WriteLine("Hi, I am Constructor of class A...");
        }
    }
    public class B : A
    {
        public B()
        {
            Console.WriteLine("Hi, I am Constructor of class B...");
        }
    }
}
