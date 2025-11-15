using Tyuiu.PolyakovaAS.Sprint3.Task5.V13.Lib;
DataService ds = new DataService();
Console.WriteLine("* Исходные данные:                                                        *");
int s = 1, e = 3, s1 = 1, e1 = 12;
Console.WriteLine("* Начальное значение 1: " + s);
Console.WriteLine("* Конечное значение 1: " + e);
Console.WriteLine("* Начальное значение 2: " + s1);
Console.WriteLine("* Конечное значение 2: " + e1);
Console.WriteLine("* Результат:                                                              *");
Console.WriteLine(ds.GetSumSumSeries(5, s, e, s1, e1));

