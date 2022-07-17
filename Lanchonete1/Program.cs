using System;
using System.Globalization;

namespace Lanchonete1

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a minha lanchonete cara ...");
            Console.WriteLine();
            Console.WriteLine("Este é o meu Menu De Opções");
            Console.WriteLine();
            Console.WriteLine("Não se esqueça de digitar o codigo da opção desejada");
            Console.WriteLine("COD 1 = X SALADA R$ 7,25");
            Console.WriteLine("COD 2 = X SALADA DUPLO R$ 8,25");
            Console.WriteLine("COD 3 = BATATA PEQUENA R$ 3,25");
            Console.WriteLine("COD 4 = BATATA GRANDE R$ 4,25");
            Console.WriteLine("COD 5 = REFRIGERANTE R$ 5,25");
            Console.WriteLine("COD 6 COMBO 1 = X SALADA + REFRI + BATATA PEQUENA R$ 15,25");
            Console.WriteLine("COD 7 COMBO 2 = X SALADA DUPLO + REFRI + BATATA GRANDE R$ 18,25");
            Console.WriteLine();

            CultureInfo Din = CultureInfo.InvariantCulture;
            int codigo, quantidade;
            double ValorPago, Dinheiro, Troco, Resto;


            Console.Write("Agora que você já pensou, digite o codigo do produto desejado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Agora digite por favor a quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (codigo)
            {
                case 1:
                    ValorPago = 7.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 2:
                    ValorPago = 8.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 3:
                    ValorPago = 3.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 4:
                    ValorPago = 4.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 5:
                    ValorPago = 5.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 6:
                    ValorPago = 15.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                case 7:
                    ValorPago = 18.25 * quantidade;
                    Console.WriteLine("O valor do seu pedido é de = " + ValorPago, "F1", Din);
                    Console.WriteLine();
                    Console.WriteLine("Agora que você já sabe o valor...");
                    Console.WriteLine("Digite o valor em dinheiro que você esta pagando: ");
                    Dinheiro = double.Parse(Console.ReadLine());
                    if (Dinheiro >= ValorPago)
                    {
                        Troco = Dinheiro - ValorPago;
                        Console.WriteLine("SEU TROCO = " + Troco, "F1", Din);
                    }
                    else if (Dinheiro < ValorPago)
                    {
                        Resto = ValorPago - Dinheiro;
                        Console.WriteLine("DINHEIRO INSUFICIENTE FALTA = " + Resto, "F1", Din);
                        Console.WriteLine("Assim você não come hoje cara!!!");
                        Console.WriteLine("Escolha algo dentro do valor = " + Dinheiro, "F1", Din);
                    }


                    break;
                default:
                    Console.WriteLine("Opção invalida tente novamente");
                    break;
                    
                    
                    


            }









        }
    }
}