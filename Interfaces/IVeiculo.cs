using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Interfaces
{
    public interface IVeiculo
    {
        string Identificacao { get; }  // ID ou número de série do drone
        string Modelo { get; }  // Modelo do drone
        string Marca { get; }  // Fabricante do drone
        int AnoFabricacao { get; }  // Ano de fabricação do drone
        double PesoMaximoCarga { get; }  // Peso máximo que o drone pode carregar

        void ExibirInformacoes();  // Exibir informações gerais do drone
        void MoverPara(double latitude, double longitude);  // Mover para uma localização específica
    }
}
