using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Student> studentList = new List<Student>
            {
                new Student(101, "Ánh", 18),
                new Student(102, "Khoa", 20),
                new Student(103, "Anh", 17),
                new Student(104, "Thảo", 22),
                new Student(105, "Hon", 14)
            };
            //~~a
            Console.WriteLine("Danh sách học sinh:");
            studentList.ForEach(student => student.Show());
            //~~b
            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15-18:");
            var avgRangeStudent = studentList.Where(x => x.Age >= 15 && x.Age <= 18).ToList();
            avgRangeStudent.ForEach(x => x.Show());
            //~~c
            Console.WriteLine("\nDanh sách học sinh tên bắt đầu bằng 'A':");
            var nameFirstA = studentList.Where(x => x.Name.ToUpper().StartsWith("A")).ToList();
            nameFirstA.ForEach(x => x.Show());
            //~~d          
            int ageTotal = studentList.Sum(x => x.Age);
            Console.WriteLine("\nTổng tuổi học sinh trong danh sách: " + ageTotal);
            //~~e
            var oldestStudent = studentList.OrderByDescending(x => x.Age).First();
            Console.WriteLine("\nHọc sinh có tuổi lớn nhất: ");
            oldestStudent.Show();
            //~~f
            Console.WriteLine("\nDanh sách học sinh theo tuổi tăng dần:");
            var ascSortStudent = studentList.OrderBy(x => x.Age).ToList();
            ascSortStudent.ForEach(x => x.Show());
        }
    }
}
