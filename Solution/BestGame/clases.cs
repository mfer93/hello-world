using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Game
    {
        protected int number;
        protected int intentos;

        public Game() {
            this.number = Convert.ToInt32(new Random().Next(1, 100));
            this.intentos = 0;
        }

        public int GetIntentos () {
            return this.intentos;           
        }

        
    }

    public class Adivinante : Game
    {
        public int Answer(int unNumero)
        {
            this.intentos++;
            if (unNumero > this.number)
            {
                return 1;
            }
            else
            {
                if (unNumero == this.number)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    public class Adivinador : Game
    {
        private int limInferior,limSuperior;

        public int piensaNumero(int unaRespuesta) {

            this.intentos++;
            
            if (unaRespuesta == 1)
            {
                limSuperior = unaRespuesta;
            }
            else if (unaRespuesta == -1) {
                limInferior = unaRespuesta;
            }

            this.number = (limInferior + limSuperior) / 2;
            return this.number;
        }
    }
}
