/* 
 * Fredrik Nellbeck
 * .NET23_OOP
 * Systemutveckling.Net med AI-kompetens
*/

int Number = 6; // Variable with the name "Number" that holds the number 6
if (Number < 10)
{
    Console.WriteLine("Oj. Lågt tal!");
}
else 
{
    Console.WriteLine("Talet är stort!");
}   // Checks to see if the int variable are more then 10 or less. Writes diffrent text out to the console depending on the outcome.

Console.WriteLine(); // Just to get some space in the console.

Console.WriteLine("Vad heter du?");
string Name = Console.ReadLine();
Console.WriteLine($"Hej {Name}!"); // Asks the user to type in their name and then write it out to the console.
 
Console.WriteLine(); // Just to get some free space between the lines in the console.

int LoopNumber = 0;
while (LoopNumber < Number) 
{
    Console.WriteLine(LoopNumber);
    LoopNumber++;
} // A loop that checks if the number is less then 7. if so it writes the number and adds 1 to that number and then checks again.
Console.ReadKey();
