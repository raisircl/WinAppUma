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

namespace WinAppUma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        SqlDataAdapter da = new SqlDataAdapter();

        DataSet ds = new DataSet();
        private void Form2_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=.\sqlexpress; Initial Catalog=dbuma;Integrated Security=true";
            fetchdata();
        }
        void fetchdata()
        {
            ds.Tables.Clear();
            comm.CommandText = "select * from tblDept";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            da.SelectCommand = comm;
            da.Fill(ds, "dept");
            dgv1.DataSource = ds.Tables["dept"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comm.CommandText = "insert into tbldept values(@dname,@loc)";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dname", txtDName.Text);
            comm.Parameters.AddWithValue("@loc", txtLoc.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            comm.Parameters.Clear();
            fetchdata();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            comm.CommandText = "update tbldept set dname=@dname,loc=@loc where dno=@dno";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@dname", txtDName.Text);
            comm.Parameters.AddWithValue("@loc", txtLoc.Text);
            comm.Parameters.AddWithValue("@dno", txtDNo.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            comm.Parameters.Clear();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comm.CommandText = "delete from tbldept where dno=@dno";
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
          
            comm.Parameters.AddWithValue("@dno", txtDNo.Text);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            comm.Parameters.Clear();
            fetchdata();
        }
    }
}
