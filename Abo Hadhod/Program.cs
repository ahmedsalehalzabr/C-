// Recursion ريكرجن مثال يعطي مضروب الرقم
// f(5) = 5*4*3*2*1
// static int CalculateFactorial(int number)
//{
//    if (number <= 1)
//        return number;

//    return number * CalculateFactorial(number - 1);
//}

//Console.WriteLine(CalculateFactorial(5));



// Delegates => فانكشن بوينتر نستخدمها لي يكون لنا رفرنس لميذد معينه اقدر اناديها في اي وقت من غير ماكون عارف مين هي ديه الميذد اصلا ولا موجوده فين
// الي كل اعرفه عنها عدد البراميتر

namespace AboHadhod;

public class Program
{
    delegate int CalculateDelegate(int num1, int num2); 
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 2;
        CalculateWithDelegate(num1, num2, Add);
        CalculateWithDelegate(num1, num2, Sub);
        CalculateWithDelegate(num1, num2, Multiply);
        CalculateWithDelegate(num1, num2, Divide);
        CalculateWithDelegate(num1, num2, delegate (int num1,int num2) { return num1 * num2; }); //  انونمس مالهش اسم
        CalculateWithDelegate(num1, num2, (int num1, int num2) => num1 * num2); // هذا افضل سنتكس اسمها Lampda Expression لمدا اكسبريشن
        CalculateWithDelegate(num1, num2, (x, y) => x * y); //ابسط اختصار
    }

    static void CalculateWithDelegate(int num1, int num2, CalculateDelegate dle)
    {
        int result = dle(num1, num2);
      
        Console.WriteLine(result);
    }

    static int Add(int num1, int num2)
    {
        Console.WriteLine("Add");
        return num1 + num2;

    }
    static int Sub(int num1, int num2)
    {
        Console.WriteLine("Sub");
        return num1 - num2;

    }
    static int Multiply(int num1, int num2)
    {
        Console.WriteLine("Multiply");
        return num1 * num2;

    }
    static int Divide(int num1, int num2)
    {
        Console.WriteLine("Divide");
        return num1 / num2;

    }
}




//public class Program
//{
//    static void Main(string[] args)
//    {
//        int num1 = 10;
//        int num2 = 2;
//        Calculate(num1, num2, '+');
//        Calculate(num1, num2, '-');
//        Calculate(num1, num2, '*');
//        Calculate(num1, num2, '/');

//    }

//    static void Calculate(int num1, int num2, char o)
//    {
//        int result = 0;
//        if (o == '+')
//            result = num1 + num2;
//        else if (o == '-')
//            result = num1 - num2;
//        else if (o == '*')
//            result = num1 * num2;
//        else if (o == '/')
//            result = num1 / num2;
//        else
//            throw new ArgumentException("Invalid");
//        Console.WriteLine(result);
//    }

//}