namespace Builder.Example1;

public class QueryDirector
{
    private IQueryBuilder? _queryBuilder;

    public void Construct(IQueryBuilder queryBuilder)
    {
        _queryBuilder = queryBuilder;
        _queryBuilder.Step1();
        _queryBuilder.Step2();
        _queryBuilder.Step3();
    }
}