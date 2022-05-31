namespace ObjectOrientedProgramming
{
    public class Developer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        private float salary;
        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Developer(string name,float salary)
        {
            this.name = name;
            this.salary = salary;
        }

    }
    public class Incentive : Developer
    {
        private float addition;
        public float Addition
        {
            get { return addition; }
            set { addition = value; }
        }
        public Incentive(string name,float salary,float addition) : base(name, salary)
        {
            this.addition = addition;
        }
        public void displayFullSalary()
        {
            float incentiveValue = 0.0f;
            if (Salary >= 10000)
            {
                incentiveValue = 1000.0f;
            }
            else
            {
                incentiveValue = 2000.0f;
            }
            float totalSalary = Salary + incentiveValue+Addition;
            Console.WriteLine("Hi, {0}. Your Salary is {1}. Adding Incentive {2} for this month with addition {3}",Name,Salary,incentiveValue,Addition);
            Console.WriteLine("You Receive {0}",totalSalary);
        }
    }
}
