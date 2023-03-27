Console.Write("Введите сообщение через (;) без использования пробелов: ");
string message = Console.ReadLine();
/// <summary>
/// Метод, который печатает элементы массива состоящие не более чем из 3 символов
/// </summary>
/// <param name="array">Массив элементов</param>
void PrintArray3Chars (char[] array)
{
int size = array.Length;
for (int j = 0; j < size; j++)
{
  if (array[j] == ' ')
  {
    Console.Write("Массив введен не корректно, используются пробелы!");
    return;
  }
}
int count = -1;
int errorArray = 0;
for (int i = 0; i < size; i++)
{
  count++;
  if (array[i] == ';' && count <= 3)
  {
    while (array[i - count] != ';')
    {
      Console.Write(array[i - count]);
      count--;
    }
    count = -1;
    Console.Write(";");
    errorArray++;
  }
  else if (array[i] == ';' && count > 3)
  {
    count = -1;
  }
}
if (errorArray == 0)
{
  Console.Write("Соответсвующих элементов в массиве нет!");
}
}
PrintArray3Chars(message.ToCharArray());
