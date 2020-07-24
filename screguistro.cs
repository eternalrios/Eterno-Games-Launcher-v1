using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace alexander
{
    public partial class screguistro : Form
    {
        public screguistro()
        {
            InitializeComponent();
        }
        // aceptar start registrer
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cancelar registrer
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
