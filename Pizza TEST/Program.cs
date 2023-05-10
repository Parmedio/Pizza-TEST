using Pizza_TEST;
using System;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\ordini";
var OrdersArray = CSVreader.ReadAllCsvRows(ordersdirectory);

//for (int i = 0; i < OrdersArray.Length; i++)
//{
//    int currentString = OrdersArray[i].Item1;
//    Console.WriteLine(currentString);
//}

ReceiptPrinter.GenerateCSVReceipt(OrdersArray, ordersdirectory);