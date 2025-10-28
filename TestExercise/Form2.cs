using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestExercise.Database;

namespace TestExercise
{
    public partial class Form2 : Form
    {
        //declaring dbstring
        private readonly string ConnectionString = DbConnect.ConnectionString;
        private int userId;
        private bool forEdit = true;
        public event EventHandler DataUpdated;
        public Form2()
        {
            InitializeComponent();
            modifyView();
            LoadGender();
        }

        public Form2(int UserId)
        {
            InitializeComponent();
            this.userId = UserId;
            LoadGender();
            modifyView();
            selectUser(this.userId);
            forEdit = false;
        }
        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            
            if (forEdit == false)
            {
                SaveEditedData(this.userId);
            }
            else if(forEdit == true)
            {
                addData();
            }
        }

        private void LoadGender()
        {
            ForGender.DropDownStyle = ComboBoxStyle.DropDownList;
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using(SqlCommand com = new SqlCommand("dbo.GetGenders",conn))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using(SqlDataReader readData = com.ExecuteReader())
                    {
                        ForGender.Items.Clear();
                        while(readData.Read())
                        {
                            ForGender.Items.Add(readData["GenderName"].ToString());
                        }
                    }
                }
            }
            ForGender.SelectedIndex = 1;
        }

        private void modifyView()
        {
            ForNumber.MaxLength = 9;
            ForPersonID.MaxLength = 11;
        }
        private void selectUser(int UserId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.GetPatientByID", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", UserId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["FullName"].ToString();
                        string[] parts = name.Split(' ');
                        ForName.Text = parts[1];
                        ForSurname.Text = parts[0];
                        DateTime date = Convert.ToDateTime(reader["Dob"]);
                        ForDate.Value = date;
                        int genderId = Convert.ToInt32(reader["GenderId"]);
                        if (genderId == 1)
                            ForGender.SelectedIndex = 0;
                        if (genderId == 2)
                            ForGender.SelectedIndex = 1;
                        ForNumber.Text = reader["Phone"].ToString().Replace("-","");
                        ForAddress.Text = reader["Address"].ToString();
                    }
                }
            }
        }
        //Db with Edit
        private void SaveEditedData(int patId)
        {
            if (!Validation())
                return;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.NewEditData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", patId);

                string formatedNumber = formatNumber(ForNumber.Text);
                cmd.Parameters.AddWithValue("@FullName", ForSurname.Text + " " + ForName.Text);
                cmd.Parameters.AddWithValue("@Dob", ForDate.Value);
                cmd.Parameters.AddWithValue("@GenderID", ForGender.SelectedIndex +1);
                cmd.Parameters.AddWithValue("@Phone", formatedNumber);
                cmd.Parameters.AddWithValue("@Address", ForAddress.Text);
                cmd.Parameters.AddWithValue("@PersonalID", ForPersonID.Text);
                cmd.Parameters.AddWithValue("@Email", ForEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("პაციენტი წარმატებით განახლდა");
            DataUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void addData()
        {
            if (!Validation())
                return;
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.NewADDPatient", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                string formatedNumber = formatNumber(ForNumber.Text);
                cmd.Parameters.AddWithValue("@FullName", ForSurname.Text + " " + ForName.Text);
                cmd.Parameters.AddWithValue("@Dob", ForDate.Value);
                cmd.Parameters.AddWithValue("@GenderID", ForGender.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@Phone", formatedNumber);
                cmd.Parameters.AddWithValue("@Address", ForAddress.Text);
                cmd.Parameters.AddWithValue("@PersonalID", ForPersonID.Text);
                cmd.Parameters.AddWithValue("@Email", ForEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("პაციენტი წარმატებით დაემატა");
            DataUpdated?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        //Format Phone Number to demanded format
        private string formatNumber(string a)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < a.Length; i++)
            {
                result.Append(a[i]);
                if ((i + 1) % 3 == 0 && i != a.Length - 1)
                {
                    result.Append('-');
                }
            }

            return result.ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private int validateData()
        {
            if (ForName.Text.ToString() == "")
                return 1;
            if (ForSurname.Text.ToString() == "")
                return 2;
            if (ForDate.Value > DateTime.Today)
                return 3;
            if (ForNumber.Text != "")
            {
                if (ForNumber.Text.Length != 9)
                    return 4;
                if (ForNumber.Text[0] != '5')
                    return 5;
            }
            if (ForPersonID.Text != "")
            {
                if (ForPersonID.Text.Length != 11)
                    return 6;
            }

            //არასრული ვალიდაცია ელექტრონული ფოსტისთვის საილუსტრაციოთ
            if(ForEmail.Text != "")
            {
                if (!ForEmail.Text.ToString().Contains("@gmail.com"))
                    return 7;
            }
                
            return 10;
        }


        private bool Validation()
        {
            int opt = validateData();
            if (opt == 1)
            {
                MessageBox.Show("გთხოვთ შეასწოროთ სახელის ველი");
                return false;
            }
            if (opt == 2)
            {
                MessageBox.Show("გთხოვთ შეასწოროთ გვარის ველი");
                return false;
            }
            if (opt == 3)
            {
                MessageBox.Show("გთხოვთ შეასწოროთ თარიღის ველი");
                return false;
            }
            if (opt == 4)
            {
                MessageBox.Show("ტელეფონის ნომერი არ უნდა აღემატებოდეს 9 სიმბოლოს");
                return false;
            }
            if (opt == 5)
            {
                MessageBox.Show("ტელეფონის ნომერი უნდა იწყებოდეს 5-იანით");
                return false;
            }
            if(opt == 6)
            {
                MessageBox.Show("პირადი ნომერი არ უნდა აღემატებოდეს 11 სიმბოლოს");
                return false;
            }
            if(opt == 7)
            {
                MessageBox.Show("ელ-ფოსტა არა არის ვალიდური(უნდა შეიცავდეს @gmail.com @mail.ru");
                return false;
            }
            return true;
        }
    }
    
}
