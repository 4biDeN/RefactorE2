using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Interfaces
{
    public interface IInerciavel
    {
        void Ligar();  // Ligar o drone
        void Desligar();  // Desligar o drone
        bool Estado { get; }  // Verificar se o drone está ligado ou desligado
        double NivelBateria { get; }  // Adicionado atributo para indicar o nível da bateria
    }
}