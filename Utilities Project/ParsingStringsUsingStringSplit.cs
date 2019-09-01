//The following code splits a common phrase into an array of strings for each word.
string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' '); // ' ' shows that the string is split every time there is a space

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//Consecutive separator characters produce the empty string as a value in the returned array. You can see this in the following example, which uses space as a separator:
string phrase = "The quick brown    fox     jumps over the lazy dog.";
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}
/*
Output
<The>
<quick>
<brown>
<>
<>
<>
<fox>
<>
<>
<>
<>
<jumps>
<over>
<the>
<lazy>
<dog.>
*/

//String.Split can use multiple separator characters. The following example uses spaces, commas, periods, colons, and tabs, all passed in an array containing these separating characters, to Split. The loop at the bottom of the code displays each of the words in the returned array.
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo three:four,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

//onsecutive instances of any separator produce the empty string in the output array
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo :,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}
/*
Output
Original text: 'one	two :,five six seven'
7 words in text:
<one>
<two>
<>
<>
<five>
<six>
<seven>
*/

//Seperators can also be a series of strings
string[] separatingStrings = { "<<", "..." };

string text = "one<<two......three<four";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"{words.Length} substrings in text:");

foreach (var word in words)
{
    System.Console.WriteLine(word);
}