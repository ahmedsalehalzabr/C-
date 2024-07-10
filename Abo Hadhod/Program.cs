// Multithreading
// thread بياخذ دلقيت وهي الخذ برميتر واحد نوعة ابجكت او ماتاخذ ولا حاجه
// الثرتز لا تتنفذ مع بعض ولكن عملية السوتشنك تسبب الدتداخل
public class Program 
{
   

    static void Main(string[] args)
    {
        var th1 = new Thread(ProcessBatch1);
        th1.Priority = ThreadPriority.Highest;
        var th2 = new Thread(ProcessBatch2);
        th2.Priority = ThreadPriority.Lowest;
        
        th1.Start();
        th2.Start();



        //List<Employee> employees = new();
        //for (var i = 0; i < 10; i++)
        //{
        //    employees.Add(new Employee
        //    {
        //        Name = $"Employee {i}",
        //        BasicSalary = Random.Shared.Next(1000, 5001),
        //        Deduction = Random.Shared.Next(0, 501),
        //        Bonus = Random.Shared.Next(0, 1001)
        //    });
        //}
        //var calculator = new SalaryCalculate();
        //calculator.EmployeeSalaryCalculated += LogEmployeeSalary; // مالتي كاست دبقت
        //calculator.EmployeeSalaryCalculated += (employees, salary) => Console.WriteLine($"Payslip`{employees.Name}`");

        //calculator.CalculatwSalaries(employees, e => e.BasicSalary >= 2000);

    }

    private static object _lock = new();
    private static void ProcessBatch1()
    {
        for(var i = 0; i <= 100; i++)
        {
            // lock عملها تحط قفل على الكود الي داخلها

            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
    private static void ProcessBatch2()
    {
        for (var i = 101; i <= 200; i++)
        {
            lock (_lock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(i);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }

    private static void LogEmployeeSalary(Employee employee, int salary)
    {
    Console.WriteLine($"Salary for employee `{employee.Name}` = {salary}");
    }
}


public class SalaryCalculate // اسمه بابلشر يعني الناشر
{
    public delegate bool ShoudCalculate(Employee employee);

    // الايفنت مع الدلقيت تبعه
    public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated; 
    public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);
    public void CalculatwSalaries(List<Employee> employees, ShoudCalculate predicate) // => الدلقيت الي ترجع بولين تسمى بريدكت
    {
        foreach (var employee in employees)
        {
            if (predicate(employee)) // => = true
            {
                var salary = employee.BasicSalary + employee.Bonus - employee.Deduction;
                //if(EmployeeSalaryCalculated is not null)
                //{
                //    EmployeeSalaryCalculated(employee, salary); // اسم الايفنت مع البرميتر تبعه

                //}

                EmployeeSalaryCalculated?.Invoke(employee, salary); // هذه الطريقه نفس عمل الي فوقها
            }
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public int BasicSalary { get; set; }
    public int Deduction { get; set; }
    public int Bonus { get; set; }

}