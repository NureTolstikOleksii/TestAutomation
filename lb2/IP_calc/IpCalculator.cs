using System;
using System.Linq;

namespace IP_calc
{
    // Клас, що підлягає модульному тестуванню
    public class IpCalculator
    {
        // Перетворення префікса в двійкову маску
        public string GetBinaryMaskFromPrefix(int prefixLength)
        {
            if (prefixLength < 0 || prefixLength > 32) return null;
            uint mask = (uint)(0xFFFFFFFF << (32 - prefixLength));
            return Convert.ToString(mask, 2).PadLeft(32, '0');
        }

        // Перетворення десяткового октету в двійковий (8 біт)
        public string ToBinaryOctet(string decimalValue)
        {
            return Convert.ToString(Convert.ToInt32(decimalValue), 2).PadLeft(8, '0');
        }

        // Побітове "І" для двох двійкових рядків
        public string BitwiseAnd(string bin1, string bin2)
        {
            int val1 = Convert.ToInt32(bin1, 2);
            int val2 = Convert.ToInt32(bin2, 2);
            return Convert.ToString(val1 & val2, 2).PadLeft(8, '0');
        }

        // Інвертація бітів [ЛБ №1 завдання]
        public string InvertBinary(string binaryString)
        {
            return new string(binaryString.Select(bit => bit == '0' ? '1' : '0').ToArray());
        }

        // Підрахунок одиниць у масці
        public int CountMaskBits(string maskOctet)
        {
            return maskOctet.Count(bit => bit == '1');
        }

        // Підрахунок нулів у кінці (для номера комп'ютера)
        public int CountZeroBits(string octet)
        {
            return octet.Reverse().TakeWhile(c => c == '0').Count();
        }

        // Визначення класу мережі
        public string GetNetworkClass(string firstOctetBinary)
        {
            if (string.IsNullOrEmpty(firstOctetBinary)) return "Помилка";
            char firstBit = firstOctetBinary[0];
            if (firstBit == '0') return "Клас A";
            if (firstBit == '1' && (firstOctetBinary.Length < 2 || firstOctetBinary[1] == '0')) return "Клас B";
            if (firstBit == '1' && firstOctetBinary[1] == '1' && (firstOctetBinary.Length < 3 || firstOctetBinary[2] == '0')) return "Клас C";
            return "Невизначений клас";
        }
    }
}