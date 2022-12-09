// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


string[] array1 = new string[]{ "Russia", "Denmark", "Kazan" }; 
string[] array2 = new string[array1.Length];

void NewArray (string[] array1, string[] array2)
{
    int count = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length < 4)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    
}
string PrintGood(string[] array)
{
  string result = "[ ";
  for(int i = 0; i < array1.Length; i++)
  {
    result +=($"{array[i]} ");
  }
    return result + "]";
}

NewArray(array1, array2);
Console.WriteLine(PrintGood(array2));