using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static PassManager.cCrypt;

namespace PassManager
{
    public partial class fManager : Form
    {

        public string saveFile;
        public string masterPassword = "123456";
        public byte[] IV;


        public fManager()
        {
            InitializeComponent();
        }

        private void fManager_Load(object sender, EventArgs e)
        {

        }


        private bool checkInput()
        {
            return cbAccounts.Text != "" && tbUsername.Text != "" && tbPass.Text.Length > 9;
        }

        #region INTERFACE METHODS

        private void btSave_Click(object sender, EventArgs e)
        {
            cCrypt.addAccount(cbAccounts.Text, tbUsername.Text, tbPass.Text, "", rtbNotes.Text);
            cbAccounts.Items.Add(cbAccounts.Text);
            cbAccounts.Text = "";
            tbPass.Text = "";
            tbUsername.Text = "";
            rtbNotes.Text = "";
        }

        private void cbAccounts_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = checkInput();

            if (currentDatabase != null)
            {
                Database db = currentDatabase;
                foreach (Account acc in db.accounts)
                {
                    Console.WriteLine(acc.name);
                    if (acc.name == cbAccounts.Text)
                    {
                        Console.WriteLine("TEST 2");
                        tbUsername.Text = acc.username;
                        tbPass.Text = cCrypt.getPass(acc.key);
                        rtbNotes.Text = acc.notes;
                    }
                }
            }
            
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = checkInput();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            btSave.Enabled = checkInput();
        }

        private void fManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #endregion
    }
}
