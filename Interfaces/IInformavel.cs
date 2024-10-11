using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Interfaces
{
    public interface IInformavel
    {
        void ExibirInformacoes();  // Exibir informações gerais sobre o drone (modelo, estado, bateria, etc.)
        string ObterLocalizacaoAtual();  // Retornar a localização atual do drone (latitude e longitude)
    }
}
