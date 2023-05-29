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
                new("блоб блоб",1,18800),
                new("блаб блаб",1,14737),
                new("блеб блеб",2,28800),
                new("бляб бляб",2,24737),
                new("бхоб бхоб",3,38800),
                new("бхаб бхаб",3,34737),
                new("бхеб бхеб",4,48800),
                new("бхяб бхяб",4,44737),

            };
            double sumsalary = 0;
            double avgsalary = 0;
            int count = 0;
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
                        UpSalaryEmployee();
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
            Up= 1.1
            
          
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
        }
        
    }
}