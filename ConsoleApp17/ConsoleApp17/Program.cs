using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Program
    {
       public static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>(10)
            {
                new("блоб блоб",1,18800,1),
                new("блаб блаб",1,14737,2),
                new("блеб блеб",2,28800,3),
                new("бляб бляб",2,24737,4),
                new("бхоб бхоб",3,38800,5),
                new("бхаб бхаб",3,34737,6),
                new("бхеб бхеб",4,48800,7),
                new("бхяб бхяб",4,44737,8),

            };
            double sumsalary = 0;
            double avgsalary = 0;
            double avgsalary2= 0;
            int count = 0;
            int countforavg = 0;
            while (true)
            {
                Console.WriteLine("выберите раздел : \n 1 - задание на 30.03 \n 2 - задание на 03.04");
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("выберите задание: \n 1 - вывести список всех сотрудников с имеющимися данными \n 2 - сумма затрат на зарплаты в месяц \n 3 - минимальная зарплата \n 4 - максимальная зарплата \n 5 - средняя зарплата всех сотрудников \n 6 - ФИО всех сотрудников");
                        int choise1 = int.Parse(Console.ReadLine());
                        switch (choise1)
                        {
                            case 1:
                                GetEmployeesInfo();
                                break;
                            case 2:
                                SumSalary();
                                break;
                            case 3:
                                MinSalary();
                                break;
                            case 4:
                                MaxSalary();
                                break;
                            case 5:
                                AvgSalary();
                                break;
                            case 6:
                                GetEmployeesFio();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("выберите задание: \n 1 - индексация зарплат \n 2 - зарплата ниже вводимого значения \n 3 - зарплата выше вводимого значения \n 4 - через номер отдела(департамента) ");
                        int choise2 = int.Parse(Console.ReadLine());
                        switch (choise2)
                        {
                            case 1:
                                UpSalaryEmployee();
                                break;
                                case 2:
                                Selectless();
                                break;
                                case 3:
                                Selectabove();
                                break;
                            case 4:
                                Console.WriteLine("1 - Сотрудник с минимальной зарплатой \n 2 - Сотрудник с маккимальной зарплатой \n 3 - Среднюю зарплату по отделу \n 4 - Проидексировать зарплату всех сотрудников \n 5 - все данные сотрудников с определенного отдела");
                                int choise3 = int.Parse(Console.ReadLine());
                                switch (choise3)
                                {
                                    case 1:
                                        MinSalaryEmployeeWithDepartment();
                                        break;
                                        case 2:
                                        MaxSalaryEmployeeWithDepartment();
                                        break;
                                        case 3:
                                        AvgSalaryEmployeesWithDepartment();
                                        break;
                                        case 4:
                                        UpSalaryEmployeesWithDepartment();
                                        break;
                                        case 5:
                                        GetInfoAllEmployeesWithDepartment();
                                        break;
                                }
                                break;
                        }
                        break;
                
                }
               

                

                Console.WriteLine("вы хотите вернуться к выбору? (y/n)");
                string  c = (Console.ReadLine());
                if (c == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            void GetEmployeesFio()
            {
                foreach (var emp in employee)
                {
                    Console.WriteLine(emp.FullName);
                }
            }

            void SumSalary()
            {
                foreach (var emp in employee)
                {
                    sumsalary += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплаты в месяц -- {sumsalary}") ;
            }

            void AvgSalary()
            {
                foreach (var emp in employee)
                {
                    count++;
                    avgsalary += emp.Salary;
                     

                }
                avgsalary /= count;
                Console.WriteLine(avgsalary); 
            }

            void GetEmployeesInfo()
            {
                foreach (var emp in employee)
                {
                    Console.WriteLine($"Фио сотрудника {emp.FullName} -- департамент в котором работает сотрудник {emp.Department} -- зарплата сотрудника {emp.Salary}");
                }
            }
            void MinSalary()
            {
                Console.WriteLine($" Минимальная зарплата {employee.Min(e => e.Salary + " y " + e.FullName)}");
            }
            void MaxSalary()
            {
                Console.WriteLine($" Минимальная зарплата {employee.Max(e => e.Salary + " y " + e.FullName)}");
            }
            void UpSalaryEmployee()
            {
                Console.WriteLine("На сколько вы хотите поднять зарплату сотрудникам?");
                double upsalaryemployee = double.Parse(Console.ReadLine());
                foreach (var emp in employee)
                {
                    emp.Salary *= upsalaryemployee;
                    Console.WriteLine($"заплата у сотрудника {emp.FullName} равна {emp.Salary}");
                }
            }
            void Selectless()
            {
                Console.WriteLine("Введите число");
                int selectless = int.Parse(Console.ReadLine());
                foreach(var emp in employee)
                {
                    if(emp.Salary < selectless)
                    {
                        Console.WriteLine($"ФИО {emp.FullName} -- Зарплата сотрудника {emp.Salary}-- табельный номер сотрудника {emp.ID} ");
                    }
                }
            }
            void Selectabove()
            {
                Console.WriteLine("Введите число");
                int selectless = int.Parse(Console.ReadLine());
                foreach (var emp in employee)
                {
                    if (emp.Salary >= selectless)
                    {
                        Console.WriteLine($"ФИО {emp.FullName} -- Зарплата сотрудника {emp.Salary}-- табельный номер сотрудника {emp.ID} ");
                    }
                }
            }
            void GetInfoAllEmployeesWithDepartment()
            {
                Console.WriteLine("Введите номер отдела ");
                int selectdepartment = int.Parse(Console.ReadLine());
                foreach ( var emp in employee)
                {
                    if (emp.Department == selectdepartment)
                    {
                        Console.WriteLine($"В данном отделе присутствует {emp.FullName} -- зарплата {emp.Salary} -- табельный номер {emp.ID}");
                    }
                }
            }
            void UpSalaryEmployeesWithDepartment()
            {
                Console.WriteLine("Введите номер отдела ");
                int selectdepartment1 = int.Parse(Console.ReadLine());
                Console.WriteLine("На сколько вы хотите поднять зарплату сотрудникам?");
                double upsalaryemployee = double.Parse(Console.ReadLine());
                foreach (var emp in employee)
                {
                    if (emp.Department == selectdepartment1)
                    {
                        emp.Salary *= upsalaryemployee;
                        Console.WriteLine($"заплата у сотрудника {emp.FullName} равна {emp.Salary}");
                    }
                }
            }
            void AvgSalaryEmployeesWithDepartment()
            {
                Console.WriteLine("Введите номер отдела ");
                int selectdepartment2 = int.Parse(Console.ReadLine());
                foreach (var emp in employee)
                {
                    if (emp.Department == selectdepartment2)
                    {
                        countforavg++;
                        avgsalary2 += emp.Salary;
                    }
                }

                avgsalary2 /= countforavg;
                if (selectdepartment2 < 5)
                {
                    Console.WriteLine($"Средняя зарплата по введенному вами отделу равна {avgsalary2}");
                    avgsalary2 = 0;
                    countforavg = 0;
                }
                else
                {
                    Console.WriteLine("Данного отдела нет в базе");
                    avgsalary2 = 0;
                    countforavg = 0;
                }
            }
            void MinSalaryEmployeeWithDepartment()
            {
                
                    Console.WriteLine("Введите номер отдела");
                    int selectdepartment3 = int.Parse(Console.ReadLine());
                    var employeesInDepartment = employee.Where(e => e.Department == selectdepartment3);
                    if (employeesInDepartment.Any())
                    {
                        var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
                        Console.WriteLine($"Человек с самой минимальной зарплатой в отделе {selectdepartment3}: {employeeWithMinSalary.FullName} - {employeeWithMinSalary.Salary} рублей");
                    }
                    else
                    {
                        Console.WriteLine($"Отдел {selectdepartment3} не найден или не имеет сотрудников.");
                    }
            }

            void MaxSalaryEmployeeWithDepartment()
            {

                Console.WriteLine("Введите номер отдела");
                int selectdepartment4 = int.Parse(Console.ReadLine());
                var employeesInDepartment = employee.Where(e => e.Department == selectdepartment4);
                if (employeesInDepartment.Any())
                {
                    var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).Last();
                    Console.WriteLine($"Человек с самой максимальной зарплатой в отделе {selectdepartment4}: {employeeWithMinSalary.FullName} - {employeeWithMinSalary.Salary} рублей");
                }
                else
                {
                    Console.WriteLine($"Отдел {selectdepartment4} не найден или не имеет сотрудников.");
                }
            }
        }
        
    }
}