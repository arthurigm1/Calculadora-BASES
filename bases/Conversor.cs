using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace bases
{
    class Conversor
    {
        public static int BinarioDecimal(string numeroBinario)
        {
            int expoente = 0;
            int numero;
            int soma = 0;
            string numeroInvertido = ReverteString(numeroBinario);
            for (int i = 0; i < numeroInvertido.Length; i++)
            {
                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));
                soma += numero * (int)Math.Pow(2, expoente);
                expoente++;
            }
            return soma;
        }
        public static string DecimalBinario(string numeroDecimal)
        {
            string valor = "";
            int dividendo = Convert.ToInt32(numeroDecimal);
            if (dividendo == 0 || dividendo == 1)
            {
                Console.WriteLine(dividendo);
                return Convert.ToString(dividendo);

            }
            else
            {
                while (dividendo > 0)
                {
                    valor += Convert.ToString(dividendo % 2);
                    dividendo = dividendo / 2;
                    Console.WriteLine(valor);
                }
                return ReverteString(valor);
            }
        }
        public static string ReverteString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static string  Hexadecimaldecimal(string numerohexa)
        {
            int dec;
            dec = int.Parse(numerohexa, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("O resultado é: " + dec);
            return numerohexa;
        }
        public static int DecimalHexa(int numerodec)
        {
            string hexNumber = numerodec.ToString("X2");
            Console.WriteLine("O resultado é: " + hexNumber);
            return numerodec;
        }

        public static string BinarioHex(string numerobi)
        {
            string hexNumber = Convert.ToInt32(numerobi, 2).ToString("X");
            Console.WriteLine(hexNumber);
            return numerobi;
        }
        public static string HexBinario(string numerohex)
        {
            string binaryNumber = Convert.ToString(Convert.ToInt32(numerohex, 16), 2).PadLeft(8, '0');
            Console.WriteLine(binaryNumber);
            return numerohex;
        }
    }
}
