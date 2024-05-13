string alice = @"Alice was beginning to get very tired of sitting by her sister on the
bank, and of having nothing to do: once or twice she had peeped into the
book her sister was reading, but it had no pictures or conversations in
it, 'and what is the use of a book,' thought Alice 'without pictures or
conversation?'";
Console.WriteLine(alice);
Console.WriteLine("Which sentence would you like to look for in the text above?");
string searchTerm = Console.ReadLine();
string compSearchTerm = searchTerm.ToLower();
string compAlice = alice.ToLower();
if(compAlice.IndexOf(compSearchTerm, 0) != -1)
{
    Console.WriteLine("true");
    int word = compAlice.IndexOf(compSearchTerm);
    int wordLength = compSearchTerm.Length;
    Console.WriteLine(word);
    Console.WriteLine(wordLength);
    string myWord = compAlice.Substring(word,wordLength);
    Console.WriteLine(myWord);
}
else{
    Console.WriteLine("false");
}
