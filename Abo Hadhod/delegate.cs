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

//namespace AboHadhod;

// مثال اخر
//بعد دلقيت
//public class Program
//{
//    delegate bool ShoudCalculate(Employee employee);
//    public class Employee
//    {
//        public string Name { get; set; }
//        public int BasicSalary { get; set; }
//        public int Deduction { get; set; }
//        public int Bonus { get; set; }

//    }
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new();
//        for (var i = 0; i < 10; i++)
//        {
//            employees.Add(new Employee
//            {
//                Name = $"Employee {i}",
//                BasicSalary = Random.Shared.Next(1000, 5001),
//                Deduction = Random.Shared.Next(0, 501),
//                Bonus = Random.Shared.Next(0, 1001)
//            });
//        }
//        CalculatwSalaries(employees, e => e.BasicSalary <= 2000);

//    }

//    private static void CalculatwSalaries(List<Employee> employees, ShoudCalculate predicate) // => الدلقيت الي ترجع بولين تسمى بريدكت
//    {
//        foreach (var employee in employees)
//        {
//            if (predicate(employee)) // => = true
//            {
//                var salary = employee.BasicSalary + employee.Bonus - employee.Deduction;
//                Console.WriteLine($"Salary for employee `{employee.Name}` = `{salary}`");
//            }
//        }
//    }
//}

//قبل الدلقيت
//public class Program
//{

//    public class Employee
//    {
//        public string Name { get; set; }
//        public int BasicSalary { get; set; }
//        public int Deduction { get; set; }
//        public int Bonus { get; set; }

//    }
//    static void Main(string[] args)
//    {
//        List<Employee> employees = new();
//        for(var i = 0; i <10; i++)
//        {
//            employees.Add(new Employee
//            {
//                Name = $"Employee {i}",
//                BasicSalary = Random.Shared.Next(1000, 5001),
//                Deduction = Random.Shared.Next(0, 501),
//                Bonus = Random.Shared.Next(0, 1001)
//            });
//        }
//        CalculatwSalaries(employees, 2000);

//    }

//    private static void CalculatwSalaries(List<Employee> employees, int basic)
//    {
//        foreach (var employee in employees)
//        {
//            if (employee.BasicSalary <= basic)
//            {
//                var salary = employee.BasicSalary + employee.Bonus - employee.Deduction;
//                Console.WriteLine($"Salary for employee `{employee.Name}` = `{salary}`");
//            }
//        }
//    }
//}





// بعد الدلقت
//public class Program
//{
//    delegate int CalculateDelegate(int num1, int num2); 
//    static void Main(string[] args)
//    {
//        int num1 = 10;
//        int num2 = 2;
//        CalculateWithDelegate(num1, num2, Add);
//        CalculateWithDelegate(num1, num2, Sub);
//        CalculateWithDelegate(num1, num2, Multiply);
//        CalculateWithDelegate(num1, num2, Divide);
//        CalculateWithDelegate(num1, num2, delegate (int num1,int num2) { return num1 * num2; }); //  انونمس مالهش اسم
//        CalculateWithDelegate(num1, num2, (int num1, int num2) => num1 * num2); // هذا افضل سنتكس اسمها Lampda Expression لمدا اكسبريشن
//        CalculateWithDelegate(num1, num2, (x, y) => x * y); //ابسط اختصار
//        // هذا الاخير لا يحتاج ناخذ من فانكشن
//    }

//    static void CalculateWithDelegate(int num1, int num2, CalculateDelegate dle)
//    {
//        int result = dle(num1, num2);

//        Console.WriteLine(result);
//    }

//    static int Add(int num1, int num2)
//    {
//        Console.WriteLine("Add");
//        return num1 + num2;

//    }
//    static int Sub(int num1, int num2)
//    {
//        Console.WriteLine("Sub");
//        return num1 - num2;

//    }
//    static int Multiply(int num1, int num2)
//    {
//        Console.WriteLine("Multiply");
//        return num1 * num2;

//    }
//    static int Divide(int num1, int num2)
//    {
//        Console.WriteLine("Divide");
//        return num1 / num2;

//    }
//}



// قبل الدلقت
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


