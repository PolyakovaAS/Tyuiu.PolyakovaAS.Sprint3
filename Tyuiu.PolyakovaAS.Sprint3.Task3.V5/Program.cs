using Tyuiu.PolyakovaAS.Sprint3.Task3.V5.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "fifa al fall";
char replaceable = 'a', replacement = '*';

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.Write("Новая строка: " + ds.ReplaceCharInString(value, replaceable, replacement));
Console.ReadKey();

