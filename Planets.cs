namespace ObjectOrientedProgramming
{
    public abstract class Planets
    {
        protected string name;
   
        protected string description;

        protected abstract void setNameDescription(string name,string description);
        protected abstract string getName();
        protected abstract string getDescription();
    }
    public class Earth : Planets
    {
        private string uniqueThing;
        public string UniqueThing
        {
            get { return uniqueThing; }
            set { uniqueThing = value; }
        }

        protected override void setNameDescription(string name,string description)
        {
            this.name = name;
            this.description = description;
        }

        public Earth(string name,string desc,string unique)
        {
            setNameDescription(name,desc);
            this.uniqueThing = unique;
        }

        protected override string getName()
        {
            return this.name;
        }
        protected override string getDescription()
        {
            return this.description;
        }

        public void DisplayAll()
        {
            Console.WriteLine("{0} Named planet, {1} and Uniquely Indentified for   {2}", getName(), getDescription(), uniqueThing);
        }

    }
}
