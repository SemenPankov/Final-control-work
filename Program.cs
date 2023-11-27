string[] arrayText1 = new string [] {"привет", "мир", "2", "круто", "67", "город", "башня", "сыр", "да"};
string[] arrayText2 = new string [arrayText1.Length];
int count = 0;
for (int i = 0; i < arrayText1.Length; i++)
{
  System.Console.Write($"{arrayText1[i]}, ");
}
System.Console.Write("-> ");
for (int i = 0; i < arrayText1.Length; i++)
{
  count = arrayText1[i].Length;
  if (count <= 3)
  {
    for (int j = 0; j < arrayText2.Length - (arrayText1.Length - 1); j++)
    {
      arrayText2[j] = arrayText1[i];
      System.Console.Write($"{arrayText2[j]}, ");
    }
  }
}
