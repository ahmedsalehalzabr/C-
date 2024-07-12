
//LINQ//LINQ فايدتها تنفيذ مؤجل
// الكويري تتنفذ لما تعمل عليها لوب
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program 
{
    /* 
     * projection and Filtering (select , where , Oftype )
     * Sorting (OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse)
     * Quantifiers (All,Any, Contains)
     * Partitioning (Skip, SkipWhile, Take, TakeWhile, Chunk)
     * Set Operations (Distinct, DistinctBy, Except. exeptBy, Intersect, IntersectBy, Union, UnionBy)
     * Joins (Join, GroupJoen)
     * Grouping (GroupBy, ToLookup)
     */


    static async Task Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        //اسم الطريقه كويري اكسبريسن 
        var result = from number in numbers where number >5 select number;
        // اسمها method syntax
        result = numbers.Where(x => x > 8);
        // ميديت اكسكيوشن
        //var result = (from number in numbers where number > 5 select number).ToList();
        foreach ( var number in result)
        {
            Console.WriteLine( number );
        }
        Console.WriteLine("-------------------------");
        numbers.AddRange(new int[] { 13, 14, 15 }); // or with list   numbers.AddRange(new List<int> { 13, 14, 15 });
        foreach ( var number in result)
        {
            Console.WriteLine(number);
        }
      



        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        //var result = from number in numbers where number > 5 select number;
        //foreach (var number in result)
        //{
        //    Console.WriteLine(number);
        //}
        // نفس العمل باستخدام LINQ
        //var result = new List<int>();
        //foreach (var number in numbers)
        //{
        //    if(number > 5)
        //    {
        //        result.Add(number);
        //        Console.WriteLine(number);
        //    }
        //}

    }

 
}




