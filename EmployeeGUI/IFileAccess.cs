using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeGUI
{
    public interface IFileAccess
    {
        void WriteFileDB();
        void ReadFileDB();
        bool OpenFileDB();
        bool CloseFileDB();

        SortedDictionary<uint, Employee> EmployeeDB { get; set; }
    }
}