using System;
using System.Threading.Tasks;
using ServiceReference1; // Reemplaza con el namespace generado para el servicio

class Program
{
    static async Task Main(string[] args)
    {
        // Crear una instancia del cliente
        var client = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap);

        // Invocar una operación del servicio (ejemplo: sumar) de forma asincrónica
        int a = 10, b = 20;
        int result = await client.AddAsync(a, b);

        // Mostrar el resultado
        Console.WriteLine($"La suma de {a} + {b} = {result}");

        // Cierra el cliente
        await client.CloseAsync();
    }
}
