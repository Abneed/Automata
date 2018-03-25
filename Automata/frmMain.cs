using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automata
{
    public partial class frmMain : Form
    {
        private frmAcercaDe InfoForm = new frmAcercaDe();

        public frmMain()
        {
            InitializeComponent();
        }

        private void acecaDeAutomataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InfoForm.IsDisposed)
                InfoForm = new frmAcercaDe();

            InfoForm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void abrirTablaDeTransicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
