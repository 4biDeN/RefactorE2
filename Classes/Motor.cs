using Refactoor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Classes
{
    public class MotorDrone : IInerciavel
    {
        private bool _estado; // Estado do motor
        private double _nivelBateria; // Nível da bateria do motor (agora é um double)

        // Construtor para inicializar o motor com nível de bateria
        public MotorDrone(double nivelBateriaInicial)
        {
            _nivelBateria = nivelBateriaInicial;
        }

        // Método para ligar o motor do drone
        public void Ligar()
        {
            if (_nivelBateria > 0)
            {
                _estado = true; // Define o estado como ligado
                Console.WriteLine("Motor do drone ligado");
            }
            else
            {
                Console.WriteLine("Não é possível ligar: bateria insuficiente.");
            }
        }

        // Método para desligar o motor do drone
        public void Desligar()
        {
            _estado = false; // Define o estado como desligado
            Console.WriteLine("Motor do drone desligado");
        }

        // Propriedade para verificar se o motor está ligado
        public bool Estado => _estado; // Retorna o estado atual do motor

        // Propriedade para obter o nível da bateria (agora é um double)
        public double NivelBateria => _nivelBateria; // Retorna o nível da bateria
    }
}