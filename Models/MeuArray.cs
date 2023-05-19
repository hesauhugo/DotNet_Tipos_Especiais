using System;
using System.Threading.Tasks;

namespace Dotnet_Tipos_Especiais.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] array = new T[capacidade];
        private int contador = 0;
        
        
        public void AdicionarElementoArray(T elemento){
            if(contador+1 < 11 ){
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]{
            get{ return array[index];}
            set{ array[index] = value;}
        }
    }
}
