Console.Clear();
//заменить "a" , чтобы поменять значение 1 переменной
int a = 2;
//заменить "b" , чтобы поменять значение 2 переменной
int b = 3;
//заменить "c" , чтобы поменять значение 3 переменной
int c = 7;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
