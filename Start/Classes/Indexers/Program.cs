// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Using class indexers

// Create a new sample data set
StockRecord stock1 = new StockRecord();

// Access a couple of the properties
Console.WriteLine($"Average: {stock1.Average:C}");
Console.WriteLine($"High: {stock1.High:C}");
Console.WriteLine($"Low: {stock1.Low:C}");

// TODO: Use the indexer method

System.Console.WriteLine( $"Days: {stock1.Length}");

// for (int i = 0; i < stock1.Length; i++)
// {
//     System.Console.WriteLine($"Val: {stock1[i]:C}");
// }

// TODO: Index using a different value
System.Console.WriteLine($"Monday: {stock1["mon"]:C}");
System.Console.WriteLine($"Wednesday: {stock1["wed"]:C}");              
System.Console.WriteLine($"Wednesday: {stock1["teste"]:C}");              
