﻿using PassManager.Properties;
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

namespace PassManager
{
    public partial class fMain : Form
    {

        Boolean debug = Environment.GetCommandLineArgs()[1].Equals("dev");
        string saveFile;



        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

            fManager manager = new fManager();
            manager.Show();

            if (Settings.Default.lastOpened == "")
            {
                tbPass.Enabled = false;
            }
        }


        /// <summary>
        /// Debug console output if start argument "dev" is entered.
        /// </summary>
        /// <param name="content"></param>
        private void debugOut(string content)
        {
            if (debug)
                Console.WriteLine(content);
        }

        /// <summary>
        /// Returns path without file of file path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string getPath(string path)
        {
            return path.Replace(path.Split('\\')[path.Split('\\').Length - 1], "");
        }


        #region INTERFACE METHODS

        private void btCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PassManager Database|*.pmdb";
            sfd.ShowDialog();

            string fileName = sfd.FileName;
            if (fileName != "" && fileName != null)
            {
                saveFile = fileName;
                string savePath = getPath(fileName);
                if (!Directory.Exists(savePath))
                    Directory.CreateDirectory(savePath);

                MessageBox.Show("Database will be saved as " + saveFile + ".\n\nPlease now enter a master password for your database.", "Database created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbMasterPW.Text = "Pelase enter here new master password:";
                tbPass.Enabled = true;
                btCreate.Enabled = false;
                btOpen.Enabled = false;
                lbLastOpened.Text = saveFile;
                lbLastOpened.ForeColor = Color.LimeGreen;
                btUnlock.Text = "Create";
            }

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PassManager Database|*.pmdb";
            ofd.ShowDialog();

            string openedFile = ofd.FileName;

            if (openedFile != "" && openedFile != null)
            {
                saveFile = openedFile;
                tbPass.Enabled = true;
                btCreate.Enabled = false;
                btOpen.Enabled = false;
                lbLastOpened.Text = openedFile;
                lbLastOpened.ForeColor = Color.LimeGreen;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            btUnlock.Enabled = tbPass.Text.Length > 8;
        }


        #endregion

        private void btUnlock_Click(object sender, EventArgs e)
        {
            
        }
    }
}
