using Refactoor.Interfaces;
using System;

namespace Refactoor.Classes
{
    /*
     Aqui, seguimos o princípio de Liskov Substitution (LSP), 
     mantendo a classe abstrata para garantir que todas as subclasses implementem os métodos necessários.
     Também aplicamos SoC separando as responsabilidades em interfaces.
    */
    public abstract class Veiculo : IVeiculo, ILocavel, IInformavel, IControlavel
    {
        public string Identificacao { get; set; } // Atualizado para um identificador de drone
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int AnoFabricacao { get; set; }
        public double PesoMaximoCarga { get; set; } // Peso máximo de carga em vez de PrecoDiaria

        // Adicionando a propriedade PrecoPorEntrega
        public double PrecoPorEntrega { get; set; } // Propriedade de preço por entrega

        // Atributo para localização atual
        private double _latitude;
        private double _longitude;

        protected Veiculo(string identificacao, string modelo, string marca, int anoFabricacao, double pesoMaximoCarga)
        {
            Identificacao = identificacao;
            Modelo = modelo;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            PesoMaximoCarga = pesoMaximoCarga;
            PrecoPorEntrega = 5.0; // Valor padrão ou calculado
        }

        public abstract void Frear(); // Método abstrato para frear

        public abstract void MoverPara(double latitude, double longitude); // Método para mover o drone

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Identificação: {Identificacao}, Modelo: {Modelo}, Marca: {Marca}, Ano: {AnoFabricacao}, Peso Máximo de Carga: {PesoMaximoCarga} kg");
        }

        public double CalcularCustoEntrega(double distancia) // Adaptado para calcular custo de entrega
        {
            if (distancia <= 0) throw new ArgumentException("Distância inválida.");
            return distancia * PrecoPorEntrega; // Usando a propriedade PrecoPorEntrega
        }

        public abstract string GetIdentificadorUnico(); // Método abstrato para obter identificador único

        // Implementação de IInformavel
        public string ObterLocalizacaoAtual()
        {
            return $"Latitude: {_latitude}, Longitude: {_longitude}"; // Retorna a localização atual
        }

        // Implementação de IControlavel
        public void Decolar()
        {
            Console.WriteLine("Drone decolando...");
        }

        public void Aterrissar()
        {
            Console.WriteLine("Drone aterrissando...");
        }
    }
}
