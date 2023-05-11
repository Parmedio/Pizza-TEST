using Pizza_TEST;

var ordersdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\orders";
var receiptdirectory = "C:\\Users\\student\\source\\repos\\DesignPattern\\Pizza TEST\\receipts";

ReceiptLogger.GenerateReceiptFiles(OrderReader.ReadAllOrders(ordersdirectory, "csv"), receiptdirectory, "docx");