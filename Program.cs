using System;
using Sobrecarga.classes;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            Mastercard masterCard = new Mastercard(); 

            Console.WriteLine("Digite o valor da sua compra");
            float valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número do seu cartão");
            cartao.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua cvv");
            cartao.Cvv = Console.ReadLine();            
            
            cartao.RegistarCompra( cartao.ValidarCompra(valor) );
            
            Console.WriteLine("Digite o número de parcelas de 0 (á vista) a 24");
            masterCard.parcelas = int.Parse(Console.ReadLine());

            masterCard.ComprarComDesconto(masterCard.parcelas);
        }
    }
}
