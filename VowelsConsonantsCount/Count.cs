// field to store the count of vowels
int vowelsCount = 0;
// field to store the count of consonants
int consonentsCount = 0;
// array of vowels chars
string[] vowels = { "a", "e", "i", "o", "u" };
Console.WriteLine("Please enter the string:");
// take input from user
string? userInput = Console.ReadLine();
if(userInput != null)
{
    // remove the duplicate characters
    IEnumerable<char> lettersArr = userInput.ToCharArray().Distinct();
    for (int index = 0; index < lettersArr.Count(); index++)
    {
        // match the character with vowel array, if match is successful, increment the count
        if (vowels.Any(character => character == lettersArr.ElementAt(index).ToString().ToLower()))
            vowelsCount++;
        // if match is unsuccessful, increment the consonant count
        else if (!Char.IsWhiteSpace(lettersArr.ElementAt(index)))
            consonentsCount++;
    } 
}
// print out the counts
Console.WriteLine("Number of vowels are: {0}", vowelsCount);
Console.WriteLine("Number of consonents are: {0}", consonentsCount);
