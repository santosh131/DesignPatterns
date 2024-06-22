namespace Builder.Example2;
public class Process1ProductBuilder : IProductBuilder
{
    private FinalProduct _finalProduct;
    public Process1ProductBuilder()
    {
        _finalProduct = new FinalProduct(); 
    }
    public IProductBuilder AddPart1()
    {
        _finalProduct.FinalString = "Process1 Added part 1";
        return this;
    }
    public IProductBuilder AddPart2()
    {
        _finalProduct.FinalString = $"{_finalProduct.FinalString} | Process1 Added part 2";
        return this;
    }
    public IProductBuilder AddPart3()
    {
        _finalProduct.FinalString = $"{_finalProduct.FinalString} | Process1 Added part 3";
        return this;
    }

    public FinalProduct GetFinalProduct()
    {
        return _finalProduct;
    }
}