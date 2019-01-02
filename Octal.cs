using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConverter
{
    class Octal
    {
        public string ToBinary (string UserInput)
        {
            if (String.IsNullOrEmpty(UserInput) == true)
                throw new System.FormatException("Input cannot be null or empty");

            var lista = new List<string>();
            var finalLista = new List<string>();

            foreach (var ch in UserInput)
                lista.Add(ch.ToString());
                
            foreach (var ch in lista)
            {
                switch (ch)
                {
                    case "0": finalLista.Add("000"); break;
                    case "1": finalLista.Add("001"); break;
                    case "2": finalLista.Add("010"); break;
                    case "3": finalLista.Add("011"); break;
                    case "4": finalLista.Add("100"); break;
                    case "5": finalLista.Add("101"); break;
                    case "6": finalLista.Add("110"); break;
                    case "7": finalLista.Add("111"); break;
                    default: throw new System.FormatException("Input value should be in octal number base");
                }
              
            }
            var result = string.Join("", finalLista);
            return result;  
        }
        public double ToDecimal(string UserInput)
        {
            double sum = 0;
            var lista = new List<string>();
            var listNumber = new List<int>();

            if (String.IsNullOrEmpty(UserInput)==true)
                throw new System.FormatException("Input cannot be null or empty");

            for (var i = 0; i <= UserInput.Length - 1; i++)
            {
                listNumber.Add(int.Parse(UserInput[i].ToString()));
            }

            listNumber.Reverse();
            for (var i = 0; i <= listNumber.Count - 1; i++)
            {

                var conversion = listNumber[i] * Math.Pow(8, i);
                sum = sum + conversion;
            }
            return sum;
        }
        public string ToHex (string UserInput)
        {
            if (String.IsNullOrEmpty(UserInput)==true)
                throw new System.FormatException("Input cannot be null or empty");

            Octal octal = new Octal();
            var octalView = octal.ToBinary(UserInput);
            var lista = new List<string>();

            Binary binary = new Binary();
            var binaryView = binary.ToHex(octalView);

            return binaryView;

        }


    }
}
