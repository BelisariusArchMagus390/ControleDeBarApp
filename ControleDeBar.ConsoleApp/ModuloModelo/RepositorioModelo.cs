using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloModelo
{
    public abstract class RepositorioModelo<Tipo> where Tipo : EntidadeModelo<Tipo>
    {
        private List<Tipo> Registros = new List<Tipo>();

        public void AdicionarRegistro(Tipo novoRegistro)
        {
            Registros.Add(novoRegistro);
        }

        public bool EditarRegistro(int id, Tipo registroAtualizado)
        {
            Tipo registro = SelecionarRegistroPorId(id);

            if (registro == null)
                return false;

            registro.AtualizarRegistro(registroAtualizado);

            return true;
        }

        public bool RemoverRegistro(int id)
        {
            Tipo registro = SelecionarRegistroPorId(id);

            if (registro != null)
            {
                int indice = Registros.IndexOf(registro);
                Registros.RemoveAt(indice);
                return true;
            }
            return false;
        }

        public List<Tipo> PegarRegistros()
        {
            return Registros;
        }

        public Tipo SelecionarRegistroPorId(int id)
        {
            foreach (Tipo m in Registros)
            {
                if (m.Id == id)
                    return m;
            }
            return null;
        }
    }
}
