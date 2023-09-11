double[] array = new double[4];


Method1 met1 = new Method1();
Method2 met2 = new Method2();
Method3 met3 = new Method3();


met1.Rand(array);
met2.Write(array);
met3.MM(array);

Console.WriteLine($" -> {Method3.diff}");

