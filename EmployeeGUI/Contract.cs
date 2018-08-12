using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    [Serializable]
    sealed public class Contract : Employee

    {
        /// <summary>
        /// Not sure what this is.
        /// </summary>
        public Contract()
        {
            TypeCompensation = "Monthly Pay";
            OvertimeBenefits = false;
            BenefitsBenefits = false;
            CommissionBenefits = false;
            EducationalBenefits = false;
        }

        public double ContractWage { get; set; }
    }
}