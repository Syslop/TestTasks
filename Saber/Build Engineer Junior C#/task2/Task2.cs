/*Task 2

2.	Напишите функцию, удаляющую последовательно дублирующие символы в строке:

// пример использования
var data = new StringBuilder("AAA BBB AAA");
RemoveDups(data);
Console.WriteLine(data); // "A B A"

*/
using System.Text;

//Input block
var data = new StringBuilder("AAA ABBB AAA");

Console.WriteLine(data);
RemoveDupsWithRemoveMethod(data);
//RemoveDupsWithoutRemoveMethod(data);
Console.WriteLine(data);

//RemoveDups with using method Remove()
void RemoveDupsWithRemoveMethod(StringBuilder str) 
{
    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] == str[i - 1])
        {
            str.Remove(i, 1);
            i--;
        }
    }
}

//RemoveDups without using method Remove()
void RemoveDupsWithoutRemoveMethod(StringBuilder str) 
{
    for (int i = 1; i < str.Length; i++)
    {
        if (str[i] == str[i - 1])
        {
            str.Insert(i, "");
            i--;
        }
    }
}