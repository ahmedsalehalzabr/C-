// extension methods
// الكلاس والميذد تكون استاتك نضيف للميذد this

//int percen = 10;
////if (IntExtension.IsBetween(percen , 0 , 100)) => instence method
//if (percen.IsBetween(0, 100)) // => extension method
  
//    Console.WriteLine("valid");
//else
//    Console.WriteLine("Invalid");


Console.WriteLine("Enter value:");
var input = Console.ReadLine();
Console.WriteLine(input.Remove().Reverse());




public static class IntExtension
{
    public static bool IsBetween(this int value, int min, int max)
    {
        return value >= min && value <= max;
    }
    public static string Remove(this string value)
    {
        return value.Replace(" ", "");
    }
    public static string Reverse(this string value)
    {
       var charArry = value.ToCharArray();
        Array.Reverse(charArry);
        return new string(charArry);
    }
}