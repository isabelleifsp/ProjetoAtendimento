using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento.Models
{
    // modela um guiche com:   id dele (atendimentos é uma fila de senhas quando sair de senhas entra no atendimentos)
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;
        public Queue<Senha> Atendimentos { get { return atendimentos; } }

        public Guiche() {
            id = 0;
            atendimentos = new Queue<Senha>();
        }
        public Guiche(int id)
        {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }
        public bool chamar(Queue<Senha> filaSenhas) {
            if (filaSenhas.Count == 0) return false; 
            Senha aux = filaSenhas.Dequeue();
            aux.HoraAtend = DateTime.Now;
            aux.DataAtend = DateTime.Now;
            atendimentos.Enqueue(aux);
            return true;
        }
    }
  }
