// Event  هو اشعار تنبيه عشان انبهم ان في حاجه مهمه حصلت
// الايفنت ما يرجع داتا
// علامة البرق تعني انه ايفنت event وعلامة السهم نحو الاسفل يعني اكستنشن ميذد extension methode 
// الايفنت مرتبط بالدلقت

public class Program // يقال عنها سبسكرابير
{


    static void Main(string[] args)
    {
        List<Employee> employees = new();
        for (var i = 0; i < 10; i++)
        {
            employees.Add(new Employee
            {
                Name = $"Employee {i}",
                BasicSalary = Random.Shared.Next(1000, 5001),
                Deduction = Random.Shared.Next(0, 501),
                Bonus = Random.Shared.Next(0, 1001)
            });
        }
        var calculator = new SalaryCalculate();
        calculator.EmployeeSalaryCalculated += LogEmployeeSalary; // مالتي كاست دبقت
        calculator.EmployeeSalaryCalculated += (employees, salary) => Console.WriteLine($"Payslip`{employees.Name}`");

        calculator.CalculatwSalaries(employees, e => e.BasicSalary >= 2000);

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