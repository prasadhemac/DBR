using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSoftDBRestoreManager
{
    public partial class KSoftDBRestoreManager : Form
    {
        public KSoftDBRestoreManager()
        {
            InitializeComponent();
            tb_user_id.Text = "root";
            tb_server.Text = "localhost";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Restore File";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "bak";
            openFileDialog1.Filter = "Bak files (*.bak)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_user_id.Text = openFileDialog1.FileName;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrowseButton_Clicked(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Restore Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "bak";
            openFileDialog1.Filter = "BAK files (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_browse_files.Text = openFileDialog1.FileName;
            }
        }

        private void RestoreButton_Clicked(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tb_user_id.Text))
            {
                MessageBox.Show("User ID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(tb_server.Text))
            {
                MessageBox.Show("Server is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(tb_database.Text))
            {
                MessageBox.Show("Database is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(tb_browse_files.Text))
            {
                MessageBox.Show("Browse Restore Files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String restore_file = tb_browse_files.Text;
            if (!File.Exists(restore_file))
            {
                MessageBox.Show("The file don't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String user_id = tb_user_id.Text;
            String password = tb_password.Text;
            String server = tb_server.Text;
            String database = tb_database.Text;

            String connectionString = "User Id=" + user_id + ";Password=" + password + ";Server=" + server + ";Database=" + database;

            if(KSoftDbRestore.RestoreFile(connectionString, restore_file))
                MessageBox.Show("Successfully Restored", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed Attempt! Please check DB details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
