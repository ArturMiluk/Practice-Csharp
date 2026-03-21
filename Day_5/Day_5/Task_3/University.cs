using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class University
    {
        public string Name {get;}

        private readonly Department _department;

        private readonly Student[] _students;

        private Professor _professor;

        public University(string name, string deptTitle, Student[] students)
        {
            Name = name;
            _department = new Department(deptTitle);
            _students = students;
        }

        public void AssignProfessor(Professor professor)
        {
            _professor = professor; 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Университет: {Name}");
            Console.WriteLine($"Факультет: {_department.Title}");
            Console.WriteLine($"Преподаватель: {(_professor?.Name ?? "Не назначен")}");
            Console.WriteLine("Список студентов:");

            foreach (var student in _students)
            {
                Console.WriteLine($"- {student.FullName}");
            }
        }
    }
}

