namespace Builder.Example1;

public class Process2QueryBuilder : IQueryBuilder
{
    private FinalQuery _finalQuery;
    public Process2QueryBuilder(){
        _finalQuery =new FinalQuery();
    }
    public void Step1()
    {
        _finalQuery.Query = "Process2 Step 1";
    }

    public void Step2()
    {
        _finalQuery.Query =  $"{_finalQuery.Query} | Process2 Step 2";
    }

    public void Step3()
    {
        _finalQuery.Query =  $"{_finalQuery.Query} | Process2 Step 3";
    }

    public FinalQuery GetFinalQuery()
    {
        return _finalQuery;
    }
}