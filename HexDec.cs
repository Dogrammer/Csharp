using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseNumberConverter
{
    class HexDec
    {
        public string ToBinary (string HexInput)
        {
            //var upperCased = HexInput.ToUpper();
            
            var HexList = new List<string>();
            var BinList = new List<string>();

            if (String.IsNullOrEmpty(HexInput) == true)
                throw new System.FormatException("Input cannot be null or empty");

            foreach (var ch in HexInput)
                HexList.Add(ch.ToString().ToUpper());

            foreach (var ch in HexList)
            {
                switch (ch)
                {
                    case "0": BinList.Add("0000"); break;
                    case "1": BinList.Add("0001"); break;
                    case "2": BinList.Add("0010"); break;
                    case "3": BinList.Add("0011"); break;
                    case "4": BinList.Add("0100"); break;
                    case "5": BinList.Add("0101"); break;
                    case "6": BinList.Add("0110"); break;
                    case "7": BinList.Add("0111"); break;
                    case "8": BinList.Add("1000"); break;
                    case "9": BinList.Add("1001"); break;
                    case "A": BinList.Add("1010"); break;
                    case "B": BinList.Add("1011"); break;
                    case "C": BinList.Add("1100"); break;
                    case "D": BinList.Add("1101"); break;
                    case "E": BinList.Add("1110"); break;
                    case "F": BinList.Add("1111"); break;
                    default: throw new System.FormatException("Input value should be in hexadecimal number base");
                }
            }
            var result = string.Join("", BinList);
            return result;
        }
        public string ToOctal (string HexInput)
        {
            if (String.IsNullOrEmpty(HexInput) == true)
                throw new System.FormatException("Input cannot be null or empty");

            HexDec hexView = new HexDec();
            var hexToBin = hexView.ToBinary(HexInput.ToUpper());

            Binary binView = new Binary();
            var binToOct = binView.ToOctal(hexToBin);

            return binToOct;
        }
        public double ToDecimal (string HexInput)
        {
            double sum = 0;
            var HexList = new List<string>();
            var IntList = new List<int>();
            if (String.IsNullOrEmpty(HexInput) == true)
                throw new System.FormatException("Input cannot be null or empty");

            foreach (var ch in HexInput)
                HexList.Add(ch.ToString().ToUpper());

            foreach (var ch in HexList)
            {
                switch (ch)
                {
                    case "A": IntList.Add(10); break;
                    case "B": IntList.Add(11); break;
                    case "C": IntList.Add(12); break;
                    case "D": IntList.Add(13); break;
                    case "E": IntList.Add(14); break;
                    case "F": IntList.Add(15); break; default: IntList.Add(int.Parse(ch));break;
                }
            }
            IntList.Reverse();

            for (var i = 0; i <= IntList.Count - 1; i++)
            {

                var conversion = IntList[i] * Math.Pow(16, i);
                sum = sum + conversion;
            }
            return sum;

        }
    }
}
