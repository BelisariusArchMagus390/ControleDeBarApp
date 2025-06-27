using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloModelo
{
    public interface ITela
    {
        char ApresentarMenu();
        void CadastrarRegistro();
        void EditarRegistro();
        void ExcluirRegistro();
        void VisualizarRegistros(bool exibirCabecalho);
    }
}
