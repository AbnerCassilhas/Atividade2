using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2_Atividade2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 cadastroFuncionario = new Form1(); //Instância do objeto editor - Form2
            cadastroFuncionario.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            cadastroFuncionario.Text = "Cadastro de Funcionário";
            cadastroFuncionario.Show();
        }
    }
}
