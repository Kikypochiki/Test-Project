using System.Data;
using MySql.Data.MySqlClient;
using TestProject.testProjectClasses;
namespace TestProject
{
    public partial class TestProject : Form
    {
        public TestProject()
        {
            InitializeComponent();
        }
        Info I = new Info();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = I.Select();
            dgv_listOfPeople.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_click(object sender, EventArgs e)
        {
            I.Name = txtbx_name.Text;
            I.DateOfBirth = txtbx_dateOfBirth.Text;
            I.Address = txtbx_address.Text;
            I.Gender = cb_gender.Text;

            bool success = I.Insert(I);
            if (success == true)
            {
                MessageBox.Show("New record successfully inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to insert new record");
            }
            DataTable dt = I.Select();
            dgv_listOfPeople.DataSource = dt;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            I.id = int.Parse(txtbx_id.Text);
            I.Name = txtbx_name.Text;
            I.DateOfBirth = txtbx_dateOfBirth.Text;
            I.Address = txtbx_address.Text;
            I.Gender = cb_gender.Text;

            bool success = I.EDIT(I);
            if (success == true)
            {
                MessageBox.Show("Record successfully updated");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update record");
            }
            DataTable dt = I.Select();
            dgv_listOfPeople.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void close_app_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listOfPeople_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtbx_id.Text = dgv_listOfPeople.Rows[rowIndex].Cells[0].Value.ToString();
            txtbx_name.Text = dgv_listOfPeople.Rows[rowIndex].Cells[1].Value.ToString();
            txtbx_dateOfBirth.Text = dgv_listOfPeople.Rows[rowIndex].Cells[2].Value.ToString();
            txtbx_address.Text = dgv_listOfPeople.Rows[rowIndex].Cells[3].Value.ToString();
            cb_gender.Text = dgv_listOfPeople.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void Clear()
        {
            txtbx_id.Text = "";
            txtbx_name.Text = "";
            txtbx_dateOfBirth.Text = "";
            txtbx_address.Text = "";
            cb_gender.Text = "";
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbx_id_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            I.id = Convert.ToInt32(txtbx_id.Text);
            bool success = I.Delete(I);
            if (success == true)
            {
                MessageBox.Show("Record successfully deleted");
                DataTable dt = I.Select();
                dgv_listOfPeople.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete record");
            }
        }
    }
}
