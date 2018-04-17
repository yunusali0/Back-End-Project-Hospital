using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace csharp_15
{
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        private int ClickedId;
        public Doctor()
        {
            InitializeComponent();
            fillDepartment();
            fillDoctors();
        }

        private void fillDoctors()
        {
            dgvDoctors.Rows.Clear();
            con.Open();
            string query = "SELECT dtr.Id,dtr.Name,dpt.Name as Department,dtr.Position,dpt.Id FROM Doctors dtr INNER JOIN Departments dpt ON dtr.DepartmentId = dpt.Id";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvDoctors.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(4)+"-"+reader.GetString(2), reader.GetString(3));
            }
            con.Close();
        }
        private void fillDepartment()
        {
            con.Open();

            string query = "SELECT * FROM Departments";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbDepartment.Items.Add(reader.GetInt32(0)+"-"+reader.GetString(1));
            }
            con.Close();
        }

        private  void reset()
        {
            txtFullname.Text = "";
            txtPosition.Text = "";
            cmbDepartment.Text = "";
            fillDoctors();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
        }
        private void dgvDoctors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ClickedId = Convert.ToInt32(dgvDoctors.Rows[e.RowIndex].Cells[0].Value.ToString());

            txtFullname.Text = dgvDoctors.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbDepartment.Text = dgvDoctors.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPosition.Text = dgvDoctors.Rows[e.RowIndex].Cells[3].Value.ToString();

            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnAdd.Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string fullname = txtFullname.Text;
            string position = txtPosition.Text;
            string department = cmbDepartment.Text;

            if (fullname == "" || position == "" || department == "")
            {
                lblError.Text = "* olan yerleri doldurun";
                return;
            }
            int depId = Convert.ToInt32(department.Split('-')[0]);
            con.Open();
            string query = "INSERT INTO Doctors([Name],[DepartmentId],[Position]) VALUES('" + fullname + "'," + depId + ",'" + position + "')";
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            reset();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi?", "Silinme", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                con.Open();
                string query = "DELETE FROM Doctors WHERE Id=" + this.ClickedId;
                SqlCommand command = new SqlCommand(query, con);
                int result = command.ExecuteNonQuery();
                con.Close();

                reset();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string fullname = txtFullname.Text;
            string position = txtPosition.Text;
            string department = cmbDepartment.Text;

            if (fullname == "" || position == "" || department == "")
            {
                lblError.Text = "* olan yerleri doldurun";
                return;
            }
            int depId = Convert.ToInt32(department.Split('-')[0]);

            con.Open();
            string query = "UPDATE Doctors SET [Name]='"+fullname+"',[DepartmentId]="+depId+",[Position] = '"+position+"' WHERE Id="+this.ClickedId;
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();
            con.Close();
            reset();
        }
    }
}
