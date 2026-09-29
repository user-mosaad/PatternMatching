// -----------
// 'is' keyword
// Before C# 7.0
object obj = "Hello world";

if (obj is string)
{
    // The type is verified, but you still have to cast it manually.
    string str = (string)obj;
    Console.WriteLine(str.Length);
}

// Modern usage
object objy = "Hello world";

// Checks if 'objy' is a string. If true, extracts it into 'message'
if (objy is string message)
{
    Console.WriteLine($"Success! Length is: {message.Length}");
}

// -----------
// 'as' keyword
object obj1 = "Hello world";
object obj2 = 123;

// Successful cast
string? str1 = obj1 as string;

// Failed cast
string? str2 = obj2 as string; // Fails. str2 becomes null (no exception thrown)

if (str1 is not null)
{
    Console.WriteLine(str1.Length);
}
else
{
    Console.WriteLine("The object could not be cast to a string.");
}


if (str2 is not null)
{
    Console.WriteLine(str2.Length);
}
else
{
    Console.WriteLine("The object could not be cast to a string.");
}
