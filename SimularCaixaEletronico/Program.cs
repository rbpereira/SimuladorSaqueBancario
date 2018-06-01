using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimularCaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CloseApplication = true;
            DateTime DataHora = DateTime.Now;
            int Hora = DataHora.Hour;
            string PeridoDia = "";
            string msg = "";
            ValidaNumeroInteiro ValInteger = new ValidaNumeroInteiro();
            int Nota100Count = 0;
            int Nota50Count = 0;
            int Nota20Count = 0;
            int Nota10Count = 0;

            if (Hora < 12)
            {
                PeridoDia = "Bom dia";
            }
            else if (Hora > 12 && Hora < 18)
            {
                PeridoDia = "Boa tarde";
            }
            else
            {
                PeridoDia = "Boa Noite";
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PeridoDia + " Sr(a), este caixa possui notas de 10, 20, 50 e 100 reais.\n");
            Console.ResetColor();

            while (CloseApplication)
            {
                Nota100Count = 0;
                Nota50Count = 0;
                Nota20Count = 0;
                Nota10Count = 0;

                Console.Write("Por favor, digite o valor que deseja sacar. ");
                string Valor = Console.ReadLine();


                bool retorno = ValInteger.GetInteger(Valor);

                if (retorno)
                {
                    Int32 ValorSaque = Convert.ToInt32(Valor);

                    while (ValorSaque >= 100)
                    {
                        ValorSaque = ValorSaque - 100;
                        Nota100Count++;
                    }
                    while (ValorSaque >= 50)
                    {
                        ValorSaque = ValorSaque - 50;
                        Nota50Count++;
                    }
                    while (ValorSaque >= 20)
                    {
                        ValorSaque = ValorSaque - 20;
                        Nota20Count++;
                    }
                    while (ValorSaque >= 10)
                    {
                        ValorSaque = ValorSaque - 10;
                        Nota10Count++;
                    }

                    Console.WriteLine("\n");


                    if (ValorSaque == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("Saque realizado com sucesso!\n\n");

                        if (Nota100Count > 0)
                        {
                            Console.WriteLine("Foram sacadas " + Nota100Count + " Nota(s) de R$100" + ".\n");
                        }
                        if (Nota50Count > 0)
                        {
                            Console.WriteLine("Foram sacadas " + Nota50Count + " Nota(s) de R$50.\n");
                        }
                        if (Nota20Count > 0)
                        {
                            Console.WriteLine("Foram sacadas " + Nota20Count + " Nota(s) de R$20.\n");
                        }
                        if (Nota10Count > 0)
                        {
                            Console.WriteLine("Foram sacadas " + Nota10Count + " Nota(s) de R$10.\n");
                        }

                        Console.ResetColor();
                    }
                    else
                    {
                        msg = "Desculpa, mas não há notas disponíveis para realizar este saque.\n\n";
                    }


                    Console.Write(msg + "Deseja realizar outro saque? S/N ");
                    string Key = Console.ReadLine();

                    if (Key == "N" || Key == "n")
                    {
                        CloseApplication = false;
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Valor informado não é aceito, por favor tente novamente.\n\n");
                }
            }
        }
    }
}
