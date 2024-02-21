using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Veiculos[] veiculosArray;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
            veiculosArray = Veiculos.GetArray(); 
            bindingSource = new BindingSource();
            bindingSource.DataSource = veiculosArray;
            data_GridView.DataSource = bindingSource;
            cboVeiculos.DataSource = veiculosArray;
            cboVeiculos.Text = "[Selecione]";

        }

        private void InitializeFormsArray()
        {
            Form1[] formsArray = new Form1[3];

            for (int i = 0; i < formsArray.Length; i++)
            {
                formsArray[i] = new Form1(); // Cria uma nova instância de Form1

                formsArray[i].Text = "Formulário " + (i + 1); // Define o título do formulário

                formsArray[i].Show(); // Apresenta o formulário
            }
        }

        private void cboVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e) // Data Grid View
        {
            data_GridView.AutoGenerateColumns = true;
            data_GridView.DataSource = veiculosArray; // Inicializa o array de formulários
        }

        private void txtResultado_Click(object sender, EventArgs e) // BOTÃO OK
        {
            txtResultado.Text = "A opção selecionada é - " + ((Veiculos)cboVeiculos.SelectedItem).Nome;
        }


    }

}
