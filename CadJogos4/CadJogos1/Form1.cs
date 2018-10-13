using Biblioteca.DAO;
using Biblioteca.Vos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadJogos1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JogoVO j = new JogoVO();
                //j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(cbcategorias.SelectedValue);
                j.Data = Convert.ToDateTime(txtData.Text);

                JogoDAO.Incluir(j);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                JogoVO j = new JogoVO();
                j.Id = Convert.ToInt32(txtId.Text);
                j.Descricao = txtDescricao.Text;
                j.valor = Convert.ToDouble(txtPreco.Text);
                j.CategoriaId = Convert.ToInt32(cbcategorias.SelectedValue);
                j.Data = Convert.ToDateTime(txtData.Text);

                JogoDAO.Alterar(j);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                JogoDAO.Excluir(Convert.ToInt32(txtId.Text));
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Primeiro();
            PreencheTela(j);
        }

        private void PreencheTela(JogoVO j)
        {
            if (j != null)
            {
                txtId.Text = j.Id.ToString();
                txtDescricao.Text = j.Descricao;
                cbcategorias.SelectedValue = j.CategoriaId;
                txtData.Text = j.Data.ToShortDateString();
                txtPreco.Text = j.valor.ToString();

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Anterior( Convert.ToInt32(txtId.Text));
            PreencheTela(j);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Proximo(Convert.ToInt32(txtId.Text));
            PreencheTela(j);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            JogoVO j = JogoDAO.Ultimo();
            PreencheTela(j);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPrimeiro.PerformClick();

            cbcategorias.DataSource = categoriasDAO.ListaCategorias();
            cbcategorias.DisplayMember = "descricao";
            cbcategorias.ValueMember = "id";


            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
