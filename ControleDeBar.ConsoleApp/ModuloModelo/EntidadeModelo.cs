using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloModelo
{
    public abstract class EntidadeModelo<Tipo>
    {
        public int Id { get; set; }

        public abstract void AtualizarRegistro(Tipo registro);
        public abstract string ValidarDados();
    }
}
