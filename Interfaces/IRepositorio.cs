using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornarPorId(int id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        void Excluir(int id);
        int ProximoId();
    }
}
