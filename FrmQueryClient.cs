using CarRental.DAO;
using CarRental.Model;
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
    public partial class FrmConsultaCliente : Form
    {
        FrmCadastroCliente frmCadastroCliente;
        public FrmConsultaCliente(FrmCadastroCliente frmCadastro)
        {
            InitializeComponent();
            this.frmCadastroCliente = frmCadastro;
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO cDAO = new ClienteDAO();
            List<Cliente> clientes = cDAO.GetClientes();
            dgvClientes.DataSource = clientes;

            dgvClientes.Columns[0].HeaderCell.Value = "Cód. do Cliente";
            dgvClientes.Columns[1].HeaderCell.Value = "Nome";
            dgvClientes.Columns[2].HeaderCell.Value = "CPF";
            dgvClientes.Columns[3].HeaderCell.Value = "Dt. de Nascimento";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            //id_cliente, cpf, nome, data_nasc
            cliente.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);
            cliente.Nome = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            cliente.Cpf = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            cliente.Data_Nasc = Convert.ToDateTime(dgvClientes.CurrentRow.Cells[3].Value);

            frmCadastroCliente.txtCodCliente.Text = cliente.IdCliente.ToString();
            frmCadastroCliente.txtCPF.Text = cliente.Cpf;
            frmCadastroCliente.txtDataNasc.Text = cliente.Data_Nasc.ToString();
            frmCadastroCliente.txtNome.Text = cliente.Nome;

            this.Close();
            //PARAMOS AQUI. TESTAR MAIS.
        }
    }
}