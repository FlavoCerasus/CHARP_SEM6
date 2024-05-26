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

/* Задача 1 - Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.

Пример:
a b c 
d e f ==> "abcdefghi"
g h i
*/
/*
char [,] CreateMatrixWithRandomLetters (int rowCount, int columnCount)
{
    char [,] matrix = new char [rowCount,columnCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = Convert.ToChar(new Random().Next('a', 'z' +1));
    return matrix;
}
void ShowMatrix (char [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }
}
string FromCharMatrixToString(char [,] matrix)
{
    string strOfMatrixElems = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            strOfMatrixElems += matrix[i,j];
    return strOfMatrixElems;
}

Console.Write("Enter the number of rows of the matrix: ");
int rowUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns of the matrix: ");
int columnUser = Convert.ToInt32(Console.ReadLine());
char [,] matrixHW1 = CreateMatrixWithRandomLetters(rowUser, columnUser);
ShowMatrix(matrixHW1);
string resultHWTask1 = FromCharMatrixToString(matrixHW1);
Console.WriteLine($"The resulting string is: {resultHWTask1}");
*/

/* Задача 2 - Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Пример:
aBcD1ef!- ==> "abcd1ef!-"
*/
/*
Console.Write("Enter the line: ");
string UserString = Console.ReadLine();
string resultHWTask2 = UserString.ToLower();
Console.WriteLine(resultHWTask2);
*/



/* Задача 3 - Задайте произвольную строку. 
Выясните, является ли она палиндромом.

Пример:
"aBcD1ef!-" ==> No
"madam" ==> Yes
"5576755" ==> Yes
*/
/*
bool IsItPalindrome (string startString)
{
    bool areLettersSame = true;
    for (int i = 0; i < startString.Length/2; i++)
    {
        if (startString[i] == startString[startString.Length - i -1])
                areLettersSame = true;
        else areLettersSame = false;    
        if (areLettersSame == false) break;    
    }
    return areLettersSame;
}

Console.Write("Enter the line: ");
string UserString = Console.ReadLine();
if (IsItPalindrome(UserString) == true)
    Console.WriteLine("It IS palindrome");
    else Console.WriteLine("It IS NOT palindrome");
*/

/* Задача 4 - Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами.

Пример:
"Hello my world" ==> "world my Hello"
*/
/*
string GetString (string [] array)
{
    string str_result = "";
    foreach (string word in array)
        str_result = str_result + word + ' '; 
    return str_result;
}
int HowManyWords (string primaryStr)
{
    int count = 0;
    foreach (char e in primaryStr)
        if (e == ' ')
            count ++;
    count ++;
    // Console.WriteLine($"Количество слов: {count}"); // показывает количество слов
    return count;
}
string WordsInReverseOrder(string Str)
{
    string [] ReversedString = new string [HowManyWords(Str)];
    int spaceIndex = 0;
    for (int i = ReversedString.Length-1; i > 0; i--)
        {    
            for (int j = 0; j < Str.Length; j++)
                {
                    if (Str[j] == ' ') break;
                    else 
                    {
                        ReversedString[i] += Str[j];
                        spaceIndex = j+1;
                    }
                } 
            Str = Str.Remove(0, spaceIndex+1);
        }
    ReversedString[0] = Str;
    string result = GetString(ReversedString);
    return result;
}

Console.Write("Enter the line: ");
string userString = Console.ReadLine();
string resultReversedString = WordsInReverseOrder(userString);
Console.WriteLine(resultReversedString);
*/
