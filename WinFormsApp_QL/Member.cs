using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_QL
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introduction introForm = new Introduction();
            introForm.ShowDialog();
        }
    }
}
