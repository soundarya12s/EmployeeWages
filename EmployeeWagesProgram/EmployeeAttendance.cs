﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesProgram
{
    public class employeeprogram
    {
        public void EmployeeWages()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);


            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
        }
        const int wage_per_hour = 20, full_day_hour = 8;

        public void calculateempwage()
        {
            int dailyempwage = wage_per_hour + full_day_hour;
            Console.WriteLine(dailyempwage);
        }
    }
}
