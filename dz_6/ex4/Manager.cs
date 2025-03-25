using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex4
{
    public class Manager : ISalary, IOutput
    {
        public int WorkDays => _workDays;
        private static readonly int _workDays = 3;
        public string FIO { get; set; }

        public int ManagerSalary => _managerSalary;
        private static readonly int _managerSalary = _workDays * 1000;

        public string CalculateSalary() => $"Зарплата менеджера: {_managerSalary}";

        public string PrintInfomation() => $"ФИО: {FIO}\nКол-во рабочих дней: {_workDays}\nЗарплата: {CalculateSalary()}";
    }
}
