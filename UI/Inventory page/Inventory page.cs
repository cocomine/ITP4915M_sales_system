﻿using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Inventory_page
{

    public partial class Inventory_page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        private Form activeForm = null;

        public Inventory_page(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;

            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e) {
            openChildForm(new Inventory_quantity());
        }

        private void itemRequestedToolStripMenuItem_Click(object sender, EventArgs e) {
            openChildForm(new Item_requested());
        }

        private void purchaseItemToolStripMenuItem_Click(object sender, EventArgs e) {
            openChildForm(new Purchase_item());
        }

        private void Inventory_page_Load(object sender, EventArgs e) {
            Program.addPage();
        }

        private void Inventory_page_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        //打開子示窗
        private void openChildForm(Form form) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pl_childForm.Controls.Add(form);
            pl_childForm.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
