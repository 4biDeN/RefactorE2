using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Interfaces
{
    public interface ILocavel
    {
        double PrecoPorEntrega { get; set; }  // Preço por cada entrega realizada
        double CalcularCustoEntrega(double distancia);  // Calcular o custo da entrega com base na distância
    }
}