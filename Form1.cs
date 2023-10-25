using System.Data;
namespace WinAppUma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); // dataset is collection of tables (DataTable) in xml form
        DataTable dt = new DataTable("dept"); // DataTable is collection of Rows(DatRow) and Cols(DataColoumn)
        DataColumn dc1 = new DataColumn("DNo");
        DataColumn dc2 = new DataColumn("DName");
        DataColumn dc3 = new DataColumn("Loc");

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            ds.Tables.Add(dt);
            dgv1.DataSource = ds.Tables["dept"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["dept"].NewRow();
            dr["DNo"] = txtDNo.Text;
            dr["DName"]=txtDName.Text;
            dr["Loc"] = txtLoc.Text;
            ds.Tables["dept"].Rows.Add(dr);
            reset();

        }
        void reset()
        {
            txtDNo.Text = "";
            txtDName.Text = "";
            txtLoc.Text = "";
            txtDNo.Focus();
        }
    }
}