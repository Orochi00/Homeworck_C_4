Random rnd_1 = new Random();
Byte[] b = new Byte[5];
rnd_1.NextBytes(b);
Console.WriteLine(" ");
for (int i = 0; i <= b.GetUpperBound(0); i++)
    Console.Write("{1} ", i, b[i]);
Random rnd_2 = new Random();
Byte[] d = new Byte[3];
rnd_2.NextBytes(d);
Console.WriteLine(" ");
for (int i = 0; i <= d.GetUpperBound(0); i++)
    Console.Write("{1} ", i, d[i]);