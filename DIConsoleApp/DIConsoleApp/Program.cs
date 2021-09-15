using Microsoft.Extensions.DependencyInjection;
using System;

namespace DIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddScoped<ICalculator, Calculator>();
            services.AddScoped<Startup, Startup>();

            var provider = services.BuildServiceProvider();

            /**
             * O Provider irá tentar gerar uma instância do Startup e vai notar que ele possui uma dependência que é a classe Calculator,
             * após isso irá gerar uma instância de Calculadora, injetar no Startup e devolver a instância dele pronta.
             */
            var startup = provider.GetService<Startup>();

            startup.Sum("1", "2");
        }
    }
}
