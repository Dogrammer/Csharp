using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConverter
{
    class Decimal
    {
        public string ToBinary (int DecimalInput)
        {
            var lista = new List<string>();
            
            int remainder = 0;
            lista.Add((DecimalInput % 2).ToString());
            while (true)
            {
                //try with for loop 
                DecimalInput = DecimalInput / 2;
                int number = DecimalInput;
                remainder = number % 2;
                lista.Add(remainder.ToString());
                if (DecimalInput / 2 == 0)
                    break;
            }
            var result = string.Join("", lista);

            char[] charArray = result.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string ToOctal (int DecimalInput)
        {
            Decimal decimalView = new Decimal();
            var decToBin = decimalView.ToBinary(DecimalInput);

            Binary octalView = new Binary();
            var binToOct = octalView.ToOctal(decToBin);

            return binToOct;

        }
        public string ToHex (int DecimalInput)
        {
            Decimal decimalView = new Decimal();
            var decToBin = decimalView.ToBinary(DecimalInput);

            Binary binaryView = new Binary();
            var binToOct = binaryView.ToHex(decToBin);

            return binToOct;
        }
    }
}
