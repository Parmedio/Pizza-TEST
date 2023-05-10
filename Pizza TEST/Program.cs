using Pizza_TEST;
using Pizza_TEST.Model;
using System;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\orders";
var receiptdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\receipts";

IOrder[] OrdersArray = CSVreader.ReadAllCSV(ordersdirectory);

for (int i = 0; i < OrdersArray.Length; i++)
{
    Console.WriteLine($"receipt number: {OrdersArray[i].GetOrderID()}\nPizza:\n{OrdersArray[i].GetOrderPizzas()[0].GetTopping()}\nReceipt subtotal: {OrdersArray[i].GetOrderSubtotal()}\n\n\n==============================================\n\n\n");
}

//ReceiptLogger.GenerateCSVReceipt(OrdersArray, receiptdirectory);