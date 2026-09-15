using System.Diagnostics;
Console.WriteLine("Enter a character:");
char originalCharacter = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the shift amount:");
int shiftAmount = int.Parse(Console.ReadLine());
int shiftedCode = (int)originalCharacter + shiftAmount;
char shiftedCharacter = (char)shiftedCode;
Console.WriteLine("Shifted character: ");
Console.WriteLine(shiftedCharacter);
int offset = (int)originalCharacter - (int)'a';
int shiftedOffset = (offset + shiftAmount) % 26;
char shiftedCharacter1 = (char)('a' + shiftedOffset);
Console.WriteLine("Shifted character using offset: ");
Console.WriteLine(shiftedCharacter1);
//1. because it is the programming language and that is how it works
//2.because it is it own expressions so it needs the () to make it work
//3.25
//4. yes it does it offsets it,it by the amount of the shift and then it wraps around to the beginning of the alphabet if it goes past 'z'
//5. % 26 shifts any number back into the range of 0-25, which corresponds to the letters of the alphabet. This ensures that if the shift goes past 'z', it wraps around to the beginning of the alphabet.
//6. 1.3
Console.Write("Points earned: ");
string earnedInput = Console.ReadLine();
int pointsEarned = int.Parse(earnedInput);

Console.Write("Points possible: ");
string possibleInput = Console.ReadLine();
int pointsPossible = int.Parse(possibleInput);
double percentage = (double)pointsEarned / pointsPossible * 100;
Console.WriteLine($"Correct way: {percentage}");
int percentageInt = (int)percentage;
int gradeIndex = (99 - percentageInt) / 10;
Console.WriteLine(gradeIndex);
char grade = gradeIndex <= 0 ? 'A'
           : gradeIndex == 1 ? 'B'
           : gradeIndex == 2 ? 'C'
           : gradeIndex == 3 ? 'D'
           : 'F';
Console.WriteLine($"Grade: {grade}");
Console.WriteLine($"You earned {percentage:F1}% -- that's a {grade}.");
//1. bacause it is the prymary command that is how it works
//2. it walnt to symplify the end result and make it easier to read
//3. explit is make it more clear and readable
//4. 120 out of 5 
//5. we want to make the program more user friendly 
//6. it leavs room to let it run smoother 
//7. yes
//8. it  wants to run the first part before it runs the second part
//9. beacuse anything lower than D will just go into F 
//10. it will just not run the program and it will not give you a grade
