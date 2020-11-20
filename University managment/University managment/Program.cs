using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_managment
{
    class Program
    {
        static void Main(string[] args)
        { 
            Course c = new Course("Java", 033, 3, 5.0, 1);
            Course c1 = new Course("C", 034, 3, 5.0, 1);
            Section s = new Section("I", "C", 035, 3, 5.0);
            Section s1 = new Section("J", "C++", 036, 3, 3.0);
            Section s2 = new Section("K", "C++", 001, 3, 3.0);
            Section s3 = new Section("L", "C#", 001, 3, 3.0);
            Section s4 = new Section("M", "C#", 001, 3, 3.0);
            Section s5 = new Section("I", "se", 002, 3, 3.0);
            Section s6 = new Section("J", "Math1", 002, 3, 3.0);
            Section s7 = new Section("K", "Math2", 002, 3, 3.0);
            Section s8 = new Section("L", "java", 002, 3, 3.0);
            Section s9 = new Section("M", "Math3", 002, 3, 3.0);
            s.SearchSection(001);
            Console.WriteLine("Seacrhing For");
            c.SearchSection(001);
            Console.WriteLine(" ");
            c.ShowInfo();
            Console.WriteLine(" ");
            s.ShowInfo();
           
            Department d = new Department("FST");
            Department d1 = new Department("FE");
            Department d2 = new Department("FBA");
            Department d3 = new Department("FASS");
            d.AddCourse(c1, c);
            d.ShowAllCourses();
            Console.WriteLine("  ");
            Console.WriteLine("Adding Courses In Department");
            d.AddCourse(s, s1, s2, s3, s4, s5, s6, s7, s8, s9);
            d.ShowAllCourses();
            Console.WriteLine(" ");
            Console.WriteLine("Faculty Taking Courses");
            Faculty f = new Faculty("Bob", "20-001");
            Faculty f1 = new Faculty("Alex", "20-002");
            Faculty f2 = new Faculty("davit", "20-003");
            Faculty f3 = new Faculty("TOMAS", "20-004");
            Faculty f4 = new Faculty("Adam", "20-005");
            Teaching_hour t = new Teaching_hour("C", 3, d);
            Teaching_hour t1 = new Teaching_hour("C++", 3, d);
            Teaching_hour t2 = new Teaching_hour("Java", 3, d);
            Teaching_hour t3 = new Teaching_hour("Python", 3, d);
            Teaching_hour t4 = new Teaching_hour("OS", 3, d);
            Teaching_hour t5 = new Teaching_hour("OOAD", 3, d);
            
            Console.WriteLine(" ");
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5);
            f.ShowAllCredits();
            Console.WriteLine("Faculty Information");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5);
            f1.ShowAllCredits();


        }
    }
}