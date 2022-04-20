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
        private string v2;
        private string aux3;
        private string v1;
        private string v3;
        private string v4;
        private double aux1;
        public string ConsultarMsg;
        public string consultarvalor;
        public string Contarvalor;
        public string Contarvalor2;
        


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
                             "\n7. Exercicio 07" +
                             "\n8. Exercicio 08" +
                             "\n9. Exercicio 09" +
                             "\n10. Exercicio 10" +
                             "\n11. Exercicio 11" +
                             "\n12. Exercicio 12" +
                             "\n13. Exercicio 13" +
                             "\n14. Exercicio 14" +
                             "\n15. Exercicio 15");
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

                    Console.WriteLine("Informe o total de eleitor :  ");
                    int eleitores = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o total de votos validos:  ");
                    int validos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o total de votos nulos: ");
                    int nulos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o total de votos em brancos:  ");
                    int brancos = Convert.ToInt32(Console.ReadLine());
                   

                    break;
// _____________________________________________________________________________________________________________________

                case 6:
                    Console.WriteLine("Informe seu salario atual :  ");
                    int S = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o porcentual de reajuste a ser feito :  ");
                    int R = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("O seu novo Salario com Reajuste ficou : " + v2 + " reais " + model.exercicio06(S,R));
                    break;

// _____________________________________________________________________________________________________________________

                case 8:
                    Console.WriteLine("Digite a nota da prova : ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a nota da atividade : ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a nota da pesquisa : ");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A sua media é" + aux3 + " na materia de matematica " + model.exercicio08(n1, n2, n3));

                    break;

// _____________________________________________________________________________________________________________________
                
                case 9:
                    Console.WriteLine("Digite a quantidade de maças compradas :");
                    double M = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("A quantidade paga sera :"+ model.exercicio09(M));
                    break;
// _____________________________________________________________________________________________________________________

                case 11:
                    Console.WriteLine("Digite o seu salario completo :");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite seu total de vendas :");
                    double venda = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O seu salario no total fica :" + model.exercicio11(salario, venda));
                    break;

//_______________________________________________________________________________________________________________________

                case 12:
                    Console.WriteLine("Digite o numero da sua conta :");
                    string NC = (Console.ReadLine());
                    Console.WriteLine("Informe o saldo da conta :");
                    double saldo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o Credito :");
                    double credito = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("informe o Debito :");
                    double debito = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(model.exercicio12(saldo, credito, debito));

                    break;

//________________________________________________________________________________________________________________________

                case 13:
                    Console.WriteLine("Digite um valor inteiro :");
                    int tabuada = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(model.exercicio13(tabuada));
                    break;
//__________________________________________________________________________________________________________________________________________

                case 14:
                    Console.WriteLine("Digite um valor :");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(model.exercicio14(valor));


                    break;

                //__________________________________________________________________________________________________________________________

                case 15:
                    Console.WriteLine("Digite um valor :");
                    double valor2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(model.exercicio15(valor2));


                    break;
            
            
            }//fim do switch

        }//fim do executar

    }//fim da classe

}//fim do projeto
