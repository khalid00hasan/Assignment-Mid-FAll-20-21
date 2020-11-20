using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_managment
{
    class Teaching_hour
    {
        public string CourseName { get; set; }
        public int CourseCreditNumber { get; set; }
        public Department Departments { get; set; }
        Course[] courses;
        public int CreditCount { get; set; }
        public Teaching_hour()
        {
            courses = new Course[5];
        }
        public Teaching_hour(string courseName, int courseCreditNumber, Department departments)
        {
            CourseName = courseName;
            CourseCreditNumber = courseCreditNumber;
            Departments = departments;
            courses = new Course[5];
        }
        public void AddTeachingHours(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 7)
                    this.courses[CreditCount++] = course;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Course Name : " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNumber);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowInfo();
            }
        }
    }
}