////Task-Based Asynchronous Pattern (TAP)
//// sonchronous معناها بلوكنق 
//// ينفذ الصدر الاولاني ويحصل بلوك اي يستنى الصدر الاول لما يخلص وينتقل للصدر الي بهده

//// Asonchronous نن بلوكنق
//// ينفض الصدر الاول وينفذ الصدر الثاني وميستناش تنفيذه يتفذ براحته ينتقل ينفذ الصدر الذي بعدة

////task ابريشن بتنفذ ابريشن اسنكرونس
////فايدته ان في حاجه شغاله في الباكقراوند وانت مش شاعل نفسك بيها ووقت ماتخلص تخلص

//// await استنا التسك لما يخلص

//// async ماترجعش حاجه زي الفويد اذا كانت async Task فقط اما اذا كانت async Task<int> ضروري ترجع
//public class Program
//{


//    static async Task Main(string[] args)
//    {
//        var cts = new CancellationTokenSource();
//        var task1 = ProcessBatch1(cts.Token);
//        var task2 = ProcessBatch2(cts.Token);
//        // هذه معناها انتظر كل التاسكات تخلصت ثم نفذ الي بعدهم
//        await Task.WhenAll(task1, task2);

//        Console.WriteLine("Please enter yor name");
//        var name = Console.ReadLine();
//        Console.WriteLine($"Your name is {name}");
//        Console.ReadKey();

//    }

//    private static object _lock = new();
//    private static async Task ProcessBatch1(CancellationToken cancellationToken)
//    {

//        for (var i = 1; i <= 100; i++)
//        {
//            if (cancellationToken.IsCancellationRequested)
//                return;
//            // lock عملها تحط قفل على الكود الي داخلها
//            await Task.Delay(500);

//            lock (_lock)
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine(i);
//                Console.ForegroundColor = ConsoleColor.White;

//            }
//        }
//        return;
//    }
//    private static async Task ProcessBatch2(CancellationToken cancellationToken)
//    {

//        for (var i = 101; i <= 200; i++)
//        {
//            if (cancellationToken.IsCancellationRequested)
//                return;
//            // lock عملها تحط قفل على الكود الي داخلها
//            await Task.Delay(500);
//            lock (_lock)
//            {
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine(i);
//                Console.ForegroundColor = ConsoleColor.White;

//            }
//        }
//        return;
//    }


//}

