using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimoQ.modelo
{
    public class Controle
    {
		private string mensagem;
		private string numero;

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.N1);
                this.mensagem = primo.Mensagem;
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public string Mensagem
		{
			get { return mensagem; }
		}
	}
}
