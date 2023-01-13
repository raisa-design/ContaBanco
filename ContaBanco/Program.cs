// See https://aka.ms/new-console-template for more information

using ContaBanco;
using System.Xml.Linq;

var listaDeContas = new List<ContaDoBanco>();

string opt = "";


do
{
    Console.WriteLine("Escolha um das opções");
    Console.WriteLine("0:Finalizar Operação");
    Console.WriteLine("1: Abrir Conta");
    Console.WriteLine("2:Mostrar  Contas");
    Console.WriteLine("3: Fechar Conta ");
    Console.WriteLine("4: Depositar");
    Console.WriteLine("5: Sacar");
    Console.WriteLine("6: Pagar Mensalidade");

    opt = Console.ReadLine();

    
    if (opt == "1")
    {
        var conta = new ContaDoBanco(0);
        Console.WriteLine("Digite CC para Conta Corrente e CP para Conta Poupança");
        conta.abrirConta(Console.ReadLine());
        Console.WriteLine("Digite o seu nome: ");
        conta.setDono(Console.ReadLine());
        Console.WriteLine("Digite o numero da conta");
        conta.setNumConta(Convert.ToInt32(Console.ReadLine()));

        
        listaDeContas.Add(conta);
       
    }
    if (opt == "2")
    {
        {
            foreach (ContaDoBanco conta in listaDeContas)
            {
                conta.mostrarDetalhes();
            }
        }
    }

    if (opt == "3")
    {
        Console.WriteLine("Digite o número da conta: ");
        var numeConta = (Convert.ToInt32(Console.ReadLine()));
        ContaDoBanco conta = listaDeContas.Find(x => x.getNumConta() == numeConta);
        conta.fecharConta();
    }

    if (opt == "4")
    {
        Console.WriteLine("Digite o número da conta: ");
        var numeConta = (Convert.ToInt32(Console.ReadLine()));
        ContaDoBanco conta = listaDeContas.Find(x => x.getNumConta() == numeConta);
        Console.WriteLine(" Digite o valor que você deseja depositar ");
        var deposito = Convert.ToDouble(Console.ReadLine());
        conta.depositar(deposito);



    }

    if (opt == "5")
    {
        Console.WriteLine("Digite o número da conta: ");
        var numeConta = (Convert.ToInt32(Console.ReadLine()));
        ContaDoBanco conta = listaDeContas.Find(x => x.getNumConta() == numeConta);
        var saque = Convert.ToDouble(Console.ReadLine());
        conta.sacar(saque);




    }

    if (opt == "6")
    {
        Console.WriteLine("Digite o número da conta: ");
        var numeConta = (Convert.ToInt32(Console.ReadLine()));
        ContaDoBanco conta = listaDeContas.Find(x => x.getNumConta() == numeConta);
        conta.pagarMensal();

    }

    //if (opt == "4")
    //{
    //    Console.WriteLine("Digite o nome da caneta que você deseja usar ");
    //    var name = Console.ReadLine();
    //    Caneta caneta = listaDeCanetas.Find(x => x.getNome() == name);
    //    Console.WriteLine("Digite a palavra que deseja escrever");
    //    var palavra = Console.ReadLine();
    //    caneta.Rabiscar(palavra);


    //}




} while (opt != "0") ; 

    Console.WriteLine("Programa finalizado");


