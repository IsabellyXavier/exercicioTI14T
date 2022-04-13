using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI14T
{
    class ControlExercicios
    {
        //Ligar as duas classes
        ModelExercicios model;
        private int opcao;
        public double altura;
        public double bas;
        public ControlExercicios()
        {
            model = new ModelExercicios();//Chamando o construtor da classe Model Exercicios
        }//fim do construtor

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("---- Menu ----" +
                             "\n1. Exercício 01" +
                             "\n2. Exercício 02" +
                             "\n3. Exercício 03" +
                             "\n4. Exercicio 04" +
                             "\n5. Exercicio 05" +
                             "\n6. Exercicio 06" +
                             "\n7. Exercicio 07");
            Console.WriteLine("Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Executar()
        {
            Menu();
            //Executar a ação
            switch (ConsultarOpcao)
            {
                case 1:
                    Console.WriteLine(model.Exercicio01());
                    break;

//_____________________________________________________________________________________________________________________
                
                case 2:
                    Console.WriteLine("Informe um valor : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O antecessor de :" + num + " é :" + model.Exercicio02(num));
                    break;
                default:
                    Console.WriteLine("Código digitado não é valido!");
                    break;

//_____________________________________________________________________________________________________________________
              
                case 3:
                    do
                    {
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());
                        if(bas <= 0)
                        {
                            Console.WriteLine("base digitada nao e valida, digite novamente!");
                        }
                    } while (bas <= 0);
                    do
                    {
                        Console.WriteLine("Informe a altura : ");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        if(altura <= 0)
                        {
                            Console.WriteLine("altura digitada nao e valida, digite novamente!");
                        }
                    } while (altura <= 0);

                    Console.WriteLine("A area do retangulo e : " + model.exercicio03(bas, altura));


                    break;

//_____________________________________________________________________________________________________________________
                
                case 4:
                    Console.WriteLine("Informe sua idade em ano : ");
                    int aux1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("informe o mes idade : ");
                    int aux2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe os dias : ");
                    int dia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Voce esta vivo a : " + model.Exercicio04(aux1,aux2,dia));

                    break;

//_____________________________________________________________________________________________________________________

                case 5:

                  

                    break;
// _____________________________________________________________________________________________________________________

                case 6:
                    Console.WriteLine("Informe seu salario atual :  ");
                    int S = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o porcentual de reajuste a ser feito :  ");
                    int R = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O seu novo Salario com Reajuste ficou : " + model.exercicio06(S,R));
                    break;

// _____________________________________________________________________________________________________________________

                case 7:

                    break;

// _____________________________________________________________________________________________________________________

            }//fim do switch

        }//fim do executar

    }//fim da classe

}//fim do projeto
