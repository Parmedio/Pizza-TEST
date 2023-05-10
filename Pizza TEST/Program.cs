using Pizza_TEST;
using System;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\ordini";
var OrdersArray = CSVreader.ReadAllCsvRows(ordersdirectory);

for (int i = 0; i < OrdersArray.Length; i++)
{
    string currentString = OrdersArray[i];
    Console.WriteLine(currentString);
}