using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    [Serializable]
    sealed public class Sales : Salary
    {
        /// <summary>
        /// Not really sure.
        /// </summary>
        public Sales()
        {
            TypeCompensation = "Monthly Salary";
            OvertimeBenefits = false;
            BenefitsBenefits = true;
            CommissionBenefits = false;
            EducationalBenefits = true;
        }

        /// <summary>
        /// Commission ammount
        /// </summary>
        public double Commission { get; set; }


        /// <summary>
        /// Total sales
        /// </summary>
        public double GrossSales { get; set; }
    }
}