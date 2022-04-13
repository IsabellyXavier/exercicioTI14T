using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ModelExercicios
    {
        //Declaração de variáveis
        private int A;
        private int B;
        private int C;
        private double D;

        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 1;
            ConsultarC = 0;
            ConsultarD = 0;
      
        }//fim do construtor

        public int ConsultarA
        {
            get
            {
                return A;
            }
            set
            {
                this.A = value;
            }
        }//fim do consultarA

        public int ConsultarB
        {
            get
            {
                return B;
            }
            set
            {
                this.B = value;
            }
        }//fim do consultarB

        public int ConsultarC
        {
            get
            {
                return C;
            }
            set
            {
                this.C = value;
            }
        }//fim do consultarC

        public double ConsultarD
        {
            get
            {
                return D;
            }
            set
            {
                this.D = value;
            }
        }//fim do consultarD

        //Método Exercício01
        public string Exercicio01()
        {
            ConsultarC = ConsultarA - 1;
            return "A: " + ConsultarC;
        }//fim do métodoExercicio01

//_____________________________________________________________________________________________________________________
        
        public int Exercicio02(int num)
        {
            return num - 1;
        }//Fim do Exercicio02

//_____________________________________________________________________________________________________________________

        public double exercicio03(double bas, double altura)
        {
            return bas * altura;

        }//Fim do exercicio03

//_____________________________________________________________________________________________________________________

        public int Exercicio04(int aux1, int aux2, int dia)
        {
         
            return  (aux1 * 365) + (aux2 * 30) + dia;
             
        }// fim do exercicio04

//______________________________________________________________________________________________________________________

        public double exercicio06(double S, double R)
        {
            bool v = ConsultarD < (S * R) /  100;
            return ConsultarD - S;

        }

    }//fim da classe
}//fim do projeto
