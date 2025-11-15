using Tyuiu.PolyakovaAS.Sprint3.Task6.V21.Lib;

DataService ds = new DataService();


int startValue = 19;
int stopValue = 30;




Console.WriteLine("Начало отрезка = " + startValue);
Console.WriteLine("Конец отрезка = " + stopValue);



Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

Console.ReadKey();