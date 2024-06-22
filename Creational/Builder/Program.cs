using Builder.Example1;
using Builder.Example2;
namespace Builder;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------Builder----------------");
        Console.WriteLine("----------------Example1----------------");
        IQueryBuilder p1QueryBuilder = new Process1QueryBuilder();
        IQueryBuilder p2QueryBuilder = new Process2QueryBuilder();

        QueryDirector queryDirector = new QueryDirector();

        queryDirector.Construct(p1QueryBuilder);
        FinalQuery finalQuery1 = p1QueryBuilder.GetFinalQuery();

        queryDirector.Construct(p2QueryBuilder);
        FinalQuery finalQuery2 = p2QueryBuilder.GetFinalQuery();

        Console.WriteLine($"Query for Process1 --> {finalQuery1.Query}");
        Console.WriteLine($"Query for Process2 --> {finalQuery2.Query}");

        Console.WriteLine("----------------Example2----------------");
        IProductBuilder product1Builder = new Process1ProductBuilder();
        IProductBuilder product2Builder = new Process2ProductBuilder();

        ProductDirector productDirector = new ProductDirector();
        productDirector.Construct(product1Builder);
        FinalProduct finalProduct1 = product1Builder.GetFinalProduct();

        productDirector.Construct(product2Builder);
        FinalProduct finalProduct2 = product2Builder.GetFinalProduct();
        
        Console.WriteLine($"Product for Process1 --> {finalProduct1.FinalString}");
        Console.WriteLine($"Product for Process2 --> {finalProduct2.FinalString}");
    }
}
