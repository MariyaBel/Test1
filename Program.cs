// // Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// //Первоначальный массив вводится либо с клавиатуры либо задается на старте алгоритма.Не пользоваться коллекциями, только массивами


Console.Clear();

Console.Write("Input number of elements in the array: ");

int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];// задан строковый массив
int strlength = 3;// длина строки, по которой осуществляется выбор
int k = 0;// длина второго массива
Console.Write("Input element of the array: ");
for (int i = 0; i < array.Length; i++)// цикл заполнения массива и подсчет кол-ва эл-тов 1го массива
{
    array[i] = Console.ReadLine();
    if (array[i].Length <= strlength) k++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

string[] releasearray = new string[k];// задан второй массив
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= strlength)
    {
        releasearray[j] = array[i];
        j++;
    }
}
Console.WriteLine("[" + string.Join(", ", releasearray) + "]");// печать второго массива
