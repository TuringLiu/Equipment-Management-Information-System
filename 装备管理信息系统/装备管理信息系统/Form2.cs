﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 装备管理信息系统
{
    public partial class SelectionFuction : Form
    {
        public SelectionFuction()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            装备资料管理 to_zbzl = new 装备资料管理();
            to_zbzl.Show();
        }
    }
}
