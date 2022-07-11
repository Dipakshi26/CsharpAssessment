using CsharpAssessment;
using System;
//Solution 8
//public class Computation : Operations
//{
//    public int Addition()
//    {

//        int a, b;
//        Console.WriteLine("Enter first int value");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter 2ed int value");
//        b = Convert.ToInt32(Console.ReadLine());

//        return a + b;
//    }

//    public int Multiplcation()
//    {
//        int a, b;
//        Console.WriteLine("Enter first int value");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter second int value");
//        b = Convert.ToInt32(Console.ReadLine());
//        return a * b;
//    }
//}
public class Program
{
    public static void Main()
    {


        ////Solution 1
        //int[] values = { 50, 65, 56, 71, 81 };
        //foreach (var result in values)
        //{
        //    if (result % 2 == 0)
        //    {
        //        Console.WriteLine(result + "  Even value");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result + "  Odd value");
        //    }
        //}

        //Solution 2
        //Boxing is the implicit conversion of a value type to a reference type.
        //Unboxing is the vice versa of boxing, it is converting refrence type to a value type.

        //int a = 8;
        //ArrayList arr = new ArrayList();
        ////Boxing
        //arr.Add(a);
        ////Unboxing
        //int b = (int)arr[0];

        //Solution 3
        //int num1, num2, num3;
        //num1 = 325;
        //num2 = 750;
        //num3 = 478;

        //if (num1 > num2)
        //{
        //    if (num1 > num3)
        //    {
        //        Console.WriteLine("325 is the greatest number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("750 is the greatest number");
        //    }
        //}
        //else if (num2 > num3)
        //    Console.WriteLine("750 is the greatest number");
        //else
        //    Console.WriteLine("478 is the greatest number");

        //Solution 4
        //int i = 0;

        //Console.WriteLine("Odd Numbers :");
        //for (i = 1; i <= 10; i++)
        //{
        //    if (i % 2 != 0)
        //    {
        //        Console.WriteLine(i + "");
        //    }
        //}


        //Solution 5
        //Method Overloading is when you have two methods with the same name but with different arguments.
        //  public class Area
        //    {
        //    public double area(double s)
        //    {
        //        double area = s * s;
        //        return area;
        //    }
        //    public double area(double l,double b)
        //    {
        //        double area = l * b;
        //        return area;
        //    }
        //}


        //Solution 6
        //string[] strArray = new string[]
        //    {"Delhi","Mumbai","Kolkata","Chennai"};
        //Console.WriteLine();
        //Console.WriteLine("Given array");
        //foreach (string str in strArray)
        //{
        //    Console.WriteLine(str + "");
        //}
        //Console.WriteLine();
        //Array.Sort(strArray);
        //Console.Write("Sorted Array\n");
        //foreach (string str in strArray)
        //{
        //    Console.WriteLine(str + "");
        //}



        //Solution 7
        //        class Book
        //{
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public string Publisher { get; set; }

        //    public Book(string title, string author)
        //    {
        //        Title = title;
        //        Author = author;

        //    }
        //    public Book(string title, string author, string publisher)
        //    {
        //        Title = title;
        //        Author = author;
        //        Publisher = publisher;

        //    }


        //}

        //Solution 9
        //        DisplayCricketPlayers();
        //    }
        //    public static void DisplayCricketPlayers()
        //    {
        //        Dictionary<int, string> playerNames = new Dictionary<int, string>()
        //        {
        //            { 1, "SR Tendulkar"},
        //            { 2, "V Kohli"},
        //            { 3, "R Dravid"},
        //            { 4, "MS Dhoni"},
        //            { 5, "V Sehwag"},
        //            { 6, "S Dhawan"},
        //            { 7, "A Jadeja"},
        //            { 8, "G Gambhir"},
        //            { 9, "Yuvraj Singh"},
        //            { 10, "KL Rahul"},
        //            { 11, "HH Pandya"}

        //        };
        //        foreach (var player in playerNames)
        //        {
        //            Console.WriteLine($"Jersey number: {player.Key}, Player name:{player.Value}");
        //        }

        //Solution 10
        //DisplayStudentsInfo();


        //Solution 8
        //Computation computation = new Computation();
        //Console.WriteLine($"Addition result : {computation.Addition()} ");
        //Console.WriteLine($"Multiplication result : {computation.Multiplcation()} ");

    }

//    public static void DisplayStudentsInfo()
//    {
//        List<Students> studentList = new List<Students>()
//                      {
//                         new Students(){Id=1,Name="Dipakshi",Age=20},
//                         new Students(){Id=2,Name="Aditya",Age=17},
//                         new Students(){Id=3,Name="Ayush",Age=21},
//                         new Students(){Id=4,Name="Akshat",Age=22},
//                         new Students(){Id=5,Name="Divyanshi",Age=20},
//                         new Students(){Id=6,Name="Devanshi",Age=23},
//                         new Students(){Id=7,Name="Prashant",Age=15}

//                      };

//        var list = studentList.Where(student => student.Age < 18).ToList();
//        foreach (var student in list)
//        {
//            Console.WriteLine($"{student.Id} {student.Name} {student.Age}");


//        }

//    }
//}
//public class Students
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }

//}

 }









