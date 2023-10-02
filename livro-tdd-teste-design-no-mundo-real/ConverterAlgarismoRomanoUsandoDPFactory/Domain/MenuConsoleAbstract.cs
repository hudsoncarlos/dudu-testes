using ConverterAlgarismoRomanoUsandoDPFactory.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedraPapelTesoura.Model
{
    public class MenuConsoleAbstract
    {
        public virtual void ExibiMenuConsole(EnumOpcoesMenu opcaoEscolhida)
        {
            string valorDigitado = string.Empty;

            while (true)
            {
                try
                {
                    switch (opcaoEscolhida)
                    {
                        case EnumOpcoesMenu.Inicio:
                            valorDigitado = ExibirInicio();
                            break;
                        case EnumOpcoesMenu.Conversor:
                            valorDigitado = ExibirInicio();
                            break;
                        default:
                            break;
                    }

                    opcaoEscolhida = (EnumOpcoesMenu)ValidarValorInteiro(valorDigitado);
                }
                catch (Exception ex)
                {
                    EstruturaBaseTela(ex.Message);
                }
            }
        }

        public virtual string ExibirInicio()
        {
            StringBuilder descricao = new StringBuilder();
            Console.Clear();
            descricao.AppendLine("##  1 - Inicio                                                                                                       ##");
            descricao.AppendLine("##  2 - Conversor de números romanos                                                                                 ##");
            EstruturaBaseTela(descricao.ToString());
            return Console.ReadLine();
        }

        public virtual void EstruturaBaseTela(string descicao)
        {
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("##                                                                                                                   ##");
            Console.WriteLine("##                                                                                                                   ##");
            Console.WriteLine("##                                                                                                                   ##");
            Console.WriteLine(descicao);
            Console.WriteLine("##                                                                                                                   ##");
            Console.WriteLine("##                                                                                                                   ##");
            Console.WriteLine("#######################################################################################################################");
            Console.WriteLine("");
            Console.Write("Digite o número correspondente a opção e aperte enter: ");
        }

        public virtual int ValidarValorInteiro(string valor)
        {
            int saida = 1;
            if (Int32.TryParse(valor, out saida))
                return int.Parse(valor);

            return saida;
        }
    }
}
