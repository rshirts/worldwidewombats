// Project Prolog
// Name: Randee Shirts
// CS3260 CSharp.Net
// Project: Lab_08
// Date: 10/16/2016
// Purpose:windows form that updates employee information
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeGUI
{
    public partial class FrmEmployeeAdd : Form
    {
        BusinessRules employeeList = BusinessRules.Instance;
        string monthlySalary = "Monthly Salary";
        string commision = "Commision";
        string grossSales = "GrossSales";
        string hourlyRate = "Hourly Rate";
        string hoursWorked = "Hours Worked";
        string contractWage = "Contract Wage";
        string errorMessageUint = "EmployeeID must be a valid positive Integer.";
        string errorMessageDouble = "There must be a valid double in ";
        string errorMessageCommision = "Commision";
        string errorMessageGrossSales = "Gross Sales";
        string errorMessageMonthlySalary = "Montly Salary";
        string errorMessageHourlyRate = "Hourly Rate";
        string errorMessageHoursWorked = "Hours Worked";
        string errorMessageContractWage = "Contract Wage";
        string statusMessageCreated = "Created employee ";
        string statusMessageNotCreated = "Duplicate employee found ";
        double tempDouble = 0;
        /// <summary>
        /// the initializer
        /// </summary>
        public FrmEmployeeAdd()
        {
            InitializeComponent();
        }

        #region Employee Data
        /***************************************

        This is where the EMPLOYEE DATA METHODS are.

        ***************************************/

        /// <summary>
        /// This will check the shared values for all employee fields
        /// </summary>
        /// <param name="creatingEmployee"> This is the employee that needs to be saved.</param>
        /// <returns></returns>
        private bool CheckBaseValues(Employee creatingEmployee)
        {
            uint tempUint = 0;

            if (uint.TryParse(TxtEmpID.Text, out tempUint))
            {
                creatingEmployee.EmpID = tempUint;
            }
            else
            {
                LblStatus.Text = errorMessageUint;
                TxtEmpID.Focus();
                return false;
            }

            if (TxtLastName.Text == "")
            {
                LblStatus.Text = "Last name cannot be empty.";
                TxtLastName.Focus();
                return false;
            }

            if (TxtFirstName.Text == "")
            {
                LblStatus.Text = "First name cannot be empty.";
                TxtFirstName.Focus();
                return false;
            }

            if(TxtMaritalStatus.Text == "")
            {
                LblStatus.Text = "Marital Status cannont be empty.";
                TxtMaritalStatus.Focus();
                return false;
            }

            if(TxtDepartment.Text == "")
            {
                LblStatus.Text = "Department cannont be empty.";
                TxtDepartment.Focus();
                return false;
            }   

            if (TxtTitle.Text == "")
            {
                LblStatus.Text = "Title cannot be emtpy.";
                TxtTitle.Focus();
                return false;
            }

            if(TxtStartDate.Text == "")
            {
                LblStatus.Text = "Start Date cannot be empty.";
                TxtStartDate.Focus();
                return false;
            }

            /*
            //Middle Name Not required.
            if (TxtMiddleName.Text == "")
            {
                LblStatus.Text = "Middle name cannot be empty.";
                TxtMiddleName.Focus();
                return false;
            }
            */

            creatingEmployee.EmpType = CbxEmployeeType.Text;
            creatingEmployee.FirstName = TxtFirstName.Text;
            creatingEmployee.LastName = TxtLastName.Text;
            creatingEmployee.MiddleName = TxtMiddleName.Text;
            creatingEmployee.MaritalStatus = TxtMaritalStatus.Text;
            creatingEmployee.Department = TxtDepartment.Text;
            creatingEmployee.Title = TxtTitle.Text;
            creatingEmployee.StartDate = TxtStartDate.Text;

            if (CkbBenefits.Checked)
                creatingEmployee.Benefits = true;
            else
                creatingEmployee.Benefits = false;

            if (CkbActiveEmployee.Checked)
                creatingEmployee.ActiveEmployee = true;
            else
                creatingEmployee.ActiveEmployee = false;
            return true;
        }


        /// <summary>
        /// this will add the employee to the business rules dictionary so it can be saved for later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            EType selectedType;

            if (!Enum.TryParse(CbxEmployeeType.Text, out selectedType))
            {
                LblStatus.Text = "Invalid employee type given.";
                return;
            }
            else if (selectedType == EType.SALARY)
            {
                Salary creatingEmployee = new Salary();
                if (!CheckBaseValues(creatingEmployee))
                {
                    return;
                }

                if (double.TryParse(TxtXtraProp1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.MonthlySalary = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageMonthlySalary;
                    TxtXtraProp1.Focus();
                    return;
                }

                //add employee education before creating employee
                AddEducation(creatingEmployee);

                if (employeeList.Add(creatingEmployee))
                {
                    AddEmployeeToView(creatingEmployee);

                    ClearForm();
                }
                else
                {
                    UpdateEmployee(creatingEmployee);
                }
            }
            else if (selectedType == EType.SALES)
            {
                Sales creatingEmployee = new Sales();
                if (!CheckBaseValues(creatingEmployee))
                {
                    return;
                }
                if (double.TryParse(TxtXtraProp1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.Commission = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageCommision;
                    TxtXtraProp1.Focus();
                    return;
                }
                if (double.TryParse(TxtXtraProp2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.GrossSales = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageGrossSales;
                    TxtXtraProp2.Focus();
                    return;
                }
                //add employee education before creating employee
                AddEducation(creatingEmployee);
                if (employeeList.Add(creatingEmployee))
                {
                    AddEmployeeToView(creatingEmployee);

                    ClearForm();
                }
                else
                {
                    UpdateEmployee(creatingEmployee);
                }
            }
            else if (selectedType == EType.HOURLY)
            {
                Hourly creatingEmployee = new Hourly();
                if (!CheckBaseValues(creatingEmployee))
                {
                    return;
                }
                if (double.TryParse(TxtXtraProp1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.HourlyRate = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageHourlyRate;
                    TxtXtraProp1.Focus();
                    return;
                }
                if (double.TryParse(TxtXtraProp2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.HoursWorked = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageHoursWorked;
                    TxtXtraProp2.Focus();
                    return;
                }
                //add employee education before creating employee
                AddEducation(creatingEmployee);
                if (employeeList.Add(creatingEmployee))
                {
                    AddEmployeeToView(creatingEmployee);

                    ClearForm();
                }
                else
                {
                    UpdateEmployee(creatingEmployee);
                }
            }
            else if (selectedType == EType.CONTRACT)
            {
                Contract creatingEmployee = new Contract();
                if (!CheckBaseValues(creatingEmployee))
                {
                    return;
                }
                if (double.TryParse(TxtXtraProp1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out tempDouble))
                {
                    creatingEmployee.ContractWage = tempDouble;
                }
                else
                {
                    LblStatus.Text = errorMessageDouble + errorMessageContractWage;
                    TxtXtraProp1.Focus();
                    return;
                }
                //add employee education before creating employee
                AddEducation(creatingEmployee);

                if (employeeList.Add(creatingEmployee))
                {
                    AddEmployeeToView(creatingEmployee);
                    ClearForm();
                }
                else
                {
                    UpdateEmployee(creatingEmployee);
                }
            }
        }

        /// <summary>
        /// Update the Employee if it already exists
        /// </summary>
        /// <param name="creatingEmployee"></param>
        private void UpdateEmployee(Employee creatingEmployee)
        {
            if (MessageBox.Show("Employee already exists would you like to update the record.", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //remove the employee
                BusinessRules.EmpDictionary.Remove(creatingEmployee.EmpID);
                //add the updated employee
                employeeList.Add(creatingEmployee);
                
                foreach (ListViewItem item in LVxEmployees.Items)
                {
                    if (item.SubItems[0].Text.Equals(creatingEmployee.EmpID.ToString()))
                        LVxEmployees.Items.Remove(item);
                }
                AddEmployeeToView(creatingEmployee);
                ClearForm();
            }
        }
        /// <summary>
        /// This will update all the fiends in the list view for the employee.
        /// </summary>
        /// <param name="creatingEmployee"></param>
        private void AddEmployeeToView(Employee creatingEmployee)
        {
            LblStatus.Text = statusMessageCreated + creatingEmployee.EmpID;
            ListViewItem lvi = new ListViewItem(creatingEmployee.EmpID.ToString());
            lvi.SubItems.Add(creatingEmployee.LastName.ToString());
            lvi.SubItems.Add(creatingEmployee.FirstName.ToString());
            LVxEmployees.Items.Add(lvi);
        }

        /// <summary>
        /// this will remove a selection from the employee view and also remove the employee from businessrules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You should only delete an employee if they never worked. ex.(incorrect ID input on creation) Do you really want to delete them.", "Delete Employee", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //return if nothing is selected.
                if (LVxEmployees.SelectedItems.Count == 0) return;
                ListView.SelectedListViewItemCollection mylist = LVxEmployees.SelectedItems;
                ListViewItem lvi = mylist[0];
                BusinessRules.EmpDictionary.Remove(uint.Parse(lvi.SubItems[0].Text));
                LVxEmployees.SelectedItems[0].Remove();
            }
        }

        /// <summary>
        /// this will populate the employee view when a search is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEmpSearch_Click(object sender, EventArgs e)
        {
            LVxEmployees.Items.Clear();
            if (TxtLastName.Text != "" && TxtEmpID.Text != "")
            {
                LblStatus.Text = "Please only use either Employee ID or Last Name to search.";
                TxtEmpID.Focus();
            }
            //adds all employees to the table if search is left empty.
            else if (TxtLastName.Text == "" && TxtEmpID.Text == "")
            {
                foreach (var employee in BusinessRules.EmpDictionary)
                {
                    //processSearch(employee.Value);
                    AddEmployeeToView(employee.Value);
                }
            }
            //search by empLastName
            else if (TxtLastName.Text != "" && TxtEmpID.Text == "")
            {
                var querey =
                    from emp in BusinessRules.EmpDictionary
                    where emp.Key.ToString() == TxtLastName.Text
                    select emp;

                foreach (var employee in querey)
                {
                    //processSearch(item.Value);
                    AddEmployeeToView(employee.Value);
                }
            }
            //search by empID
            else if (TxtLastName.Text == "" && TxtEmpID.Text != "")
            {
                var querey =
                    from emp in BusinessRules.EmpDictionary
                    where emp.Key.ToString() == TxtEmpID.Text
                    select emp;

                foreach (var employee in querey)
                {
                    //processSearch(item.Value);
                    AddEmployeeToView(employee.Value);
                }
            }
            ClearForm();
        }
        /// <summary>
        /// this is actually the double click when selected in the employee view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearForm();
            ListView.SelectedListViewItemCollection mylist = LVxEmployees.SelectedItems;
            ListViewItem lvi = mylist[0];
            Employee thisEmployee = BusinessRules.EmpDictionary[uint.Parse(lvi.SubItems[0].Text)];
            CbxEmployeeType.Text = thisEmployee.EmpType;
            ToggleText();
            TxtEmpID.Text = thisEmployee.EmpID.ToString();
            TxtLastName.Text = thisEmployee.LastName;
            TxtFirstName.Text = thisEmployee.FirstName;
            TxtMiddleName.Text = thisEmployee.MiddleName;
            TxtMaritalStatus.Text = thisEmployee.MaritalStatus;
            TxtDepartment.Text = thisEmployee.Department;
            TxtTitle.Text = thisEmployee.Title;
            TxtStartDate.Text = thisEmployee.StartDate;
            CkbBenefits.Checked = thisEmployee.Benefits;
            CkbActiveEmployee.Checked = thisEmployee.ActiveEmployee;
            if (thisEmployee.EmpType == EType.SALARY.ToString())
            {
                Salary thisEmp = new Salary();
                thisEmp = (Salary)thisEmployee;
                TxtXtraProp1.Text = thisEmp.MonthlySalary.ToString();
            }
            if (thisEmployee.EmpType == EType.SALES.ToString())
            {
                Sales thisEmp = new Sales();
                thisEmp = (Sales)thisEmployee;
                TxtXtraProp1.Text = thisEmp.Commission.ToString();
                TxtXtraProp2.Text = thisEmp.GrossSales.ToString();
            }
            if (thisEmployee.EmpType == EType.CONTRACT.ToString())
            {
                Contract thisEmp = new Contract();
                thisEmp = (Contract)thisEmployee;
                TxtXtraProp1.Text = thisEmp.ContractWage.ToString();
            }
            if (thisEmployee.EmpType == EType.HOURLY.ToString())
            {
                Hourly thisEmp = new Hourly();
                thisEmp = (Hourly)thisEmployee;
                TxtXtraProp1.Text = thisEmp.HourlyRate.ToString();
                TxtXtraProp2.Text = thisEmp.HoursWorked.ToString();
            }
            //update the education information.
            foreach (var item in thisEmployee.Education)
            {
                Course myCourse = item.Value;
                ListViewItem lviCourse = new ListViewItem(myCourse.CourseID);
                lviCourse.SubItems.Add(myCourse.Description);
                lviCourse.SubItems.Add(myCourse.Grade);
                lviCourse.SubItems.Add(myCourse.Date);
                lviCourse.SubItems.Add(myCourse.Credits);
                lviCourse.SubItems.Add(myCourse.Approved);
                LVxCourses.Items.Add(lviCourse);
            }
        }
        #endregion

        #region Education Data
        /***************************************

        This is where the EDUCATION DATA METHODS are.

        ***************************************/

        /// <summary>
        /// this will add the education information to an employee object at creation
        /// </summary>
        /// <param name="thisEmployee"></param>
        private void AddEducation(Employee thisEmployee)
        {
            Course courseToAdd = new Course();
            foreach (ListViewItem itemRow in LVxCourses.Items)
            {
                courseToAdd.CourseID = itemRow.SubItems[0].Text;
                courseToAdd.Description = itemRow.SubItems[1].Text;
                courseToAdd.Grade = itemRow.SubItems[2].Text;
                courseToAdd.Date = itemRow.SubItems[3].Text;
                courseToAdd.Credits = itemRow.SubItems[4].Text;
                courseToAdd.Approved = itemRow.SubItems[5].Text;
                thisEmployee.Education.Add(courseToAdd.CourseID, courseToAdd);
            }
        }

        /// <summary>
        /// This is the double click for the employee education information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LVxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this will add a course to the List view to be saved when the employee is created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LVxCourses.Items)
            {
                if (item.SubItems[0].Text == TxtCourseID.Text)
                {
                    if (MessageBox.Show("Course already exists would you like to update the record.", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        LVxCourses.Items.Remove(item);
                    else
                        return;
                }
            }
            ListViewItem lvi = new ListViewItem(TxtCourseID.Text);
            if (TxtDescription.Text != "")
            {
                lvi.SubItems.Add(TxtDescription.Text);
            }
            else
            {
                LblStatus.Text = "Please enter a value for the Description";
                TxtDescription.Focus();
            }
            if (TxtGrade.Text != "")
            {
                lvi.SubItems.Add(TxtGrade.Text);
            }
            else
            {
                LblStatus.Text = "Please enter a value for the Grade";
                TxtGrade.Focus();
            }
            if (TxtDateApproved.Text != "")
            {
                lvi.SubItems.Add(TxtDateApproved.Text);
            }
            else
            {
                LblStatus.Text = "Please enter a value for the Date Approved";
                TxtDateApproved.Focus();
            }
            if (TxtCredits.Text != "")
            {
                lvi.SubItems.Add(TxtCredits.Text);
            }
            else
            {
                LblStatus.Text = "Please enter a value for the Credits.";
                TxtCredits.Focus();
            }
            //checkbox value 
            lvi.SubItems.Add(CkbApproved.Checked.ToString());
            LVxCourses.Items.Add(lvi);
            ClearEducation();
        }
        /// <summary>
        /// this will remove a entry from the educcation list view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveCourse_Click(object sender, EventArgs e)
        {
            //return if nothing is selected.
            if (LVxCourses.SelectedItems.Count == 0)
                return;
            LVxCourses.SelectedItems[0].Remove();

        }
        #endregion

        #region Utility Methods
        /***************************************

        This is where the UTILITY METHODS are.

        ***************************************/

        /// <summary>
        /// This clears the form after an entry is added.
        /// </summary>
        private void ClearForm()
        {
            TxtEmpID.Clear();
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtMiddleName.Clear();
            TxtXtraProp1.Clear();
            TxtXtraProp2.Clear();
            CkbActiveEmployee.Checked = true;
            CkbBenefits.Checked = true;
            CkbApproved.Checked = true;
            LVxCourses.Items.Clear();
            TxtCourseID.Clear();
            TxtGrade.Clear();
            TxtDescription.Clear();
            TxtDateApproved.Clear();
            TxtCredits.Clear();
            TxtMaritalStatus.Clear();
            TxtDepartment.Clear();
            TxtTitle.Clear();
            TxtStartDate.Clear();
        }

        /// <summary>
        /// this will clear all the educational fields
        /// </summary>
        private void ClearEducation()
        {
            CkbApproved.Checked = true;
            TxtCourseID.Clear();
            TxtGrade.Clear();
            TxtDescription.Clear();
            TxtDateApproved.Clear();
            TxtCredits.Clear();
        }

        /// <summary>
        /// this one will show an error if the employee is not selected correctly 
        /// and toggle all text for the selected employee type.
        /// </summary>
        public void ToggleText()
        {
            if (CbxEmployeeType.Text == EType.SALARY.ToString())
            {
                LblXtraProp1Label.Text = monthlySalary;
                LblXtraProp1Label.Show();
                TxtXtraProp1.Show();
                LblXtraProp2Label.Hide();
                TxtXtraProp2.Hide();
            }
            else if (CbxEmployeeType.Text == EType.SALES.ToString())
            {
                LblXtraProp1Label.Text = commision;
                LblXtraProp2Label.Text = grossSales;
                LblXtraProp1Label.Show();
                TxtXtraProp1.Show();
                LblXtraProp2Label.Show();
                TxtXtraProp2.Show();
            }
            else if (CbxEmployeeType.Text == EType.HOURLY.ToString())
            {
                LblXtraProp1Label.Text = hourlyRate;
                LblXtraProp2Label.Text = hoursWorked;
                LblXtraProp1Label.Show();
                TxtXtraProp1.Show();
                LblXtraProp2Label.Show();
                TxtXtraProp2.Show();
            }
            else if (CbxEmployeeType.Text == EType.CONTRACT.ToString())
            {
                LblXtraProp1Label.Text = contractWage;
                LblXtraProp1Label.Show();
                TxtXtraProp1.Show();
                LblXtraProp2Label.Hide();
                TxtXtraProp2.Hide();
            }
            else
            {
                LblXtraProp1Label.Hide();
                LblXtraProp2Label.Hide();
                TxtXtraProp1.Hide();
                TxtXtraProp2.Hide();
                LblStatus.Text = "Please select an employee type.";
            }
        }

        /// <summary>
        /// when an employee type is chosen this will hide and show required fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxEmployeeType_TextChanged(object sender, EventArgs e)
        {
            ToggleText();
        }
        #endregion

        #region MenuItems
        /***************************************

        This is where the MENU ITEMS are.

        ***************************************/

        /// <summary>
        /// This will populate the business rules dictionary with a saved state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIO openMe = new FileIO();
            if (openMe.OpenFileDB())
            {
                BusinessRules.EmpDictionary = openMe.EmployeeDB;
                LblStatus.Text = openMe.pathAndFile + " was opened successfully.";
            }
            else
            {
                LblStatus.Text = "No file was opened.";
            }
        }
        /// <summary>
        /// This will save the state of business rules dictionary to a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileIO closeMe = new FileIO();
            closeMe.EmployeeDB = BusinessRules.EmpDictionary;
            if (closeMe.CloseFileDB())
            {
                LblStatus.Text = closeMe.pathAndFile + " was saved successfully.";
            }
            else
            {
                LblStatus.Text = "No file was saved.";
            }
        }
        /// <summary>
        /// This prompts the user if they really want to exit the program and then does if ok is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuiFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        
    }
}
