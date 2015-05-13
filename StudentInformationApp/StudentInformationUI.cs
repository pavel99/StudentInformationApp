using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInformationUI : Form
    {
        public StudentInformationUI()
        {
            InitializeComponent();
        }
        StudentInfo aStudent=new StudentInfo();
        //private string regNumber;
        //private string firstName;
        //private string lastName;
        private void showInfoButton_Click(object sender, EventArgs e)
        {
           aStudent.regNumber = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastname= lastNameTextBox.Text;
            MessageBox.Show("Name :" + aStudent.GetFullName() 
                            +" Reg No :" + aStudent.regNumber+aStudent.GetCode("123"));
            regNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();

        }

        private void retrieveInfoButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = aStudent.regNumber;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastname;

            //regNumber = null;
          // firstName = null;
          // lastName = null;

        }

        private void clearInfoButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            aStudent=new StudentInfo();

            //regNumber = null;
            //firstName = null;
            //lastName = null;

            

        }
    }
}
