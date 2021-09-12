using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SchoolHRAPI;
namespace ShcoolHRAdminstrationHW
{
    public class SchoolHRAdminstrationForm : Form
    {   //compenents //
        Label lblEmployeeRegestringSystem, lblEmployeeID, lblEmployeeName, lblEmployeeSalary, lblEmployeeType, lblEmployeeCounter, lblEmployeeSalarySum, lblEmployeeCounterInitialnumber, lblEmployeeSalarySumInitialnumber;
        TextBox txtEmployeeID, txtEmployeeName, txtEmployeeSalary;
        ComboBox cmbEmployeeType;
        Button btnAddEmployee, btnClearTextBoxes;

        public SchoolHRAdminstrationForm()
        {   //form setting//
            this.Size = new Size(500, 400);
            this.Text = "SchoolHRAdminstrationSystem";
            this.BackColor = Color.DarkGray;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            Initilase();
        }

        List<Iemployee> employees = new List<Iemployee>();

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            employees.Add(employeeFactory.getEmployeeInformation(cmbEmployeeType.Text, Convert.ToInt32(txtEmployeeID.Text), txtEmployeeName.Text, Convert.ToDecimal(txtEmployeeSalary.Text)));
            lblEmployeeSalarySumInitialnumber.Text = employees.Sum(em => em.employeeSalary).ToString();
            lblEmployeeCounterInitialnumber.Text = employees.Count.ToString();
        }
        private void btnClearTextBoxes_Click(object sender, EventArgs e)
        {
           foreach(object t in this.Controls )
            {
                if (t is TextBox)
                    ((TextBox)(t)).Clear();
            }
        }
        //Controls Disigning
        private void Initilase() 
        { ///////////Lables formatting///////////

            lblEmployeeRegestringSystem = new Label();
            lblEmployeeRegestringSystem.AutoSize = true;
            lblEmployeeRegestringSystem.Text = "Employee Regestrig System";
            lblEmployeeRegestringSystem.Location = new Point(150, 10);
            lblEmployeeRegestringSystem.ForeColor = Color.White;
            lblEmployeeRegestringSystem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeRegestringSystem);

            lblEmployeeID = new Label();
            lblEmployeeID.Text = "Employee ID";
            lblEmployeeID.Location = new Point(20, 30);
            lblEmployeeID.ForeColor = Color.White;
            lblEmployeeID.Font = new Font("Tahoma", 10.2F,FontStyle.Bold,GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeID);

            lblEmployeeName = new Label();
            lblEmployeeName.Text = "Employee Name";
            lblEmployeeName.Location = new Point(20, 80);
            lblEmployeeName.ForeColor = Color.White;
            lblEmployeeName.Font = new Font("Tahoma", 8.3F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeName);

            lblEmployeeSalary = new Label();
            lblEmployeeSalary.Text = "Employee Salary";
            lblEmployeeSalary.Location = new Point(20, 130);
            lblEmployeeSalary.ForeColor = Color.White;
            lblEmployeeSalary.Font = new Font("Tahoma", 8.3F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeSalary);

            lblEmployeeType = new Label();
            lblEmployeeType.Text = "Employee Type";
            lblEmployeeType.Location = new Point(20, 180);
            lblEmployeeType.ForeColor = Color.White;
            lblEmployeeType.Font = new Font("Tahoma", 8.3F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeType);

            lblEmployeeCounter = new Label();
            lblEmployeeCounter.AutoSize = true;
            lblEmployeeCounter.Font = new Font(lblEmployeeCounter.Font.Name, 16, lblEmployeeCounter.Font.Style);
            lblEmployeeCounter.Text = "Employees Count           :";
            lblEmployeeCounter.Location = new Point(20, 280);
            lblEmployeeCounter.ForeColor = Color.White;
            lblEmployeeCounter.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeCounter);

            lblEmployeeCounterInitialnumber = new Label();
            lblEmployeeCounterInitialnumber.AutoSize = true;
            lblEmployeeCounterInitialnumber.Font = new Font(lblEmployeeCounterInitialnumber.Font.Name, 16, lblEmployeeCounterInitialnumber.Font.Style);
            lblEmployeeCounterInitialnumber.Text = "0";
            lblEmployeeCounterInitialnumber.Location = new Point(300, 280);
            lblEmployeeCounterInitialnumber.ForeColor = Color.White;
            lblEmployeeCounterInitialnumber.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeCounterInitialnumber);

            lblEmployeeSalarySumInitialnumber = new Label();
            lblEmployeeSalarySumInitialnumber.AutoSize = true;
            lblEmployeeSalarySumInitialnumber.Font = new Font(lblEmployeeSalarySumInitialnumber.Font.Name, 16, lblEmployeeSalarySumInitialnumber.Font.Style);
            lblEmployeeSalarySumInitialnumber.Text = "0";
            lblEmployeeSalarySumInitialnumber.Location = new Point(300, 320);
            lblEmployeeSalarySumInitialnumber.ForeColor = Color.White;
            lblEmployeeSalarySumInitialnumber.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeSalarySumInitialnumber);

            lblEmployeeSalarySum = new Label();
            lblEmployeeSalarySum.AutoSize = true;
            lblEmployeeSalarySum.Font = new Font(lblEmployeeSalarySum.Font.Name, 16, lblEmployeeSalarySum.Font.Style);
            lblEmployeeSalarySum.Text = "Employees Salary Sum  :";
            lblEmployeeSalarySum.Location = new Point(20, 320);
            lblEmployeeSalarySum.ForeColor = Color.White;
            lblEmployeeSalarySum.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblEmployeeSalarySum);

            /////////TextBoxes formatting////////////

            txtEmployeeID = new TextBox();
            txtEmployeeID.Size = new Size(200, 20);
            txtEmployeeID.Location = new Point(150, 30);
                this.Controls.Add(txtEmployeeID);

            txtEmployeeName = new TextBox();
            txtEmployeeName.Size = new Size(200, 20);
            txtEmployeeName.Location = new Point(150, 80);
                this.Controls.Add(txtEmployeeName);

            txtEmployeeSalary = new TextBox();
            txtEmployeeSalary.Size = new Size(200, 20);
            txtEmployeeSalary.Location = new Point(150, 130);
                this.Controls.Add(txtEmployeeSalary);

            cmbEmployeeType = new ComboBox();
            cmbEmployeeType.Size = new Size(200, 20);
            cmbEmployeeType.Location = new Point(150, 180);
            cmbEmployeeType.DataSource = Enum.GetValues(typeof(employeeType));
                this.Controls.Add(cmbEmployeeType);

            //////////Buttons formatting////////////

            btnAddEmployee = new Button();
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.Size = new Size(75, 34);
            btnAddEmployee.Location = new Point(150, 220);
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.FlatStyle = FlatStyle.Popup;
            btnAddEmployee.BackColor = Color.Gray;
                this.Controls.Add(btnAddEmployee);

            btnClearTextBoxes = new Button();
            btnClearTextBoxes.Text = "Clear Form";
            btnClearTextBoxes.Size = new Size(75, 34);
            btnClearTextBoxes.Location = new Point(250, 220);
            btnClearTextBoxes.Cursor = Cursors.Hand;
            btnClearTextBoxes.FlatStyle = FlatStyle.Popup;
            btnClearTextBoxes.BackColor = Color.Gray;
            btnClearTextBoxes.Click += btnClearTextBoxes_Click;
            this.Controls.Add(btnClearTextBoxes);

            }
}
}
