namespace Builder.Example2;
public class ProductDirector
{
    private IProductBuilder? _productBuilder;
    public void Construct(IProductBuilder productBuilder){
        _productBuilder = productBuilder;

        _productBuilder
            .AddPart1()
            .AddPart2()
            .AddPart3();
    }
}