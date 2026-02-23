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
using System.Runtime.InteropServices.WindowsRuntime;



namespace firstForm
{
    public partial class SPECIES : Form
    {
        string connString = @"User Id=SYSTEM;Password=123; 
                    Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))
                    (CONNECT_DATA=(SERVICE_NAME=XE)))";
        public SPECIES()
        {
            InitializeComponent();
            LoadSpeciesList();
            LoadBreedsList();
            LoadSpeciesComboBox(cbSpecies);


            //това е за това избирането на ИД на species 
            gvSpecies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvSpecies.MultiSelect = false;
        }

        private void LoadSpeciesList()
        {
            try
            {
                using (OracleConnection conn = GetConnection())
                {
                    conn.Open();
                    // Command вместо DataAdapter
                    string query = @"SELECT * FROM SPECIES";
                    OracleCommand cmd = new OracleCommand(query, conn);

                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader); // По-директен начин за зареждане [web:30]

                    reader.Close();

                    gvSpecies.DataSource = dt;

                    // Настройка на DataGridView
                    gvSpecies.AutoGenerateColumns = true;
                    foreach (DataGridViewColumn col in gvSpecies.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}\nStack: {ex.StackTrace}");
            }
        }
        private void LoadBreedsList()
        {
            try
            {
                using (OracleConnection conn = GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT * FROM breed";
                    OracleCommand cmd = new OracleCommand(query, conn);

                    OracleDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader); // По-директен начин за зареждане [web:30]

                    reader.Close();

                    gvBreed.DataSource = dt;

                    // Настройка на DataGridView
                    gvBreed.AutoGenerateColumns = true;
                    foreach (DataGridViewColumn col in gvBreed.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}\nStack: {ex.StackTrace}");
            }
        }
        private OracleConnection GetConnection()
        {
            return new OracleConnection(connString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void SPECIES_Load(object sender, EventArgs e)
        {
          
        }
        private string showBreed()
        {
            try
            {
                if (gvSpecies.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedSpecies = gvSpecies.SelectedRows[0];
                    string id_species = selectedSpecies.Cells["id_species"].Value.ToString();
                    return id_species;
                }
                else
                {
                    return "Няма избрана порода.";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void btnSaveSpecies_Click(object sender, EventArgs e)
        {
            //addSpecies();
        }
        private void addSpecies()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();

                    string name = tbNameSpecies.Text;
                    double price = double.Parse(tbPriceSpecies.Text);

                    /*foreach (DataGridViewRow row in gvSpecies.Rows)
                    {
                        if (row.IsNewRow) continue; // пропуска празния ред

                        name = row.Cells[1].Value?.ToString();
                        price = double.Parse(row.Cells[2].Value?.ToString());
                    }*/

                    if (checkDublication(name))
                    {
                        string sql = @"INSERT INTO SPECIES VALUES (SPECIES_SEQ.NEXTVAL, :name, :price)";
                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(":name", name);
                            cmd.Parameters.Add(":price", price);

                            cmd.ExecuteNonQuery();
                        }
                        lbInformation.Text = $"Успешно е добавен \"Вид животно\" - {name}";

                        //тука рефреш 
                        LoadSpeciesList();

                        using (OracleCommand commitCmd = new OracleCommand("COMMIT", conn))
                        {
                            commitCmd.ExecuteNonQuery();
                        }
                    }



                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool checkDublication(string name)
        {
            foreach (DataGridViewRow row in gvSpecies.Rows)
            {
                if (row.Cells[1].Value?.ToString() == name)
                {
                    MessageBox.Show($"{name} съществува в базата данни.");
                    return false;
                }
            }
            foreach (DataGridViewRow row in gvSpecies.Rows)
            {
                if (row.Cells[1].Value?.ToString() == name)
                {
                    MessageBox.Show($"{name} съществува в базата данни.");
                    return false;
                }
            }
            return true;
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Породата е " + showBreed());

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btmAddSpecies_Click(object sender, EventArgs e)
        {
            //Add Species
            addSpecies();
        }

        private void LoadSpeciesComboBox(ComboBox comboBox)
        {
            try
            {
                string sql = @"SELECT ID_SPECIES, SPECIES FROM SPECIES ORDER BY ID_SPECIES";
                using (OracleConnection conn = GetConnection())
                {
                    OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);  // По-стабилно!


                    comboBox.DataSource = null;
                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "SPECIES";
                    comboBox.ValueMember = "ID_SPECIES";
                }
            }
            catch (Exception e )
            {
                MessageBox.Show(e.Message);
            }
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            //add Breed
            if (cbSpecies.SelectedIndex >=0 && cbSpecies.SelectedValue != null)
            {
                /*Какво искаш	Код
                ID (скрито число)	int id = (int)cbSpecies.SelectedValue;
                Име (видимо)	string name = cbSpecies.Text;
                Позиция	int index = cbSpecies.SelectedIndex;*/
                //decimal speciesID = (decimal)cbSpecies.SelectedValue;
                int speciesID = Convert.ToInt32(cbSpecies.SelectedValue);
                string speciesName = cbSpecies.Text;

                addNewBreed(speciesID.ToString(), tbNameBreed.Text, double.Parse(tbPercentBreed.Text)); 
            }
            else
                MessageBox.Show($"nyama poroda");

        }

        private void addNewBreed(string idSpecies, string name, double price)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();

                    string idBreed = generateIDforBreed(idSpecies);
                    string breedName = tbNameBreed.Text;
                    double breedPercent = double.Parse(tbPercentBreed.Text);

                    if (checkDublication(breedName))
                    {
                        string sql = @"INSERT INTO BREED VALUES (:id_breed, :breed, :percent, :id_species)";
                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            cmd.Parameters.Add(":id_breed", idBreed);
                            cmd.Parameters.Add(":breed", breedName);
                            cmd.Parameters.Add(":percent", breedPercent);
                            cmd.Parameters.Add("id_species", idSpecies ); 

                            cmd.ExecuteNonQuery();
                        }
                        

                        lbInformation.Text = $"Успешно е добавен \"Порода\" - {breedName}";

                        //тука рефреш 
                        LoadBreedsList();

                        using (OracleCommand commitCmd = new OracleCommand("COMMIT", conn))
                        {
                            commitCmd.ExecuteNonQuery();
                        }
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string generateIDforBreed(string id_species)
        {
            string idBreed = "";

            try
            {
                using (OracleConnection conn = new OracleConnection(connString))
                {
                    conn.Open();
                    int count = 0; 
                    string sql = @"SELECT COUNT(ID_SPECIES) 
                                    FROM BREED 
                                    WHERE ID_SPECIES = :id_species"; 
                    using (OracleCommand cmd = new OracleCommand(sql, conn))
                    {
                        cmd.Parameters.Add(":id_species", OracleDbType.Int32).Value = id_species;
                        count = Convert.ToInt32(cmd.ExecuteScalar()) +1; 
                        // cmd.ExecuteNonQuery(); - for INSERT, DELETE, UPDATE
                    }

                    string idHead = (Convert.ToInt32(id_species) < 10) ?  id_species  + "00": id_species+"0";
                    idBreed = (count < 10) ? idBreed = idHead + "0"+ count : idBreed = idHead+ "" + count;

                   // MessageBox.Show(idBreed + "tova e generiranoto id "); 


                    conn.Close(); 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            } 

            return idBreed; 
        }
    }
}
