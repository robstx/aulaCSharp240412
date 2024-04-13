using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojaABC
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        public void desabilitaCampos()
        {
            rdbCodigo.Enabled = false;
            rdbNome.Enabled = false;
        

        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false || rdbNome.Checked == false )
            {
                MessageBox.Show("escolha algum item");
            }
            else
            {

          
            if (rdbCodigo.Checked)
            {
                if (txtDescricao.Equals(""))
                {
                    MessageBox.Show("Não Posso Pesquisar");
                } else
                {
                    //busca codigo
                }
            }
            if (rdbNome.Checked)
            {
                if (txtDescricao.Equals(""))
                {
                    MessageBox.Show("Não Posso Pesquisar");
                }
                else
                {
                    //busca nome
                }
            }
            }
    
            
        }

    }
}
