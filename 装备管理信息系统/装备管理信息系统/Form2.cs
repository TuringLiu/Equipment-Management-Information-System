﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 装备管理信息系统.Z装备库存管理模块;

namespace 装备管理信息系统
{
    public partial class SelectionFuction : Form
    {
        public SelectionFuction()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new 装备库存管理总界面().Show();
        }
    }
}
