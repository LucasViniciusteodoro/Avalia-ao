using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Atividade
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
            private void FrmCliente_Load(object sender, EventArgs e)
            {
                Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            

            private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                    row.Selected = true;
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtNome.Text = row.Cells[1].Value.ToString();
                    txtCpf.Text = row.Cells[2].Value.ToString();
                    txtDataNascimento.Text = row.Cells[3].Value.ToString();
                    txtCelular.Text = row.Cells[4].Value.ToString();
                }
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        
            {
                try
                {
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    Cliente cliente = new Cliente();
                    cliente.Excluir(Id);
                    MessageBox.Show("Cliente excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Cliente> clientes = cliente.listacliente();
                    dgvCliente.DataSource = clientes;
                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    txtDataNascimento.Text = "";
                    txtCelular.Text = "";
                    this.txtNome.Focus();
                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Cliente cliente = new Cliente();
                cliente.Atualizar(Id, txtNome.Text, txtCpf.Text, txtDataNascimento.Text, txtCelular.Text);
                MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> clientes = cliente.listacliente();
                dgvCliente.DataSource = clientes;
                txtId.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                txtDataNascimento.Text = "";
                txtCelular.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtCpf.Text == "" && txtDataNascimento.Text == "" && txtCelular.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o formulário!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNome.Focus();
                }
                else
                {
                    Cliente cliente = new Cliente();
                    if (cliente.RegistroRepetido(txtNome.Text, txtCpf.Text, txtCelular.Text) != false)
                    {
                        MessageBox.Show("Este cliente já existe em nossa base de dados!", "Cliente Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Text = "";
                        txtCpf.Text = "";
                        txtDataNascimento.Text = "";
                        txtCelular.Text = "";
                        this.txtNome.Focus();

                    }
                    else
                    {
                        cliente.Inserir(txtNome.Text, txtCpf.Text, txtDataNascimento.Text, txtCelular.Text);
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Cliente> clientes = cliente.listacliente();
                        dgvCliente.DataSource = clientes;
                        txtNome.Text = "";
                        lblCpf.Text = "";
                        txtDataNascimento.Text = "";
                        txtCelular.Text = "";
                        this.txtNome.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Por favor digite um ID!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtId.Focus();
                }
                else
                {
                    int Id = Convert.ToInt32(txtId.Text.Trim());
                    Cliente cliente = new Cliente();
                    cliente.Localizar(Id);
                    txtNome.Text = cliente.nome;
                    txtCpf.Text = cliente.cpf;
                    txtDataNascimento.Text = cliente.data_nascimento;
                    txtCelular.Text = cliente.celular;
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
        }

        private void FrmCliente_Load_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> clientes = cliente.listacliente();
            dgvCliente.DataSource = clientes;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
    }

