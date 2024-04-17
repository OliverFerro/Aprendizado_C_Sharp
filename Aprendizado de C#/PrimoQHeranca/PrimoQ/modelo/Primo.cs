using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimoQ.modelo
{
    public class Primo : AbsPropriedades
    {
        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {
            this.mensagem = "É primo";
            if (this.num <= 1)
            {
                this.mensagem = "Não é primo";
                return;
            }

            for (int i = 2; i < (this.num / 2 + 1); i++)
            {
                if (this.num % i == 0)
                {
                    this.mensagem = "Não é primo";
                    break;
                }
            }
        }
	}
}
