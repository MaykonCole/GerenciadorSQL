using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaykonSoft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ParametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form3 frm = new Form3();
            frm.TopLevel = false;
            frm.Visible = true;
            painel.Controls.Add(frm);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
