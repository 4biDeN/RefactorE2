using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Classes
{
    public class Entrega
    {
        public Cliente Cliente { get; private set; } // Cliente que solicitou a entrega
        public Drone Drone { get; private set; } // Drone utilizado para a entrega
        public double Distancia { get; private set; } // Distância da entrega em km
        public DateTime DataEntrega { get; private set; } // Data da entrega

        public Entrega(Cliente cliente, Drone drone, double distancia)
        {
            Cliente = cliente;
            Drone = drone;
            Distancia = distancia;
            DataEntrega = DateTime.Now; // Define a data da entrega como a data atual
        }

        // Método para exibir informações sobre a entrega
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Entrega para: {Cliente.Nome}, Drone: {Drone.GetIdentificadorUnico()}, Distância: {Distancia} km, Data da Entrega: {DataEntrega}");
        }

        // Método para calcular o custo da entrega
        public double CalcularCusto()
        {
            return Drone.CalcularCustoEntrega(Distancia);
        }
    }
}