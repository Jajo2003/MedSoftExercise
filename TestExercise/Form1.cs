using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestExercise.Database;

namespace TestExercise
{
    public partial class Form1 : Form
    {
        //declaring dbstring
        private readonly string ConnectionString = DbConnect.ConnectionString;
        public Form1()
        {
            InitializeComponent();
            modifyView();
            LoadData();
        }

        //Open Add Panel
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 addForm = new Form2();
            addForm.DataUpdated += (s, ev) => LoadData();
            addForm.Show();
        }

        // Edit Button
        private void EditBtn_Click(object sender, EventArgs e)
        {
            int patient = GetPatientId();
            Form2 editForm = new Form2(patient);
            editForm.DataUpdated += (s, ev) => LoadData();
            editForm.Show();
        }
        //Load starting data
        private void LoadData()
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.NewGetData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "პაციენტის გვარი სახელი";
                    dataGridView1.Columns[2].HeaderText = "დაბ თარიღი";
                    dataGridView1.Columns[3].HeaderText = "სქესი";
                    dataGridView1.Columns[4].HeaderText = "მობ ნომერი";
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns[5].HeaderText = "მისამართი";
                    dataGridView1.Columns[6].HeaderText = "პირადი ნომერი";
                    dataGridView1.Columns[7].HeaderText = "ელ-ფოსტა";
                }
            }
        }
        //DeleteProccess
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int patient = GetPatientId();
            if (patient == -1)
                MessageBox.Show("გთხოვთ აირჩიოთ შესაბამისი პაციენტი");
            DialogResult result = MessageBox.Show
            (
            "გსურთ მონიშნული ჩანაწერის წაშლა?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if(result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand dlt = new SqlCommand("dbo.NewDeletePatient", conn))
                {
                    conn.Open();
                    dlt.CommandType = CommandType.StoredProcedure;
                    dlt.Parameters.AddWithValue("@ID", patient);
                    dlt.ExecuteNonQuery();
                }

                MessageBox.Show("პაციენტი წარმატებით წაიშალა");
                LoadData();
            }
        }
        //ModifyStartingView
        private void modifyView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        //Check Selection
        private int GetPatientId()
        {
            if (dataGridView1.CurrentRow == null)
                return -1;
            return Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
        }
    }
}

