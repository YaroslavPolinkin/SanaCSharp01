﻿double a, b, x, m, n, z1, z1_1, z2, y;

a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
x = double.Parse(Console.ReadLine());
m = double.Parse(Console.ReadLine());
n = double.Parse(Console.ReadLine());

z1 = (m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n);
z1_1 = Math.Sqrt(Math.Pow(m, 3) * n) + m * n + Math.Pow(m, 2) - m;
z1 /= z1_1;

Console.WriteLine("z1 = {0}", z1);
z2 = (Math.Sqrt(m) - Math.Sqrt(n) / m);
Console.WriteLine("z2 = {0}", z2);
y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
Console.WriteLine("y = {0}", y);