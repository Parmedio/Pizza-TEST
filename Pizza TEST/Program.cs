using Pizza_TEST;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\orders";
var receiptdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\receipts";

ReceiptLogger.GenerateCSVReceipts(CSVreader.ReadAllCSV(ordersdirectory), receiptdirectory);