using System;
using System.Threading.Tasks;

namespace Dotnet_Tipos_Especiais.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class IntExtensions
    {
        public static bool EhPar(this int numero){
            return numero % 2 == 0;
        }
    }
}
