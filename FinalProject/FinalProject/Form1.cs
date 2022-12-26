
using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataintoDataGridView();
        }
        int Emp_ID;

        private void LoadDataintoDataGridView()
        {
            MySqlConnection connection = new MySqlConnection(appSetting.ConnectionString());
            connection.Open();

            MySqlCommand cmd;
            cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            MySqlDataReader sdr= cmd.ExecuteReader();
            DataTable dtrecords= new DataTable();
            dtrecords.Load(sdr);
            dataGridView1.DataSource= dtrecords;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isvalid())
            {
                MySqlConnection connection = new MySqlConnection(appSetting.ConnectionString());
                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT into Employee(Emp_Name,Emp_Phno,Emp_Depart,Emp_Type,Emp_Adress)VALUES(@Emp_Name,@Emp_Phno,@Emp_Depart,@Emp_Type,@Emp_Adress)";

                cmd.Parameters.AddWithValue("@Emp_Name", Empname.Text);
                cmd.Parameters.AddWithValue("@Emp_Phno", empphno.Text);
                cmd.Parameters.AddWithValue("@Emp_Depart", empdepart.Text);
                cmd.Parameters.AddWithValue("@Emp_Type", emptype.Text);
                cmd.Parameters.AddWithValue("@Emp_Adress", empadress.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Inserted sucessfully ");

                LoadDataintoDataGridView();

                ResetFormData();
            }


        }

        private bool isvalid()
        {
            if (Empname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("employee ID is required", "Required feild error");
                return false;
            }
            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Emp_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Emp_ID"].Value);
            Empname.Text = dataGridView1.SelectedRows[0].Cells["Emp_Name"].Value.ToString();
           empadress.Text = dataGridView1.SelectedRows[0].Cells["Emp_Adress"].Value.ToString();
            empdepart.Text = dataGridView1.SelectedRows[0].Cells["Emp_Depart"].Value.ToString();
           empphno.Text = dataGridView1.SelectedRows[0].Cells["Emp_Phno"].Value.ToString();
            emptype.Text = dataGridView1.SelectedRows[0].Cells["Emp_Type"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Emp_ID!=0)
            {
                MySqlConnection connection = new MySqlConnection(appSetting.ConnectionString());
                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE  Employee set Emp_Name=@Emp_Name,Emp_Phno=@Emp_Phno,Emp_Depart=@Emp_Depart,Emp_Type=@Emp_Type,Emp_Adress=@Emp_Adress WHERE Emp_ID=@Emp_ID";

                cmd.Parameters.AddWithValue("@Emp_Name", Empname.Text);
                cmd.Parameters.AddWithValue("@Emp_Phno", empphno.Text);
                cmd.Parameters.AddWithValue("@Emp_Depart", empdepart.Text);
                cmd.Parameters.AddWithValue("@Emp_Type", emptype.Text);
                cmd.Parameters.AddWithValue("@Emp_Adress", empadress.Text);
                cmd.Parameters.AddWithValue("@Emp_ID", this.Emp_ID);
                
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Updated sucessfully ","Sucess");
                LoadDataintoDataGridView();

                ResetFormData();
            }
            else
            {
                MessageBox.Show("please insert records if you have no records inserted ", "select records");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Emp_ID!=0) 
            {
                MySqlConnection connection = new MySqlConnection(appSetting.ConnectionString());
                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = cmd.CommandText = "DELETE FROM Employee WHERE Emp_ID=@Emp_ID";


                cmd.Parameters.AddWithValue("@Emp_ID", this.Emp_ID);

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Deleted sucessfully ", "Sucess");
                LoadDataintoDataGridView();

                ResetFormData();
            }
            else
            {
                MessageBox.Show("please insert records if you have no records inserted ", "select records");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void ResetFormData()
        {
            this.Emp_ID= 0;
            empadress.Clear();
            empdepart.Clear();
            empphno.Clear();
            Empname.Clear();
            emptype.Clear();

            Empname.Focus();
            LoadDataintoDataGridView();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (searchbox.Text.Trim() != string.Empty)
            {

                MySqlConnection connection = new MySqlConnection(appSetting.ConnectionString());
                connection.Open();

                MySqlCommand cmd;
                cmd = connection.CreateCommand();

                if (rbByName.Checked)
                {
                    cmd.CommandText = "select * from Employee where  Emp_Name=@Emp_Name";
                    cmd.Parameters.AddWithValue("@Emp_Name", searchbox.Text);

                }
                else if (rbByAdress.Checked)
                {
                    cmd.CommandText = "select * from Employee where Emp_Adress=@Emp_Adress";
                    cmd.Parameters.AddWithValue("@Emp_Adress", searchbox.Text);
                }
                else if (rbByDepart.Checked)
                {
                    cmd.CommandText = "select * from Employee where Emp_Depart=@Emp_Depart";
                    cmd.Parameters.AddWithValue("@Emp_Depart", searchbox.Text);
                }
                else if (rbByPhno.Checked)
                {
                    cmd.CommandText = "select * from Employee where Emp_Phno=@Emp_Phno";
                    cmd.Parameters.AddWithValue("@Emp_Phno", searchbox.Text);
                }
                else if (rbByType.Checked)
                {
                    cmd.CommandText = "select * from Employee where Emp_Type=@Emp_Type";
                    cmd.Parameters.AddWithValue("@Emp_Type", searchbox.Text);
                }


                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtrecords = new DataTable();
                dtrecords.Load(sdr);
                dataGridView1.DataSource = dtrecords;
                if (dtrecords.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dtrecords;
                }
                else
                {
                    MessageBox.Show("No Records Found! ");
                }
            }
            else
            {
                MessageBox.Show("Please Enter any Value to search record! ");
            }
        }

        
    }
    
}