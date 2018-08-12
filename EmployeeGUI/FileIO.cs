using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace EmployeeGUI
{
    [Serializable]
    public class FileIO : IFileAccess
    {
        public SortedDictionary<uint, Employee> EmployeeDB { get; set; } = new SortedDictionary<uint, Employee>();


        public string pathAndFile = "";

        /// <summary>
        /// This will save off the state of the empDictionary to a file.
        /// </summary>
        public void WriteFileDB()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fileStream = File.Create(pathAndFile);
            bf.Serialize(fileStream, EmployeeDB);
            fileStream.Close();
        }

        /// <summary>
        /// This will load empDictionary with the state from a file.
        /// </summary>
        public void ReadFileDB()
        {   try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fileStream = File.Open(pathAndFile, FileMode.Open);
                EmployeeDB = (SortedDictionary<uint, Employee>)bf.Deserialize(fileStream);
                fileStream.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to import file.", "Import Failed", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Gets the file for opening.
        /// </summary>
        public bool OpenFileDB()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "Open Employee GUI file";
            openFD.Filter = "Employee GUI File| *.egu";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                pathAndFile = openFD.FileName;
                ReadFileDB();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// gets the file for saving
        /// </summary>
        public bool CloseFileDB()
        {

            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Title = "Save Employee GUI file";
            saveFD.Filter = "Employee GUI File | *.egu";
            saveFD.FileName = "CS3260EmployeeDB";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                pathAndFile = saveFD.FileName;
                WriteFileDB();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}