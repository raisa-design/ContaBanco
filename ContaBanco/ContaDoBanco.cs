using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco { 

internal class ContaDoBanco
{
    public int NumConta { get; set; }

    protected string Tipo { get; set; }

    private string Dono { get; set; }

    private double Saldo { get; set; }

    private bool Status { get; set; }



    public ContaDoBanco(int saldo)
    {
        Saldo = 0;
        setStatus(false);
    }

    public void mostrarDetalhes()
        {
            Console.WriteLine("//////////////////////////////////////////////");
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Nome: " + Dono);
            Console.WriteLine("Numero da Conta: " + NumConta);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("Status: " + Status);


            Console.WriteLine("//////////////////////////////////////////////");

       }
        public void setStatus(bool status)
    {
        Status = status;
    }

    public void setNumConta(int numConta)
    {
        NumConta = numConta;
    }

    public void setTipo(string tipo)
    {
        Tipo = tipo;
    }
     public void setDono(string dono)
     {
           Dono = dono;
     }

     public int getNumConta()
        {
          return NumConta;
     }
        public void  abrirConta(string type)
    {
        Tipo = type;
        setStatus(true);

        if (type == "CC")
        {
            Saldo = 50;
        }
        else if (type == "CP")
        {
            Saldo = 150;
        }
    }

    public void fecharConta()
    {
        if (Saldo > 0)
        {
            Console.WriteLine("Conta com dinheiro");
        }
        else if (Saldo < 0)
        {
            Console.WriteLine("Conta em débito");
        }
        else
        {
            setStatus(false);
        }

    }

    public void depositar(double dep)
    {
            Console.WriteLine(Status);
            if (Status == true)
            {
               Saldo = Saldo + dep;
            }
            else
            {
            Console.WriteLine("Impossível Depositar");
          
            }
        }

    public void sacar(double sac)
    {
        if (Status == true)
        {
            if (Saldo >= sac)
            {
                Saldo = Saldo - sac;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }
        else
        {
            Console.WriteLine("Impossível Sacar");
        }

    }

    public void pagarMensal()
    {
        double pagMen = 0;

        if (Tipo == "CC")
        {
            pagMen = 12;
        }
        else if (Tipo == "CP")
        {
            pagMen = 20;
        }

        if (Status == true)
        {
                if (Saldo >= pagMen)
                {
                    Saldo = Saldo - pagMen;
                }
                else
                {
                    Console.WriteLine("Saldo Insuficiente");

                }

            }
        else
        {
            Console.WriteLine("Impossível pagar");
        }
    }

        //internal bool abrirConta()
        //{
        //    throw new NotImplementedException();
        //}
    }
}


