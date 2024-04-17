using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimoQ.modelo
{
    public class Controle : AbsPropriedades
    {

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {

            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero);
            if (validacao.mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.n1);
                this.mensagem = primo.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }

	}
}
