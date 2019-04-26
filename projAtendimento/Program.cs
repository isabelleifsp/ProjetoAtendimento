using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Views;

namespace ProjetoAtendimento
{
    static class Program
    {
        /*Características do programa
        *DUAS MODEL E DUAS CONTROL
        *FUNCIONALIDADE DO NEGÓCIO: SER UM GERADOR DE SENHA DE ATENDIMENTO(EX BANCO, HOSPITAL)
        */
        
               
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Atendimento());
        }
    }
}
