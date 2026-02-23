using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using Microsoft.VisualBasic;
using firstForm.Validation;
using Microsoft.Office.Core;

namespace firstForm
{
    public partial class Form1 : Form
    {
        string connString = @"User Id=SYSTEM;Password=123; 
                    Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))
                    (CONNECT_DATA=(SERVICE_NAME=XE)))";
        public Form1()
        {
            InitializeComponent();
            LoadVetList(); 

        }
        private BindingSource vetBinding = new BindingSource();

        private void LoadVetList()
        {
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM VET ORDER BY id_vet";
                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                vetBinding.DataSource = dt; //това е за търсачката
                gvVetList.DataSource = vetBinding;
            }
        }
        private OracleConnection GetConnection()
        {
           return new OracleConnection(connString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadVetList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        

        }

        private void btnNewVet_Click(object sender, EventArgs e)
        {
            Form addVet = new AddVet();
            addVet.ShowDialog();
            LoadVetList();

        }

        private void btnDelVet_Click(object sender, EventArgs e)
        {
            if (gvVetList.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedVet = gvVetList.SelectedRows[0];
                int idDel = Convert.ToInt32(selectedVet.Cells["id_vet"].Value);
                MessageBox.Show($"1. избрания ид е {idDel}"); 
            }
            else if (gvVetList.SelectedCells.Count > 0 )
            {
                int rowIndex = gvVetList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gvVetList.Rows[rowIndex];

                int idDel = Convert.ToInt32(selectedRow.Cells["id_vet"].Value);
                DeleteVetinDB(idDel); 
                MessageBox.Show($"2. Избраният ID е {idDel}");
                LoadVetList();

            }
            else
            {
                MessageBox.Show("Не е избран ветеринален лекар за премахване!"); 
            }
        }

        public void DeleteVetinDB(int vetId)
        {
            using (OracleConnection conn = new OracleConnection(connString))
            {
                conn.Open();

                string sql = "DELETE FROM VET WHERE id_vet = :id";
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add("id", vetId);
                    cmd.ExecuteNonQuery(); // Изпълнява SQL заявката върху базата данни

                }

                // Супер важно: commit за да стане permanent
                using (OracleCommand commitCmd = new OracleCommand("COMMIT", conn))
                {
                    commitCmd.ExecuteNonQuery();
                    //правят се перманентни проемни върху базата от данни 
                }
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gvVetList.SelectedCells.Count > 0)
            {
                int rowIndex = gvVetList.SelectedCells[0].RowIndex;
                int cellIndex = gvVetList.SelectedCells[0].ColumnIndex;

                if (cellIndex == 0) {
                    MessageBox.Show("Не може да се променя ИДЕНТИФИКАЦИОННИЯ НОМЕР на ветеринар");
                    return;
                }

                object VetID = gvVetList.Rows[rowIndex].Cells["id_vet"].Value;

                string newData = gvVetList.Rows[rowIndex].Cells[cellIndex].Value.ToString(); 
                newData = Interaction.InputBox("Моля запишете новата променлива", "Промяна на данни", newData);
                //id_vet, first_name, last_name, phone, email, education, position, percent
                
                if (string.IsNullOrEmpty(newData)) return; 

                switch (cellIndex) 
                {
                    case 1: 
                    case 2: if (!Validator.checkName(newData)); break;
                    case 3: if (!Validator.checkPhoneNumber(newData)) ; break;
                    case 4: if (!Validator.checkEmail(newData)) ; break;
                    case 5: if (!Validator.checkFill(newData, "Образование")) ; break;
                    case 6: if (!Validator.checkFill(newData, "Позиция")) ; break;
                    case 7: if (!Validator.isDigit(newData)); break; 
                }


                updateVetDB( Convert.ToInt32(VetID), cellIndex, newData);
                LoadVetList();

            }
            else
            {
                MessageBox.Show("Не е избрана клетка за променяне!");
            }
        }
       
        private void updateVetDB(int vetId, int cell, string newData)
        {
            using (OracleConnection conn = new OracleConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = "";
                    switch (cell)
                    //id_vet, first_name, last_name, phone, email, education, position, percent
                    {
                        case 1:
                            if (!Validator.checkName(newData))
                                return; 
                            sql = "UPDATE VET set first_name = :newData WHERE id_vet = :vetId";
                            break;
                        case 2:
                            if (!Validator.checkName(newData))
                                return;
                            sql = "UPDATE VET set last_name = :newData WHERE id_vet = :vetId";
                            break;
                        case 3:
                            if (!Validator.checkName(newData))
                                return; 
                            sql = "UPDATE VET set phone = :newData WHERE id_vet = :vetId";
                            break;
                        case 4:
                            if (!Validator.checkEmail(newData)) 
                                return;
                            sql = "UPDATE VET set email = :newData WHERE id_vet = :vetId";
                            break;
                        case 5:
                            if (!Validator.checkFill(newData, "Образование"))
                                return;
                            sql = "UPDATE VET set education = :newData WHERE id_vet = :vetId";
                            break;
                        case 6: if (!Validator.checkFill(newData, "Позиция"))
                                return;
                            sql = "UPDATE VET SET position = :newData WHERE id_vet = :vetId"; 
                            break;
                        case 7: if (!Validator.isDigit(newData)) 
                                return;
                            sql = "UPDATE VET SET percent =: newData where id_vet = :vetId";
                            break ;
                    }

                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add("newData", newData);
                        cmd.Parameters.Add("vetId", vetId);
                        cmd.ExecuteNonQuery();
                    }

                    // Супер важно: commit за да стане permanent
                    using (OracleCommand commitCmd = new OracleCommand("COMMIT", conn))
                    {
                        commitCmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) //търсачка
        {
            string option = cbSearchOptions.Text;
          //  MessageBox.Show(option); 
            string filter = txtSearch.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(filter))
                vetBinding.RemoveFilter(); //филтъра се премахва ако няма текст
            else
            {
                //id_vet, first_name, last_name, phone, email, education, position, percent

                switch (option)
                {
                    case "Номер на ветеринар":
                        vetBinding.Filter = $"Convert(id_vet, 'System.String') LIKE '{filter}%'";
                        break;
                    case "Име":
                        vetBinding.Filter = $"first_name LIKE '%{filter}%'";
                        break;
                    case "Фамилия":
                        vetBinding.Filter = $"last_name LIKE '%{filter}%'";
                        break;
                    case "Телефон":
                        vetBinding.Filter = $"phone LIKE '%{filter}%'"; 
                        break; 
                    case "Имейл": 
                        vetBinding.Filter = $"email LIKE '%{filter}%'"; 
                        break; 
                    case "Образование": 
                        vetBinding.Filter = $"education LIKE '%{filter}%'"; 
                        break;
                    case "Позиция":
                        vetBinding.Filter = $"position LIKE '%{filter}%'"; 
                        break;
                    case "Процент":
                        vetBinding.Filter = $"Convert(percent, 'System.String') LIKE '%{filter}%'"; 
                        break;

                }

            }

        }
    }
}
