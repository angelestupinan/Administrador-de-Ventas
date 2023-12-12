using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrador_de_Ventas
{
    internal interface IPersona
    { 
        string Name { get; set; }
        int Age {  get; set; }
        int Id { get; set; }
    }
}
