/*Task 1

Напишите функцию, которая принимает на вход знаковое целое число и печатает его двоичное представление, 
не используя библиотечных классов или функций. 

*/

using System.Text;


//input block
Console.WriteLine("Please enter a signed number: ");
int signedNumber = Convert.ToInt32(Console.ReadLine());

getBinaryCode(signedNumber); // 1
//getBinaryCodeWitoutStrB(signedNumber); // 2

//Get and print to console Binary Code signedNumber with String Builder
void getBinaryCode(int signedNumber)
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
    Console.WriteLine(binaryCodeStrB);
}

//Get and print to console Binary Code signedNumber with String
void getBinaryCodeWitoutStrB(int signedNumber)
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
    Console.WriteLine(binaryCodeStr);
}