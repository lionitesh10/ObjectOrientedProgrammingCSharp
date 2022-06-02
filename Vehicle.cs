namespace ObjectOrientedProgramming
{
    public class Vehicle
    {
        private int noOfSeats;
        public int NoOfSeats
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }

        private float mileage;
        public float Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public Vehicle(int seats,float mil)
        {
            noOfSeats = seats; 
            mileage = mil;
        }

        public void displaySeats()
        {
            Console.WriteLine("Number of Seats :: {0}", noOfSeats);
        }
        public void displayMileage()
        {
            Console.WriteLine("Mileage :: {0} L", mileage);
        }
    }
    public class Car : Vehicle
    {
        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(int seats,float mil,string company,string model,int price) : base(seats, mil)
        {
            this.company = company;
            this.model = model;
            this.price = price;
        }

        public void displayCarBuiltInfo()
        {
            Console.WriteLine("{0} of Company :: {1}", model, company);
            Console.WriteLine("Price {0}Lakhs ", price);
        }
    }

    public class CarSell : Car
    {
        private string soldBy;
        public string SoldBy
        {
            get { return soldBy; }
            set { soldBy = value; }
        }

        private float commission;
        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public CarSell(int seats, float mil, string company, string model, int price,string soldBy,float commission):base(seats,mil,company,model,price)
        {
            this.soldBy = soldBy;
            this.commission = commission;
        }

        public void displayAllData()
        {
            Console.WriteLine("Car Sold By :: {0} with Commission :: {1} ",soldBy,commission);
            displayCarBuiltInfo();
            displaySeats();
            displayMileage();
        }
    }
}
