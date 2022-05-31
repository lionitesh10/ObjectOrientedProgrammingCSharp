namespace ObjectOrientedProgramming
{
    public class Student
    {
        //public int id;
        //public string name;
        //public int age;


        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }    
        }

        public static int studentCount=0;

        public Student()
        {
            Console.WriteLine("Hi, I am default Non Parameterized Constructor , I am invoked automatically during object initialization ... !");
            studentCount++;
        }

        ~Student()
        {
            Console.WriteLine(" I am Destructor and I destruct the objects of classes.. !!");
        }
        public Student(int id,string name,int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("Hi, I am Parameterized Constructor, I am invoked automatically during object initialization ... !");
            Console.WriteLine("I am Overriding the default non-parameterized Constructor !!..");
            studentCount++;
        }


        public void display()
        {
            Console.WriteLine("Student Count :: " + studentCount);
            Console.WriteLine("ID :: "+id);
            Console.WriteLine("Name :: " + name);
            Console.WriteLine("Age :: "+age);
        }
        
    }
}
