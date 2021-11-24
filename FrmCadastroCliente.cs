using CarRental.DAO;
using CarRental.Model;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtCodCliente.Clear();
            txtCPF.Clear();
            txtNome.Clear();
            txtDataNasc.Clear();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            if (!validaDados())
            {
                return;
            }

            //Inicia o processo de gravação no banco...
            //1o: criar a instância de um cliente:

            DateTime dataAux;
            DateTime.TryParseExact(txtDataNasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out dataAux);

            Cliente cliente = new Cliente(
                0,
                txtNome.Text,
                txtCPF.Text,
                dataAux);

            ClienteDAO cDAO = new ClienteDAO();
            if (cDAO.adicionaCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!",
                    "Cliente cadastrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btLimpar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Ops... algo deu errado",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool validaDados()
        {
            //verifica o cpf:
            if (!txtCPF.MaskFull)
            {
                MessageBox.Show("O CPF está inválido!",
                    "Verifique o CPF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtCPF.Focus();

                return false;
            }

            //verifica a data de nascimento com expressão regular e regionalização:
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

            //Passa a data na expressão regular:
            bool dataValida = regex.IsMatch(txtDataNasc.Text.Trim());

            //Segunda verificação, para o formato dd/MM/yyyy:
            DateTime dt;
            dataValida = DateTime.TryParseExact(txtDataNasc.Text, "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out dt);
            if (!dataValida)
            {
                MessageBox.Show("Data de nascimento inválida!",
                    "Verifique a data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDataNasc.Focus();
                return false;
            }


            //verifica o nome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Deve-se informar o nome do cliente!",
                    "Verifique o nome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtNome.Focus();

                return false;
            }

            //se todas as validações passarem, retorna-se "true":
            return true;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente consultaCliente = new FrmConsultaCliente(this);
            consultaCliente.MdiParent = this.MdiParent;
            consultaCliente.Show();
        }
    }
}