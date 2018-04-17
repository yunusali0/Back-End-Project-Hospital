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
    public partial class CheckUp : Form
    {
        private int ClickedId;
        private SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
        public CheckUp()
        {
            InitializeComponent();
            fillCheckups();
            fillOther("Doctors", cmbDoctor);
            fillOther("Pasients", cmbPasient);
            fillOther("Types", cmbType);
        }

        private void fillCheckups()
        {
            dgvCheckups.Rows.Clear();
            con.Open();
            string query = "SELECT * FROM CheckUpsView ORDER BY Expr2 DESC";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                double price = Convert.ToDouble(reader.GetDecimal(7));
                dgvCheckups.Rows.Add(reader.GetInt32(0), 
                    reader.GetString(1), 
                    reader.GetInt32(2), 
                    reader.GetString(3), 
                    reader.GetInt32(4),
                    reader.GetString(5),
                    reader.GetInt32(6),
                    (price%1>0?price:(int)price), 
                    reader.GetDateTime(8).ToString("dd.MM.yyyy"), 
                    reader.GetString(9));
            }
            con.Close();
        }

        private void fillOther(string tableName,ComboBox cmb)
        {
            con.Open();
            string query = "SELECT * FROM "+ tableName;
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmb.Items.Add(reader.GetInt32(0) + "-" + reader.GetString(1));
            }
            con.Close();
        }

        private void addCheckUp_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string doctor = cmbDoctor.Text;
            string pasient = cmbPasient.Text;
            string type = cmbType.Text;
            string price = txtPrice.Text;
            string note = rtbNote.Text;

            if (doctor == "" || pasient == "" || type == "" || price == "" || note == "")
            {
                lblError.Text = "* olan yerleri doldurun";
                return;
            }
            if (!double.TryParse(price, out double check_price))
            {
                lblError.Text = "Qiyməti düzgün yazın";
                return;
            }

            int doctorId = Convert.ToInt32(doctor.Split('-')[0]);
            int pasientId = Convert.ToInt32(pasient.Split('-')[0]);
            int typeId = Convert.ToInt32(type.Split('-')[0]);

            

            con.Open();
            string query = "INSERT INTO CheckUps([DoctorId],[PasientId],[TypeId],[Price],[Date],[Note]) VALUES("+doctorId+","+pasientId+","+typeId+","+check_price+",'"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm") +"','"+note+"')";
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            Reset();
        }

        private void dgvCheckups_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.ClickedId = Convert.ToInt32(dgvCheckups.Rows[e.RowIndex].Cells[0].Value.ToString());
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            addCheckUp.Visible = false;

            cmbDoctor.Text = dgvCheckups.Rows[e.RowIndex].Cells[2].Value.ToString()+"-"+ dgvCheckups.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbPasient.Text = dgvCheckups.Rows[e.RowIndex].Cells[4].Value.ToString() + "-" + dgvCheckups.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbType.Text = dgvCheckups.Rows[e.RowIndex].Cells[6].Value.ToString() + "-" + dgvCheckups.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrice.Text = dgvCheckups.Rows[e.RowIndex].Cells[7].Value.ToString();
            rtbNote.Text = dgvCheckups.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void Reset()
        {
            fillCheckups();
            cmbDoctor.Text = "";
            cmbPasient.Text = "";
            cmbType.Text = "";
            txtPrice.Text = "";
            rtbNote.Text = "";
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            addCheckUp.Visible = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Əminsiniz mi?", "Silme", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                con.Open();
                string query = "DELETE FROM CheckUps WHERE Id=" + this.ClickedId;
                SqlCommand command = new SqlCommand(query, con);
                int result = command.ExecuteNonQuery();
                con.Close();

                Reset();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string doctor = cmbDoctor.Text;
            string pasient = cmbPasient.Text;
            string type = cmbType.Text;
            string price = txtPrice.Text;
            string note = rtbNote.Text;

            if (doctor == "" || pasient == "" || type == "" || price == "" || note == "")
            {
                lblError.Text = "* olan yerleri doldurun";
                return;
            }
            if (!double.TryParse(price, out double check_price))
            {
                lblError.Text = "Qiyməti düzgün yazın";
                return;
            }

            int doctorId = Convert.ToInt32(doctor.Split('-')[0]);
            int pasientId = Convert.ToInt32(pasient.Split('-')[0]);
            int typeId = Convert.ToInt32(type.Split('-')[0]);

            con.Open();
            string query = "UPDATE CheckUps SET [DoctorId]=" + doctorId + ",[PasientId]=" + pasientId + ",[TypeId]=" + typeId + ",[Price]=" + check_price + ",[Note]='" + note + "' WHERE Id = "+this.ClickedId;
            SqlCommand command = new SqlCommand(query, con);
            int result = command.ExecuteNonQuery();
            con.Close();

            Reset();

        }
    }
}
