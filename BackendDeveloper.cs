namespace ObjectOrientedProgramming
{
    public partial class BackendDeveloper
    {
        private string language;
        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public BackendDeveloper(string language)
        {
            this.language = language;
        }
        public void display()
        {
            Console.WriteLine("Language Used :: {0} ",language);
        }
    }
    public partial class BackendDeveloper
    {
        private int progress;
        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        public BackendDeveloper(int progress)
        {
            this.progress = progress;  
        }

        public void displayProgress()
        {
            Console.WriteLine("Progress :: {0}%",progress);
        }
    }
}
