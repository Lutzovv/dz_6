using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex6
{
    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Secondname { get; set; }
        public string Job { get; set; }
        public int HireYear { get; set; }


        public string Infomation() => $"Имя: {Name}\nФамилия: {Surname}\nОтчество: {Secondname}\nДолжность: {Job}\nГод принятия на работу: {HireYear}";


        public string EmployeeExperience(int year) => $"Стаж работника: {year - HireYear}";


        public Employee(string surname, string name, string secondname, string job, int hireYear)
        {
            Surname = surname;
            Name = name;
            Secondname = secondname;
            Job = job;
            HireYear = hireYear;
        }
    }
}
