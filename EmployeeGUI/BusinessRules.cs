using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// This is a singleton class which holds references to different employee's
/// </summary>
namespace EmployeeGUI
{
    [Serializable]
    public sealed class BusinessRules

    {
        private static readonly BusinessRules instance = new BusinessRules();

        private BusinessRules() { }

        /// <summary>
        /// returns the same instance of the class
        /// </summary>
        public static BusinessRules Instance
        {
            get
            {
                return instance;
            }
        }

        private static SortedDictionary<uint, Employee> empDictionary = new SortedDictionary<uint, Employee>();


        public static SortedDictionary<uint, Employee> EmpDictionary
        {
            get
            {
                return empDictionary;
            }

            set
            {
                empDictionary = value;
            }
        }

        /// <summary>
        /// This is an indexer for the empObjects array.
        /// </summary>
        /// <param name="keyStudentID"></param>
        /// <returns></returns>
        public Employee this[uint keyStudentID]
        {
            get
            {
                Employee tempEmployee = null;
                if (empDictionary.TryGetValue(keyStudentID, out tempEmployee))
                {
                    return tempEmployee;
                }
                else
                {
                    return null;
                }

            }
            set
            {
                try
                {
                    empDictionary[keyStudentID] = value;
                }
                catch (KeyNotFoundException)
                {
                    MessageBox.Show("The key" + keyStudentID.ToString() + " was not found.");
                }
            }
        }
        
        /// <summary>
        /// adds a new employee to the data structure.
        /// </summary>
        /// <param name="empObj"></param>
        public bool Add(Employee empObj)
        {
            uint tempID = empObj.EmpID;
            try
            {
                empDictionary.Add(tempID, empObj);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}
