﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace new_inspection
{
    public partial class frmSetting : Form
    {
        INSP_recipe insp_Recipe = new INSP_recipe();
        public frmSetting()
        {
            InitializeComponent();
        }
        private void frmSetting_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = INSP_recipe.code_list;
        }
        private void btn_do_Click(object sender, EventArgs e)
        {
            insp_Recipe.set_Do("O", dataGridView1.CurrentCell.RowIndex);
            //insp_Recipe.Page_Load();

            dataGridView1.DataSource = INSP_recipe.code_list;
            dataGridView1.Refresh();
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            insp_Recipe.set_Do("X", dataGridView1.CurrentCell.RowIndex);
            //insp_Recipe.Page_Load();

            dataGridView1.DataSource = INSP_recipe.code_list;
            dataGridView1.Refresh();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            frmAccount Accountset = new frmAccount();
            Accountset.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sPath = @"D:\new_ins\recipe.xlsx";//檔案位置///D:\inspectionBackup
            Process.Start(sPath);
        }

    }
}
