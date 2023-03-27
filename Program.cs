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
}