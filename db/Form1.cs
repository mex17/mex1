using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace HostelManagement

{
    public class Form1 : Form
    {
        

    private string connectionString;
    private MySqlconnection connection;
        public Form1()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
         var usernameText=textBoxusername.Text;
            var passwordText=textBoxpassword.Text;
            var selectCommand=new MySqlCommand();

            selectCommand.CommandText = "select*from users where USERNAME=@USERNAMEText AND PASSWORD=@PASSWORDText";
            selectCommand.parameters.addwithvalue("@username",usernameText);
            selectCommand.parameters.addwithvalue("@PASSWORD",passwordText);
            selectCommand.connection = connection;
            MysqlDataReader dataReader= selectCommand.ExecuteReader();

            if (dataReader.Read())
{
    MessageBox.Show("login successful");
}
            else
            {
    MessageBox.Show("Invalid Username or password");
}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           var ConnectionString = "server=localhost;database=hosteldb;uid=root;Pwd=";
           var Connection = new MysqlConnection(connectionString);
            Connection.Open();
        }
    }

}
