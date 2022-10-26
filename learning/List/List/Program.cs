string sentence = Console.ReadLine();
string[] sentencelist = sentence.Split(" ");

int longWordCount = 0;
int wordcount = 0;
foreach (string word in sentencelist)
{
    if (word.Count() > 5)
    {
        longWordCount++;
    }


    wordcount=wordcount+1;
    Console.WriteLine(word);
}
Console.WriteLine(wordcount);
Console.WriteLine(longWordCount);