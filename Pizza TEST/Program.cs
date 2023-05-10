using Pizza_TEST;
using System;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\orders";
var receiptdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\receipts";

var OrdersArray = CSVreader.ReadAllCsvRows(ordersdirectory);

for (int i = 0; i < OrdersArray.Length; i++)
{
    int currentReceiptID = OrdersArray[i].Item1;
    string currentReceiptPizza = OrdersArray[i].Item2;
    //Console.WriteLine($"{OrdersArray[i]}");
    Console.WriteLine($"{currentReceiptID} - {currentReceiptPizza}");
}

//ReceiptLogger.GenerateCSVReceipt(OrdersArray, receiptdirectory);