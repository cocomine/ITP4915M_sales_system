﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Delivery_Page
{

        private MySqlConnection conn;
        private Account_Details acc;


    public partial class Delivery_Page : Form
    {
        public Delivery_Page()
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }
    }
}
