using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Controllers;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Views
{
    public partial class Atendimento : Form
    {
        private Senhas gerando_senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Atendimento()
        {
            InitializeComponent();
        }

        #region BOTÕES
   
        //botao gerar: Deve simular essa ação de gerar senha, em concorrente deve "nascer" a senha quando clicado.
        private void botao_gerar_Click(object sender, EventArgs e)
        {
            gerando_senhas.gerar();
        }

        //botao adicionar: O default deve ser nulo, até que adicionar seja clicado.
        private void botao_Adicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblNumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }
        //botao listar senhas: Deve mostrar as senhas das que não foram atendidas.
        private void botao_ListarSenhas_Click(object sender, EventArgs e)
        {
            lbx_Senhas.Items.Clear();
            gerando_senhas.FilaSenhas.ToList().ForEach(i => lbx_Senhas.Items.Add(i.dadosParciais()));
        }
        // botao chamar:  obs:não deve acontecer nada na interface. Quando o guiche chama, sai da fila geral e entra na fila do guuiche corresponde, posteriormente entrará na fila(lista) de atendimentos realizados
        private void botao_Chamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            if (!guiches.ListaGuiches[index].chamar(gerando_senhas.FilaSenhas))
                MessageBox.Show("FILA VAZIA");
                                

        }

        //Deve mostrar os atendidos correspondentes ao guiche socilitado.
        private void botao_ListarAtendimento_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            lbx_SenhasGuiche.Items.Clear();
            if (guiches.ListaGuiches[index].Atendimentos.Count>0)
               guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => lbx_SenhasGuiche.Items.Add(i.dadosCompletos()));
            else
                MessageBox.Show("ESTE GUICHÊ AINDA NÃO ATENDEU NENHUMA SENHA");
        }

        #endregion BOTÕES


        private void lblQtdeGuiche_Click(object sender, EventArgs e)
        {

        }
    }

    
}
