using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar um novo formuário (em uma instância local) de cadastro de clientes
            Form frmCliente = new FrmCadastroCliente();

            //Definir o parent (pai) MDI dela:
            frmCliente.MdiParent = this;

            //abre o form...:
            frmCliente.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
