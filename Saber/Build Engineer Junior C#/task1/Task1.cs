/*Task 1

Напишите функцию, которая принимает на вход знаковое целое число и печатает его двоичное представление, 
не используя библиотечных классов или функций. 

*/
using System.Text;


//input block
Console.WriteLine("Please enter a signed number: ");
int signedNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetBinaryCode(signedNumber)); // 1
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