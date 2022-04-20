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
        private double E;
        private double F;
        private double G;
        private double M;
        private string NC;
        private double ST;
        private string msg;
        private string valor;

        //Declarar o construtor
        public ModelExercicios()
        {
            ConsultarA = 10;
            ConsultarB = 1;
            ConsultarC = 0;
            ConsultarD = 0;
            ModificarM = 0;
            ModificarF = 0;
            
            
           
           


      
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

        public double ModificarM
        {
            get
            {
                return M;
            }
            set
            {
                this.M = value;
            }
        }//fim do ModificarM
        public double ModificarE
        {
            get
            {
                return E;
            }
            set
            {
                this.E = value;
            }
        }//fim do ModificarE
        public double ModificarF
        {
            get
            {
                return F;
            }
            set
            {
                this.F = value;
            }
        }//fim do ModificarF
        public string ConsultarMsg
        {
            get
            {
                return msg;
            }
            set
            {
                this.msg = value;
            }
        }//fim do Consultar msg
        public string ConsultarValor
        {
            get
            {
                return valor;
            }
            set
            {
                this.valor = value;
            }
        }//fim do Consultar valor




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
        public string Exercicio05(int eleitores, int validos, int nulos, int brancos)
        {
            double v1 = (validos/ eleitores) * 100;
            double v3 = (nulos / eleitores) * 100;
            double v4 = (brancos / eleitores) * 100;
            return "Votos validos : " + v1 + "Votos nulos : " + v3 + "Votos em branco : " + v4;
           
        }// fim do exercicio05
//______________________________________________________________________________________________________________________

        public double exercicio06(double S, double R)
        {
            double v2 = (S * (R/100)) + S;
            return v2;

        }//fim do exercicio06

//_______________________________________________________________________________________________________________________

        public double exercicio08(int n1, int n2, int n3)
        {
            int aux3 = ((n1 + n2 + n3) / 4);
            return aux3;

        }//fim do exercicio08
//_______________________________________________________________________________________________________________________
        public double exercicio09(double M)
        {
            if(M < 12)
            {
                return M = (M * 1.30);
            }
            else
            {
                return M = (M * 1.00);
            }
            
        }//fim do exercicio09.
 //_________________________________________________________________________________________________________________________
        public double exercicio11(double salario, double venda)
        {
            if (venda > 1500)
            {
                return salario = (venda * 0.05) + salario;
            }
            else
            {
                return salario = (venda * 0.03) + salario;
           
            }

        }// fim do exercicio 11.
        
//____________________________________________________________________________________________________________________________________

        public string exercicio12( double saldo, double credito, double debito)
        {
            saldo = (saldo - debito) + credito;
            

            if (saldo < 0)
            {
                return "Seu saldo é negativo: ";
            }
            else
            {
                return "Seu saldo é positivo: ";
            }
        }// fim do exercicio 12.
//____________________________________________________________________________________________________________________________________

            public string exercicio13(int tabuada)
        {
            for (int i = 0; i <= 10; i++)
            {
                ConsultarMsg += "\n" + tabuada + "x" + i + "=" + (i * tabuada);
            }
            return ConsultarMsg;
    

        }// fim do exercicio 13

 //____________________________________________________________________________________________________________________________________

        public string exercicio14(int valor)
        {
            for (int i = 0; i <= valor; i++)
            {
                ConsultarValor += "\n" + i;
                    
            }
            return ConsultarValor += "\n" + "esta entre" + "0 e" + valor + "\n" + ConsultarValor;

        }// fim do exercicio 14

        //_____________________________________________________________________________________________________________________________________

        public string exercicio15( double valor2)
        {
            
            if (valor2 < 0)
            {
                valor2 = valor2 + 1;
                return "A quantidade de numeros negativos e : " + valor2;
            }
            else
            {
                valor2 = valor2 + 1;
                return "A quantidade de numeros positivos e : " + valor2;
            }
        }// fim do exercicio 15.

    }//fim da classe
}//fim do projeto
