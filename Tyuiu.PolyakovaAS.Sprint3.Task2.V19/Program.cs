using Tyuiu.PolyakovaAS.Sprint3.Task2.V19.Lib;
Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет сумму    *");
Console.WriteLine("*ряда по формуле                                                          *");

Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
Console.WriteLine("Введите начальное значение: ");
int startValue = Convert.ToInt32(Console.ReadLine());
int stopValue = 10;
Console.WriteLine("Конечное значение = " + stopValue);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

var result = ds.GetSumSeries(startValue, stopValue);
Console.WriteLine(result);
Console.ReadKey();