using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    [Serializable]
    public abstract class Employee
    {
        public Employee()
        {
        }

        /// <summary>
        /// This will create more employees
        /// </summary>

        public SortedDictionary<string, Course> Education { get; set; } = new SortedDictionary<string, Course>();

        public uint EmpID { get; set; }

        public string EmpType { get; set; }
      
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string MaritalStatus { get; set; }
        
        public string Department { get; set; }

        public string Title { get; set; }
        
        public string StartDate { get; set; }

        public bool Benefits { get; set; }

        protected string TypeCompensation { get; set; }

        protected bool OvertimeBenefits { get; set; }

        protected bool BenefitsBenefits { get; set; }

        protected bool CommissionBenefits { get; set; }

        protected bool EducationalBenefits { get; set; }
        
        public bool ActiveEmployee { get; set; }
        
    }
}