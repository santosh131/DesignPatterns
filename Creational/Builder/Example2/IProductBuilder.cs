namespace Builder.Example2;

public interface IProductBuilder
{
    //All these methods return type is IBuilder.
    //This will help us to apply method chaining.
    IProductBuilder AddPart1();
    IProductBuilder AddPart2();
    IProductBuilder AddPart3();

    FinalProduct GetFinalProduct();
}