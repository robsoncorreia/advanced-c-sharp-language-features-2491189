﻿// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini
// Indexes and Ranges example

// Define a sample array 
string[] words = new string[]
{
    "The","quick","brown","fox","jumps",
    "over","the","lazy","dog"
};

// The index operator provides access to array elements
Console.WriteLine(words[1]);

// TODO: The index-from-end operator indexes from the end of a sequence
// (Note that the end is not zero-based, ^1 is the last item)

Console.WriteLine(words[^1]);

// TODO: The range operator (..) defines a range

string[] wordRange = words[2..5];
System.Console.WriteLine($"{string.Join(",", wordRange)}");
wordRange = words[..];
System.Console.WriteLine($"{string.Join(",", wordRange)}");
wordRange = words[2..];
System.Console.WriteLine($"{string.Join(",", wordRange)}");
wordRange = words[..5];
System.Console.WriteLine($"{string.Join(",", wordRange)}");

// TODO: Indexes and ranges can be variables too
Index idx = ^4;
System.Console.WriteLine( words[idx]);
Range rng = 3..^1;
wordRange = words[rng];
System.Console.WriteLine($"{string.Join(",", wordRange)}");
