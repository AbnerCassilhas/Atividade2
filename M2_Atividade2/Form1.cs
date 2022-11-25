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
    public partial class Form1 : Form
    {
        Cad_Funcionario cad_funcionario = new Cad_Funcionario(); // Instância da Clasee

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Salvar o Cadastro
            cad_funcionario.setCodigo(int.Parse(txtCodigo.Text));
            cad_funcionario.setNome(txtNome.Text);
            cad_funcionario.setRg(txtRg.Text);
            cad_funcionario.setOrgao_exp(txtOrgao.Text);
            cad_funcionario.setCpf(txtCpf.Text);
            cad_funcionario.setCtps(txtCtps.Text);
        
        }




    }
}

