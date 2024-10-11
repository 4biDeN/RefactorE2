using Refactoor.Interfaces;

namespace Refactoor.Classes
{
    public class Drone : Veiculo, IInerciavel
    {
        private bool _estado;
        private double _nivelBateria; // Variável interna para o nível da bateria

        public Drone(string identificacao, string modelo, string marca, int anoFabricacao, double pesoMaximoCarga, double nivelBateria)
            : base(identificacao, modelo, marca, anoFabricacao, pesoMaximoCarga)
        {
            _nivelBateria = nivelBateria; // Inicializando o nível da bateria
            _estado = false; // O drone começa desligado
        }

        public double NivelBateria => _nivelBateria; // Implementando a propriedade da interface

        public override void Frear()
        {
            Console.WriteLine("Drone freando");
        }

        public override void MoverPara(double latitude, double longitude)
        {
            Console.WriteLine($"Drone se movendo para a latitude {latitude} e longitude {longitude}");
        }

        public override string GetIdentificadorUnico()
        {
            return $"DRONE-{Identificacao}";
        }

        public void Ligar()
        {
            if (_nivelBateria > 0)
            {
                _estado = true;
                Console.WriteLine("Drone ligado");
            }
            else
            {
                Console.WriteLine("Não é possível ligar o drone. Bateria está baixa.");
            }
        }

        public void Desligar()
        {
            _estado = false;
            Console.WriteLine("Drone desligado");
        }

        public bool Estado => _estado;

        public void RecarregarBateria(double quantidade)
        {
            _nivelBateria = Math.Min(100, _nivelBateria + quantidade); // Não exceder 100%
            Console.WriteLine($"Bateria recarregada para {_nivelBateria}%");
        }
    }
}
