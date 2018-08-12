using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    [Serializable]
    sealed public class Hourly : Employee
    {
        /// <summary>
        /// Calculates paycheck?
        /// </summary>
        public Hourly()
        {
            TypeCompensation = "Hourly Rate";
            OvertimeBenefits = true;
            BenefitsBenefits = false;
            CommissionBenefits = false;
            EducationalBenefits = true;
        }

        /// <summary>
        /// Rate of pay
        /// </summary>
        public double HourlyRate { get; set; }

        /// <summary>
        /// Time worked
        /// </summary>
        public double HoursWorked { get; set; }
    }
}