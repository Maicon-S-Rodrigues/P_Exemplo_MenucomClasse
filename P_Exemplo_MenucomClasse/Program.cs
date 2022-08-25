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

        static void imprimirContatos(Pessoa[] contatos)
        {
            Console.Clear();
            Console.WriteLine(">>> CONTATOS <<<");
            Console.WriteLine("NOME: " + contatos[0].Nome + "\nIDADE: " + contatos[0].Idade);
        }
        static void Main(string[] args)
        {
            Pessoa[] contatos = new Pessoa[10];
            int opc;

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
                        contatos[0] = lerPessoa();      ////vetor contatos receberá o Return do método lerPessoa
                        break;

                    case 2:
                        imprimirContatos(contatos);
                        break;

                    default:
                        break;
                }

            } while (opc !=0);
            Console.WriteLine(">>>>> FIM <<<<<");
        }
    }
}
