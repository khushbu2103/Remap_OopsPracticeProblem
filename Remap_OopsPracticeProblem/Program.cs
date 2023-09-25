using Remap_OopsPracticeProblem.Absraction;
using Remap_OopsPracticeProblem.Encapsulation;
using Remap_OopsPracticeProblem.OopsInheritance;
using Remap_OopsPracticeProblem.Polymarphism;
using Remap_OopsPracticeProblem.Polymarphism.MethodOverriding;
using Remap_OopsPracticeProblem.TypesOfInheritance;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Remap_OopsPracticeProblem.ExtensionMethods;
using static Remap_OopsPracticeProblem.TypesOfVaribles;

namespace Remap_OopsPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                bool execute = true;
                while (execute)

                {
                    Console.WriteLine("Choose any program");
                    Console.WriteLine("1. Object and class concept program\n" +
                        "2. Inheritance\n" +
                        "3. Polimarphism-method overloading\n" +
                        "4. Polimarphism-method overriding\n" +
                        "5. Encapsulation\n" +
                        "6. Abstraction\n" +
                        "7. Types of variables present in c#" +
                        "9. Value type and reference type code\n" +
                        "10. Types of inheritance (Single Inheritance)\n" +
                        "11. Types of inheritance (Hierarchical Inheritance)\n" +
                        "12. Types of inheritance (Multilevel Inheritance)\n" +
                        "13. Types of inheritance (Multiple Inheritance\n)");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                        ObjectAndClassConcept objectAndClassConcept = new ObjectAndClassConcept();
                        objectAndClassConcept.Addition();
                        
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion1 = Convert.ToInt32(Console.ReadLine());
                        if (desicion1 == 0)
                        {
                            execute = false;
                        }
                            break;
                    case 2:
                        Fruits apple = new Fruits();
                        apple.color = "Red";
                        Fruits orange = new Fruits();
                        orange.color = "orange";
                        Console.WriteLine("Quantity of apple is : {0}", apple.Quantity);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion2 = Convert.ToInt32(Console.ReadLine());
                        if (desicion2 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 3:
                        MethodoverLoading.Addition(10, 20);
                        MethodoverLoading.Addition(100, 200, 300);
                        MethodoverLoading.Addition(10000, 200, 300);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion3 = Convert.ToInt32(Console.ReadLine());
                        if (desicion3 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 4:
                        //Method overriding
                        Car car = new Car();
                        car.VehicleStarted();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion4 = Convert.ToInt32(Console.ReadLine());
                        if (desicion4 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 5:
                        Student student = new Student();
                        student.Name = "khushi";
                        Console.WriteLine(student.Name);
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion5 = Convert.ToInt32(Console.ReadLine());
                        if (desicion5 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 6:
                        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
                        partTimeEmployee.GetSalary();
                        partTimeEmployee.EmployeeDetails();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion6 = Convert.ToInt32(Console.ReadLine());
                        if (desicion6 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 7:
                        //Local variable
                        int age = 0;
                        age = age + 10;
                        Console.WriteLine("Student age is: " + age);
                        //Instance variable & static
                        Marks obj1 = new Marks();
                        obj1.engMarks = 90;
                        obj1.mathsMarks = 80;
                        obj1.phyMarks = 93;
                        Console.WriteLine("Marks for first object:");
                        Console.WriteLine(obj1.engMarks);
                        Console.WriteLine(obj1.mathsMarks);
                        Console.WriteLine(obj1.phyMarks);

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion7 = Convert.ToInt32(Console.ReadLine());
                        if (desicion7 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 8:
                        //Extension method
                        string value = "deeksha sharma";
                        value = value.UppercaseFirstLetter();
                        Console.WriteLine(value);
                        //instance method
                        PropertyUtil util = new PropertyUtil();
                        util.DoSomething();
                        //static method
                        PropertyUtil2.DoSomething();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion8 = Convert.ToInt32(Console.ReadLine());
                        if (desicion8 == 0)
                        {
                            execute = false;
                        }
                        break;
                    case 9:
                        ValueTypeReferenceType.ValueAndReferenceTypeCode();
                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion9 = Convert.ToInt32(Console.ReadLine());
                        if (desicion9 == 0)
                        {
                            execute = false;
                        }
                        break;
                     case 10:
                        Sparrow sparrow = new Sparrow();
                        sparrow.color = "Brown";
                        Console.WriteLine(sparrow.color);

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion10 = Convert.ToInt32(Console.ReadLine());
                        if (desicion10 == 0)
                        {
                            execute = false;
                        }
                        break;
                     case 11:
                        Dog dog = new Dog();
                        dog.color = "black";
                        Console.WriteLine("Color of dog is : {0}", dog.color);
                        Cow cow = new Cow();
                        Console.WriteLine("Color of cow is : {0}", cow.color);

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion11 = Convert.ToInt32(Console.ReadLine());
                        if (desicion11 == 0)
                        {
                            execute = false;
                        }
                        break;
                     case 12:
                        MultilevelInheritance multilevelInheritance = new MultilevelInheritance();
                        multilevelInheritance.AnimalSound();

                        Console.WriteLine("\nWould you like to continue(1) or exit the program(0)");
                        int desicion12 = Convert.ToInt32(Console.ReadLine());
                        if (desicion12 == 0)
                        {
                            execute = false;
                        }
                        break;
                    }

                }
            
        }
    }
}
