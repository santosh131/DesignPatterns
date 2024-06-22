namespace Builder.Example1;

public interface IQueryBuilder{
    void Step1();
    void Step2();
    void Step3();

    FinalQuery GetFinalQuery();
}