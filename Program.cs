using System;
namespace Cspassgen;
 
class Program {
  static void Main(string[] args){

    GeneratePassword.Generate();
  }
}

public static class GeneratePassword{
  private static string qLetters="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
  private static string qDigits="1234567890";
  private static string qChars="!\"#$%&'()*+,-./:;<=>?@[]^_`{|}~";

  public static void Generate(int Length=8){
    Console.WriteLine($"Input the desired length:\t");
    try{
      Length=Convert.ToInt32(Console.ReadLine());
    }catch{
      Length=8;
    }
    string qString=$"{qLetters}{qLetters.ToLower()}{qDigits}{qChars}";
    char[] pwd=new char[Length];
    Random rand=new Random();
    for(int xd=0; xd<Length; xd++){
      pwd[xd]=qString[rand.Next(qString.Length-1)];
    }
    Console.WriteLine(":\t"+string.Join(null, pwd));
    Console.ReadKey();
  }
}