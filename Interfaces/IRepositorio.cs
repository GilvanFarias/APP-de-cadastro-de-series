using System;
using System.Collections.Generic;


namespace APP_de_cadastro_de_series
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T retornaID(int id);

         Void Insere(T entidade);

         Void Exclui(int id);

         Void Atualiza(int id, T entidade);

         int ProximoId();

    }
}