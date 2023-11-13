using System.Text;

namespace MiniKatas;

public class MathFunctions
{
  public int Multiply(int a, int b)
  {
    return a * b;
  }

  public int Divide(int a, int b)
  {
    return a != 0 && b != 0 ? (a / b) : throw new ArgumentException("Cannot divide by 0");
  }
}

public class ListFunctions
{
  public int Smallest(int[] inputArr)
  {
    return inputArr.Min();
  }

  public int[] Sort(int[] inputArr)
  {
    int[] sortedArray = inputArr.OrderBy(x => x).ToArray();
    return sortedArray;
  }
}

public class StringFunctions
{
  public string NoSpaces(string input)
  {
    StringBuilder result = new();
    foreach (char c in input)
    {
      if (char.IsLetterOrDigit(c))
      { 
        result.Append(c);
      }
    }
    result.Replace(" ", "");
    return result.ToString().ToLower();
  }

  public string EmailMaker(string input)
  {
    foreach (char c in input)
    {
      if (char.IsLetterOrDigit(c) != true)
      {
        throw new Exception("Special characters are not allowed");
      }
    }
    var formattedString = input.Replace(" ", ".");
    return formattedString + "@gmail.com";
  }
}
