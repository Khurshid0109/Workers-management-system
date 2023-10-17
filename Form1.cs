using Dapper;
using DapperDemo.Models;
using System.Data.SqlClient;

namespace DapperDemo
{

    public partial class Form1 : Form
    {
        //Here is my connection with database
        SqlConnection con = new SqlConnection("data source=DESKTOP-2QS8IAF\\SQLEXPRESS02;database=Workers;integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        //Get all data
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            IEnumerable<Workers> workers = con.Query<Workers>("SELECT * FROM Employee;");
            con.Close();
            dataGridView1.DataSource = workers;
        }

        //Get data by Id
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //for getting the id of employee
                var x = int.Parse(textBox1.Text);

                if (EmployeeExists(x))
                {
                    con.Open();
                    IEnumerable<Workers> workers = con.Query<Workers>("SELECT * FROM Employee  WHERE Id=@id;", new { id = x });

                    con.Close();

                    dataGridView1.DataSource = workers;
                }
                else
                    MessageBox.Show("I can not find employee with the given Id !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please,clear input and then enter Id!", ex.Message);
            }
        }

        //insert data
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var name = textBox2.Text;
                var age = int.Parse(textBox3.Text);
                var address = textBox8.Text;

                con.Open();
                IEnumerable<Workers> workers = con.Query<Workers>("INSERT INTO Employee(Name,Age,Address,SALARY,MARRIED) OUTPUT INSERTED.*  VALUES(@NAME,@AGE,@ADDRESS,250,'0');",
                    new { NAME = name, AGE = age, ADDRESS = address });

                con.Close();

                dataGridView1.DataSource = workers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please,clear input and then enter Id!", ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Delete data by id
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(textBox4.Text);
                if (EmployeeExists(id))
                {
                    con.Open();

                    con.Query<Workers>("DELETE TOP(1) FROM Employee WHERE Id=@ID ", new { ID = id });
                    con.Close();
                    MessageBox.Show("Data deleted succesfully!");
                }
                else
                    MessageBox.Show("I can not find employee with the given Id !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please,clear input and then enter Id!", ex.Message);
            }
        }

        //Update data with the given information
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(textBox5.Text);
                var name = textBox6.Text;
                var age = int.Parse(textBox7.Text);

                if (EmployeeExists(id))
                {
                    con.Open();
                    IEnumerable<Workers> workers = con.Query<Workers>("UPDATE Employee SET Name = @NAME, Age = @AGE OUTPUT INSERTED.*  WHERE Id= @ID;",
                        new { NAME = name, AGE = age, ID = id });

                    con.Close();

                    dataGridView1.DataSource = workers;
                }
                else
                    MessageBox.Show("I can not find employee with the given Id !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please,clear input and then enter Id!", ex.Message);
            }
        }

        //Method for checking employee with the given is exist or not
        public bool EmployeeExists(int id)
        {
            con.Open();
            string sqlCheckEmployeeExists = "SELECT TOP 1 1 FROM Employee WHERE ID = @EmployeeId";
            var result = con.QueryFirstOrDefault<bool>(sqlCheckEmployeeExists, new { EmployeeId = id });
            con.Close();
            return result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}