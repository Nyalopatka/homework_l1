Console.Clear();
// изменять "n1" для замены 1 переменной
int n1 = 2;
//изменять "n2" для замены 2 переменной
int n2 = 10;
int max = n1;
int min = n2;
if (n1 > n2) max = n1 ; min  = n2;
if (n2 > n1) max = n2 ; min = n1;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);