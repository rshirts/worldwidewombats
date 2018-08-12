using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    [Serializable]
    public class Salary : Employee
    {
        /// <summary>
        /// Calculate the Salary
        /// </summary>
        public Salary()
        {
            TypeCompensation = "Monthly Salary";
            OvertimeBenefits = false;
            BenefitsBenefits = true;
            CommissionBenefits = false;
            EducationalBenefits = true;
        }

        /// <summary>
        /// The Salary Base
        /// </summary>
        public double MonthlySalary { get; set; }
    }
}