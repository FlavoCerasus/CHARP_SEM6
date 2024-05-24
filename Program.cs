// Массивы и строки

/* Задание 1 - Задайте массив символов (тип char []). 
Создайте строку из символов этого массива.

(Указание - Конструктор строки вида string(char []) не использовать.)

Пример:
[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
*/
/*
string GetStringChar (char [] array)
{
    string str_result = "";
    foreach (char lit in array)
        str_result += lit; 
        // str_result + lit (please + D = pleaseD) --- lit + str_result (D + please = Dplease)
    return str_result;
}
// Console.Write(' '+' ');
char [] arrayChars = {'p', 'l', 'e', 'a', 's', 'e'};
string str = GetStringChar(arrayChars);
Console.WriteLine(str);
*/

/* Задание 2 - На основе символов строки (тип string) сформировать 
массив символов (тип char[]). Вывести массив на экран.

(Указание - Метод строки ToCharArray() не использовать.)

Пример:
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
*/
/*
char [] StringToChar (string primaryStr)
{
    char [] chars_array = new char [primaryStr.Length];
    for (int i = 0; i < primaryStr.Length; i++)
        chars_array[i] = primaryStr[i];
    return chars_array;
} 
void PrintResult (char [] array)
{
    foreach (char lit in array)
        Console.Write($"{lit} ");
}

string strTask2 = "It is interesting!";
char [] charTask2 = StringToChar(strTask2);
Console.WriteLine($"Result array: ");
PrintResult(charTask2);
*/

/* Задание 3 - Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
Выяснить, сколько среди введённых букв гласных.

Пример:
“hello” => 2
“world” => 1
*/
/*
int CountVowelLetters (string strPrimTask3)
{
    string vowelLetters = "eyuioa";
    int countOfVowelLetters = 0;
    foreach (char lit in strPrimTask3)
        foreach(char litInLetters in vowelLetters)
            if (lit == litInLetters)
                countOfVowelLetters++;
    return countOfVowelLetters;
}

Console.Write("Enter a string: ");
string userString = Console.ReadLine();
int countVowel = CountVowelLetters(userString);
Console.WriteLine($"Count of vowel letters is {countVowel}.");
*/

// Домашнее задание!





