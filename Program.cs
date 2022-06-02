// See https://aka.ms/new-console-template for more information

using ObjectOrientedProgramming;

Student student = new Student();
//student.id = 1;
//student.name = "Steve Jobs";
//student.age = 41;
//student.display();

student.Id = 1;
student.Name = "Steve Jobs";
student.Age = 41;
student.display();


Student s1 = new Student(2,"Bill Gates",70);
s1.display();

Incentive i1 = new Incentive("Woz ", 15000.0f, 2000f);
i1.displayFullSalary();

CarSell carS1 = new CarSell(4,25.1f,"Toyota","Rav4",54,"Prabhat",12.5f);
carS1.displayAllData();

Earth earth = new Earth("Earth "," 3 rd planet on solar system."," Having life and water on it ");
earth.DisplayAll();

