/*Task 2

2.	Напишите функцию, удаляющую последовательно дублирующие символы в строке:

// пример использования
var data = new StringBuilder("AAA BBB AAA");
RemoveDups(data);
Console.WriteLine(data); // "A B A"

*/
using System.Text;

var data = new StringBuilder("AAA BBB AAA");

Console.WriteLine(data);
RemoveDups(data);
Console.WriteLine(data);

void RemoveDups(StringBuilder str) 
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
