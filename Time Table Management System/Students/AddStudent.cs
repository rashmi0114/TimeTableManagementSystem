using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.Students
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxYearSem.Text = "";
            comboBoxProgramme.SelectedIndex = -1;
            numericGroupNo.Value = 0;
            textBoxGroupID.Text = "";
            numericsubGroup.Value = 0;
            textBoxSubGroupID.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxYearSem.Text == String.Empty)
            {
                textBoxYearSem.Focus();
                errorStudent.SetError(textBoxYearSem, " Enter Subject Name");
            }
            else if (comboBoxProgramme.SelectedIndex == -1)
            {
                comboBoxProgramme.Focus();
                errorStudent.SetError(comboBoxProgramme, " Select Programme");
            }
            else if (numericGroupNo.Value < 0)
            {
                numericGroupNo.Focus();
                errorStudent.SetError(numericGroupNo, " Enter Valid Group Number");
            }
            else if (textBoxGroupID.Text == String.Empty)
            {
                textBoxGroupID.Focus();
                errorStudent.SetError(textBoxGroupID, " Enter Group Id");
            }
            else if (numericsubGroup.Value < 0)
            {
                numericsubGroup.Focus();
                errorStudent.SetError(numericsubGroup, " Enter Valid Sub Group Number");
            }
            else if (textBoxSubGroupID.Text == String.Empty)
            {
                textBoxSubGroupID.Focus();
                errorStudent.SetError(textBoxSubGroupID, " Enter Sub Group Id");
            }
            else
            {
                Student student = new Student();
                IStudentService studentService = new StudentService();

                // Set Data
                student.AcademicYear = textBoxYearSem.Text.Trim();
                student.GroupNumber = int.Parse(numericGroupNo.Value.ToString());
                student.GroupId = textBoxGroupID.Text.Trim();
                student.SubGroupNumber = int.Parse(numericsubGroup.Value.ToString());
                student.SubGroupId = textBoxSubGroupID.Text.Trim();

                switch (comboBoxProgramme.SelectedIndex)
                {
                    case 0:
                        student.Programme = "IT";
                        break;
                    case 1:
                        student.Programme = "CSSE";
                        break;
                    case 2:
                        student.Programme = "CSE";
                        break;
                    case 3:
                        student.Programme = "DS";
                        break;
                    case 4:
                        student.Programme = "CN";
                        break;
                }
                //Insert Data
                if (studentService.addStudent(student))
                {
                    //MessageBox.Show(student.StudentGroup);
                    SuccessMessage sc = new SuccessMessage("Student Group Added Successfully !");
                    sc.Show();
                    textBoxYearSem.Text = "";
                    comboBoxProgramme.SelectedIndex = -1;
                    numericGroupNo.Value = 0;
                    textBoxGroupID.Text = "";
                    numericsubGroup.Value = 0;
                    textBoxSubGroupID.Text = "";
                }
                else
                {
                    ErrorMessage ec = new ErrorMessage("there is somethin wrong when adding  student");
                    ec.Show();
                    textBoxYearSem.Text = "";
                    comboBoxProgramme.SelectedIndex = -1;
                    numericGroupNo.Value = 0;
                    textBoxGroupID.Text = "";
                    numericsubGroup.Value = 0;
                    textBoxSubGroupID.Text = "";
                }
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateIDs_Click(object sender, EventArgs e)
        {
            String GroupID = textBoxYearSem.Text + "." + comboBoxProgramme.SelectedItem + "." + numericGroupNo.Value;
            String SubGroupID = textBoxYearSem.Text + "." + comboBoxProgramme.SelectedItem + "." + numericGroupNo.Value + "." + numericsubGroup.Value;

            textBoxGroupID.Text = GroupID;
            textBoxSubGroupID.Text = SubGroupID;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
