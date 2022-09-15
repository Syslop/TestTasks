/*Task 1

Напишите функцию, которая принимает на вход знаковое целое число и печатает его двоичное представление, 
не используя библиотечных классов или функций. 

*/
using System.Text;


//input block
Console.WriteLine("Please enter a signed number: ");
int signedNumber = Convert.ToInt32(Console.ReadLine());

if (signedNumber > 0) 
{
    Console.WriteLine(GetBinaryCode(signedNumber)); // 1
} 
else 
{
    StringBuilder str = GetBinaryCode(signedNumber);
    Console.WriteLine(ConvertForNegative(str));

//  string str = GetBinaryCodeWitoutStrB(signedNumber);
//  Console.WriteLine(ConvertForNegativeStr(str));
}
//Console.WriteLine(GetBinaryCodeWitoutStrB(signedNumber)); // 2

//Get Binary Code signedNumber with String Builder
StringBuilder GetBinaryCode(int signedNumber)
{
    StringBuilder binaryCodeStrB = new StringBuilder();
    int wholePart = signedNumber / 2;
    int fractionalPart = signedNumber % 2;
    binaryCodeStrB.Insert(0, Convert.ToString(fractionalPart), 1);

    while (wholePart != 0)
    {
        fractionalPart = wholePart % 2;
        binaryCodeStrB.Insert(0, Convert.ToString(fractionalPart), 1);
        wholePart = wholePart / 2;
    }
    return binaryCodeStrB;
}

//Get Binary Code signedNumber with String
string GetBinaryCodeWitoutStrB(int signedNumber)
{
    string binaryCodeStr = "";
    int wholePart = signedNumber / 2;
    int fractionalPart = signedNumber % 2;
    binaryCodeStr = Convert.ToString(fractionalPart);

    while (wholePart != 0)
    {
        fractionalPart = wholePart % 2;
        binaryCodeStr = $"{fractionalPart}{binaryCodeStr}";
        wholePart = wholePart / 2;
    }
    return binaryCodeStr;
}

StringBuilder ConvertForNegative(StringBuilder stringBuilder)
{
    stringBuilder.Replace("-", "");
    stringBuilder.Replace('1', 's');
    stringBuilder.Replace('0', '1');
    stringBuilder.Replace('s', '0');
    return stringBuilder;
}

string ConvertForNegativeStr(string str)
{
    str.Replace("-", "");
    str.Replace('1', 's');
    str.Replace('0', '1');
    str.Replace('s', '0');
    return str;
}