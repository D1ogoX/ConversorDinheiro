using ConversorDinheiro.APP;
using ConversorDinheiro.APP.Repository;
using ConversorDinheiro.APP.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IConversor, Conversor>();
    })
    .Build();

IConversor _conversor = new Conversor();

Main main = new Main(_conversor);

main.Start();