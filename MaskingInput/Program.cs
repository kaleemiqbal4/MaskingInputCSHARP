using MaskingInput;

Console.WriteLine("Eneter a Number which you want to mask");
string inputToMask = Console.ReadLine();
if (inputToMask is not null && inputToMask.Length < 10)
{
    throw new Exception("Number must be greater than 9 digit");
}
int startIndex = 0, lastIndex = 6;
char maskedChar = '#';
var maskedResult = inputToMask.MaskInput(startIndex, lastIndex, maskedChar);
Console.WriteLine($"Masked Number is {maskedResult}");
Console.ReadLine();