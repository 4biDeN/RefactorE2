using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Classes
{
    public class Cliente
    {
        // Propriedade para obter ou definir o nome do cliente
        public string Nome { get; set; }

        // Propriedade para obter ou definir o documento do cliente (ex.: CPF, RG)
        public string Documento { get; set; }

        // Propriedade para obter ou definir o endereço do cliente
        public string Endereco { get; set; }

        // Propriedade para obter ou definir o telefone do cliente
        public string Telefone { get; set; }

        // Lista de entregas realizadas pelo cliente
        public List<Entrega> EntregasRealizadas { get; set; } = new List<Entrega>();

        // Construtor para inicializar uma nova instância da classe Cliente com os parâmetros fornecidos
        public Cliente(string nome, string documento, string endereco, string telefone)
        {
            Nome = nome;
            Documento = documento;
            Endereco = endereco;
            Telefone = telefone;
        }

        // Método para exibir as informações do cliente
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Documento: {Documento}, Endereço: {Endereco}, Telefone: {Telefone}");
        }

        // Método para adicionar uma entrega à lista de entregas do cliente
        public void AdicionarEntrega(Entrega entrega)
        {
            EntregasRealizadas.Add(entrega);
            Console.WriteLine($"Entrega adicionada para o cliente: {Nome}");
        }

        // Método para exibir todas as entregas realizadas pelo cliente
        public void ExibirEntregas()
        {
            Console.WriteLine($"Entregas realizadas por {Nome}:");
            foreach (var entrega in EntregasRealizadas)
            {
                Console.WriteLine($"- {entrega}");
            }
        }
    }
}