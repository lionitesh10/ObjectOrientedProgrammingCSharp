// See https://aka.ms/new-console-template for more information

using ObjectOrientedProgramming;
using System.Collections;


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

BackendDeveloper backend = new BackendDeveloper("Java");
backend.display();

BackendDeveloper backend1 = new BackendDeveloper(75);
backend1.displayProgress();

B b = new B();


ArrayList a1 = new ArrayList();
Console.WriteLine("Adding Numbers in Array List :: ");
Console.WriteLine("Enter Numbers :: ");
for(int i = 0; i < 10; i++)
{
    a1.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Capacity of Arraylist :: {0} ", a1.Capacity);
Console.WriteLine("Count :: {0} ",a1.Count);
Console.WriteLine("Content:: ");

foreach(int i in a1)
{
    Console.WriteLine(i+" ");   
}
Console.WriteLine("Sorted ArrayList");
a1.Sort();
foreach(int i in a1)
{
    Console.WriteLine(i + " ");
}



