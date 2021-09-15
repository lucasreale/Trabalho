using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login();
            f_Login.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            F_Shop f_shop = new F_Shop();
            f_shop.ShowDialog();
        }

        private void btn_conta_Click(object sender, EventArgs e)
        {
            F_conta f_conta = new F_conta();
            f_conta.ShowDialog();
        }
