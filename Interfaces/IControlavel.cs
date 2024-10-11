using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoor.Interfaces
{
    public interface IControlavel
    {
        void Decolar();  
        void Aterrissar();  
        void MoverPara(double latitude, double longitude);
        void Frear();  
    }
}
