using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseNumberConverter;

namespace BaseNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Which base number do u have? (hex,dec,bin,oct)type 'exit' if u wanna quit");
                var baseInput = Console.ReadLine();

                if (baseInput == "hex")
                {
                    HexDec hexDecimal = new HexDec();
                    Console.WriteLine("Enter hex number! (letters should be uppercase!)");
                    var hexInput = Console.ReadLine();
                    var hexBin = hexDecimal.ToBinary(hexInput);
                    var hexOct = hexDecimal.ToOctal(hexInput);
                    var hexDec = hexDecimal.ToDecimal(hexInput);
                    Console.WriteLine("hex input = {0}\nBinary = {1}\nOctal = {2}\nDecimal = {3}", hexInput, hexBin, hexOct, hexDec);
                }
                else if (baseInput == "dec")
                {
                    Decimal decim = new Decimal();
                    Console.WriteLine("Enter decimal number!");
                    var decInput = int.Parse(Console.ReadLine());
                    var decBin = decim.ToBinary(decInput);
                    var decOct = decim.ToOctal(decInput);
                    var decHex = decim.ToHex(decInput);
                    Console.WriteLine("Decimal input = {0}\nBinary = {1}\nOctal = {2}\nHex = {3}", decInput, decBin, decOct, decHex);
                }
                else if (baseInput == "oct")
                {
                    Octal octal = new Octal();
                    Console.WriteLine("Enter octal number!");
                    var octalInput = Console.ReadLine();
                    var octBin = octal.ToBinary(octalInput);
                    var octDec = octal.ToDecimal(octalInput);
                    var octHex = octal.ToHex(octalInput);
                    Console.WriteLine("Octal input = {0}\nBinary = {1}\nDecimal = {2}\nHex = {3}", octalInput, octBin, octDec, octHex);
                }
                else if (baseInput == "bin")
                {
                    Binary binary = new Binary();
                    Console.WriteLine("Enter binary number!");
                    var binInput = Console.ReadLine();
                    var binOct = binary.ToOctal(binInput);
                    var binDec = binary.ToDecimal(binInput);
                    var binHex = binary.ToHex(binInput);
                    Console.WriteLine("Binary input = {0}\nOctal = {1}\nDecimal = {2}\nHex = {3}", binInput, binOct, binDec, binHex);
                }
                else if (baseInput == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid base number!");
                }
            }
        }
    }
}
