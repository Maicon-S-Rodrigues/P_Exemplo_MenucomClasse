using System;

namespace P_Exemplo_MenucomClasse
{
    internal class Program
    {
        static Pessoa lerPessoa()
        {
            string n;  ///variavel para nome
            int i; //variavel para idade
            Console.Clear();
            Console.WriteLine("Informe o Nome da pessoa: ");
            n = Console.ReadLine();
            Console.WriteLine("informe a idade: ");
            i = int.Parse(Console.ReadLine());

            return new Pessoa   //instância do novo objeto através de uso de Property retornando o Objeto diretamente
            {
                Nome = n,
                Idade = i
            };
            /*Pessoa pessoa = new Pessoa    //outra maneira de instânciar o novo objeto através de uso de Property criando uma variável
            {
                Nome = n,
                Idade = i
            };
            return pessoa;*/
        }

        static void imprimirContatos(Pessoa[] contatos, int quant)
        {
            Console.Clear();
            Console.WriteLine(">>> CONTATOS <<<\n");
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("NOME: " + contatos[i].Nome + "\nIDADE: " + contatos[i].Idade);
                Console.WriteLine("\n\n");
            }
        }
        static void Main(string[] args)
        {
            Pessoa[] contatos = new Pessoa[3];
            int opc;
            int quant = 0;
            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - Cadastrar.\n" +
                                  "2 - Imprimir.\n" +
                                  "0 - Sair.");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Tchauzinho!");
                        break;

                    case 1:
                        if (quant != contatos.Length)
                        {
                            contatos[quant] = lerPessoa();      ////vetor contatos receberá o Return do método lerPessoa
                            quant++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Desculpe!\nLimite de Cadastros atingido!");
                        }
                        break;

                    case 2:
                        imprimirContatos(contatos, quant);
                        break;

                    default:
                        break;
                }

            } while (opc != 0);
            Console.WriteLine(">>>>> FIM <<<<<");
        }
    }
}
