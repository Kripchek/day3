using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Employees
    {
        public string _fullName;
        public int _department;
        public double _salary;

        public Employees(string fullname,int department,double salary) 
        {
            _fullName = fullname;
            _department = department;
            _salary = salary; 

        }
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }
        public  int Department
        {
            get => _department;
            set => _department = value;
        }
        public double Salary
        { 
            get => _salary;
            set => _salary = value;
        }
      
    }
}
