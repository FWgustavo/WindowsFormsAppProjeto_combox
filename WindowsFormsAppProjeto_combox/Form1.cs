using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProjeto_combox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // adiciona itebs no combobox
            cboLista.Items.Add(txtTexto.Text);

            //exibe a quantidade de itens do combobox
            lblQtde.Text = cboLista.Items.Count.ToString();

            //limpa a caixa de texto
            txtTexto.Clear();

            //move o foco para caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Ativar propriedade para ordenar a lista no combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);

                //exibe a quantidade de itens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();

                //limpa o texto
                cboLista.ResetText(); 
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if(cboLista.SelectedIndex != -1)
            {
                //exibe um conteudo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //exibe o indice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
