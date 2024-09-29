# MaskingInput

The MaskingInput library provides an extension method for masking parts of a string, making it ideal for hiding sensitive information such as credit card numbers or personal identification numbers.

## Installation

You can include this library in your project by adding the source code directly to your solution. Alternatively, you can create a NuGet package for easier distribution.

## Usage

### MaskInput Extension Method

The `MaskInput` method allows you to mask a specified range of characters within a string using a chosen literal character.

#### Method Signature

````csharp
public static string MaskInput(this string numString, int startIndex, int lastIndex, char literal)


``` csharp
using MaskingInput;

class Program
{
    static void Main()
    {
        string original = "1234-5678-9012-3456";
        string masked = original.MaskInput(5, 13, '*');

        Console.WriteLine(masked); // Output: "1234-**********-3456"
    }
}


``` csharp
public static class MaskingExtension
{
    public static string MaskInput(this string numString, int startIndex, int lastIndex, char literal)
    {
        StringBuilder strbuilder = new();
        for (int i = 0; i < numString.Length; i++)
        {
            if (i >= startIndex && i <= lastIndex)
                strbuilder.Append(literal);
            else
                strbuilder.Append(numString[i]);
        }

        return strbuilder.ToString();
    }
}
````
