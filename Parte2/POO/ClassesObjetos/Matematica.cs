using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    //Classe estática serve apenas para agrupar métodos e não pode ser instanciada
    //Podemos usar essa classe em qualquer lugar do nosso código sem a necessidade de criar um objeto
    //Configurações globais para nossa aplicação podem ser armazenadas em classes estáticas

    static class Matematica 
    {
        //Tudo precisa ser estatico dentro de uma classe estática

        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }
    
    
    }
}
