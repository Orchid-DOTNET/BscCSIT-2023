namespace ConsoleExamples {
  public class StringDoubleQuotes
  {
    public void adddoubleQuotes()
    {
      Console.WriteLine("Enter String:");

      string val = Console.ReadLine();

      string[] arrVal = val.Split(" ");

      for (int i = 0; i < arrVal.Length; i++) {
        Console.WriteLine("\""+ arrVal[i] + "\"");
      }
      
    }
  }
}