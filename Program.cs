using System;
using Refactoor.Classes; // Certifique-se de que o namespace esteja correto

namespace Refactoor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do gerenciador de entregas
            var gerenciador = new GerenciadorDeEntregas();

            // Adicionando alguns clientes
            var cliente1 = new Cliente("João Silva", "123.456.789-00", "Rua das Flores, 123", "987654321");
            var cliente2 = new Cliente("Maria Oliveira", "987.654.321-00", "Av. Brasil, 456", "123456789");

            gerenciador.AdicionarCliente(cliente1);
            gerenciador.AdicionarCliente(cliente2);

            // Adicionando alguns drones
            var drone1 = new Drone("DRONE-001", "Modelo A", "Marca A", 2022, 5.0, 100.0); // 100% de bateria
            var drone2 = new Drone("DRONE-002", "Modelo B", "Marca B", 2023, 7.5, 80.0); // 80% de bateria

            gerenciador.AdicionarDrone(drone1);
            gerenciador.AdicionarDrone(drone2);

            // Criando uma entrega
            gerenciador.CriarEntrega(cliente1, drone1, 10.0); // Exemplo de entrega de 10 km

            // Listando entregas
            Console.WriteLine("Entregas:");
            foreach (var entrega in gerenciador.ListarEntregas())
            {
                entrega.ExibirInformacoes(); // Supondo que haja um método ExibirInformacoes() na classe Entrega
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
