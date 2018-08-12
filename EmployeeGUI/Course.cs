using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGUI
{
    [Serializable]
    public class Course
    {
        public string CourseID { get; set; }
        public string Description { get; set; }
        public string Grade { get; set; }
        public string Date { get; set; }
        public string Credits { get; set; }
        public string Approved { get; set; }
        
    }
}
