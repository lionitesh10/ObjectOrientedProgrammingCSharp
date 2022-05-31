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


