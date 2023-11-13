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
    throw new NotImplementedException();
  }

  public int[] Sort(int[] inputArr)
  {
    throw new NotImplementedException();
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
    throw new NotImplementedException();
  }
}
