using System.Text;

namespace MaskingInput;

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


