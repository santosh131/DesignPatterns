using Microsoft.Extensions.DependencyInjection;
using Strategy;

Console.WriteLine("Strategy Pattern");
var serviceProvider = new ServiceCollection()
    .AddTransient<StrategyA>()
    .AddTransient<StrategyB>()
    .AddTransient<StrategyC>()
    .AddSingleton<Func<string, IStrategy>>(sp => key =>
    {
        return key switch
        {
            "A" => sp.GetRequiredService<StrategyA>(),
            "B" => sp.GetRequiredService<StrategyB>(),
            "C" => sp.GetRequiredService<StrategyC>(),
            _ => throw new ArgumentException($"Invalid strategy key: {key}")
        };

    })
    .AddScoped<StrategyContextOrService>()
    .BuildServiceProvider();

var strategyContextOrService = serviceProvider.GetService<StrategyContextOrService>();
strategyContextOrService?.ExecuteStrategy("A");
strategyContextOrService?.ExecuteStrategy("B");
strategyContextOrService?.ExecuteStrategy("C");
Console.ReadLine();

