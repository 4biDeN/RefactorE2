using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Classes
{
    /* Para aplicar o princípio Open/Closed (OCP) e reduzir a complexidade,
       criado métodos reutilizáveis para a busca de clientes e entregas. */
    public class GerenciadorDeEntregas
    {
        private List<Drone> _drones; // Lista de drones
        private List<Cliente> _clientes; // Lista de clientes
        private List<Entrega> _entregas; // Lista de entregas

        public GerenciadorDeEntregas()
        {
            _drones = new List<Drone>();
            _clientes = new List<Cliente>();
            _entregas = new List<Entrega>();
        }

        // Método para listar drones
        public List<Drone> ListarDrones()
        {
            return _drones;
        }

        // Método para listar clientes
        public List<Cliente> ListarClientes()
        {
            return _clientes;
        }

        // Método para listar entregas
        public List<Entrega> ListarEntregas()
        {
            return _entregas;
        }

        // Método para buscar entregas por cliente
        public List<Entrega> BuscarEntregasPorCliente(Cliente cliente)
        {
            return _entregas.Where(e => e.Cliente.Documento == cliente.Documento).ToList();
        }

        // Método para adicionar drone
        public void AdicionarDrone(Drone drone)
        {
            _drones.Add(drone);
        }

        // Método para adicionar cliente
        public void AdicionarCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        // Método para criar entrega
        public void CriarEntrega(Cliente cliente, Drone drone, double distancia)
        {
            var entrega = new Entrega(cliente, drone, distancia);
            _entregas.Add(entrega);
        }
    }
}
