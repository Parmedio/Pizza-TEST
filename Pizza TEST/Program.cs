using Pizza_TEST;
using Pizza_TEST.Model;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\orders";
var receiptdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\receipts";

ReceiptLogger.GenerateCSVReceipts(CSVreader.ReadAllCSV(ordersdirectory), receiptdirectory);