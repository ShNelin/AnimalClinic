using firstForm.Validation;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace firstForm
{
    public partial class AddVet : Form
    {
        private const string connString = @"User Id=SYSTEM;Password=123; 
                    Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))
                    (CONNECT_DATA=(SERVICE_NAME=XE)))";
        public AddVet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddVetToDB();
            

        }

        private void AddVetToDB() 
        {
            try
            {
                //Валидиране
                if (!Validator.checkName(tbName.Text)) ;
                if (!Validator.checkName(tbLastName.Text)) ;
                if (!Validator.checkEmail(tbEmail.Text)) ;
                if (!Validator.checkPhoneNumber(tbPhone.Text)) ;
                if (!Validator.checkFill(tbEducation.Text, "Образование")) return;
                if (!Validator.isDigit(tbPercent.Text)) return;
                if (!Validator.checkFill(tbPosition.Text, "Позиция")) return;
               

                //свързване с Оракъл и записване на данни 
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO VET (id_vet, first_name, last_name, phone, email, education, position, percent)
                       VALUES (VET_SEQ.NEXTVAL, :first, :last, :phone, :email, :education, :position, :percent)";
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        // Параметри, за да не правим SQL Injection
                        cmd.Parameters.Add("first", tbName.Text);
                        cmd.Parameters.Add("last", tbLastName.Text);
                        cmd.Parameters.Add("phone", tbPhone.Text);
                        cmd.Parameters.Add("email", tbEmail.Text);
                        cmd.Parameters.Add("education", tbEducation.Text);
                        cmd.Parameters.Add("position", tbPosition.Text);
                        cmd.Parameters.Add("percent", tbPercent.Text);

                       cmd.ExecuteNonQuery(); // Изпълняваме INSERT
                    }

                    // Супер важно: commit за да стане permanent
                    using (OracleCommand commitCmd = new OracleCommand("COMMIT", conn))
                    {
                        commitCmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                MessageBox.Show($"Успешно е добавен д-р {tbName.Text} {tbLastName.Text}!");
                tbName.Text = "";
                tbLastName.Text = ""; 
                tbEmail.Text=""; 
                tbPhone.Text =""; 
                tbEducation.Text=""; 
                tbPercent.Text=""; 
                tbPosition.Text =""; 

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }

        }

        
       
    }
}
