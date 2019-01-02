using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConverter
{
    class Binary
    {
        
        public string ToOctal (string UserInput)
        {
            string padded = "";
            var lastLista = new List<string>();
            var lista = new List<string>();
            if (String.IsNullOrEmpty(UserInput)==true)
            {
                throw new System.FormatException("String cannot be null or empty");
            }
            else if (UserInput.Length % 3 == 1)
            {
                padded = UserInput.PadLeft(UserInput.Length + 2, '0');
            }
            else if (UserInput.Length % 3 == 2)
            {
                padded = UserInput.PadLeft(UserInput.Length + 1, '0');
            }
            else
            {
                padded = UserInput;
            }
            
            for (var i = 0; i <= padded.Length-1; i=i+3)
            {
                lista.Add(padded.Substring(i, 3));
            }

            foreach (var ch in lista)
            {
                switch (ch)
                {
                    case "000": lastLista.Add("0"); break;
                    case "001": lastLista.Add("1"); break;
                    case "010": lastLista.Add("2"); break;
                    case "011": lastLista.Add("3"); break;
                    case "100": lastLista.Add("4"); break;
                    case "101": lastLista.Add("5"); break;
                    case "110": lastLista.Add("6"); break;
                    case "111": lastLista.Add("7"); break;
                    default: throw new System.FormatException("Input value should be in binary base number");
                }
            }
            var result = string.Join("",lastLista);
            return result;
        }

        public double ToDecimal (string UserInput)
        {
            double sum = 0;
            var lista = new List<string>();
            var listNumber = new List<int>();
            
            for(var i = 0; i <= UserInput.Length -1; i++)
            {
                listNumber.Add(int.Parse(UserInput[i].ToString()));
            }

            listNumber.Reverse();
            for (var i = 0; i <= listNumber.Count-1; i++)
            {

                var conversion = listNumber[i] * Math.Pow(2, i);
                sum = sum + conversion;
            }
            return sum;
        }
        public string ToHex (string UserInput)
        {
            var lista = new List<string>();
            var lastLista = new List<string>();

            string padded = "";
            if (String.IsNullOrEmpty(UserInput)==true)
            {
                throw new System.FormatException("Input cannot be null or empty");
            }
            else if (UserInput.Length % 4 == 1)
            {
                padded = UserInput.PadLeft(UserInput.Length + 3, '0');
            }
            else if (UserInput.Length % 4 == 2)
            {
                padded = UserInput.PadLeft(UserInput.Length + 2, '0');
            }
            else if (UserInput.Length % 4 == 3)
            {
                padded = UserInput.PadLeft(UserInput.Length + 1, '0');
            }
            else
            {
                padded = UserInput;
            }

            for (var i = 0; i <= padded.Length - 1; i = i + 4)
            {
                lista.Add(padded.Substring(i, 4));
            }
            foreach (var ch in lista)
            {
                switch (ch)
                {
                    case "0000": lastLista.Add("0"); break;
                    case "0001": lastLista.Add("1"); break;
                    case "0010": lastLista.Add("2"); break;
                    case "0011": lastLista.Add("3"); break;
                    case "0100": lastLista.Add("4"); break;
                    case "0101": lastLista.Add("5"); break;
                    case "0110": lastLista.Add("6"); break;
                    case "0111": lastLista.Add("7"); break;
                    case "1000": lastLista.Add("8"); break;
                    case "1001": lastLista.Add("9"); break;
                    case "1010": lastLista.Add("A"); break;
                    case "1011": lastLista.Add("B"); break;
                    case "1100": lastLista.Add("C"); break;
                    case "1101": lastLista.Add("D"); break;
                    case "1110": lastLista.Add("E"); break;
                    case "1111": lastLista.Add("F"); break;
                    default: throw new System.FormatException("Input value should be in hexadecimal number base");
                }
            }
            var result = string.Join("", lastLista);
            return result;

        }





    }
}
