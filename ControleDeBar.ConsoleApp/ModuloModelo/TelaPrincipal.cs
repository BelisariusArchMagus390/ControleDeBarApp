using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloModelo
{
    public abstract class TelaPrincipal
    {
        private char Opcao;

        private RepositorioMesa RepositorioMesa;
        private TelaMesa TelaMesa;

        private RepositorioGarcom RepositorioGarcom;
        private TelaGarcom TelaGarcom;

        private RepositorioProduto RepositorioProduto;
        private TelaProduto TelaProduto;

        private RepositorioConta RepositorioConta;
        private TelaConta TelaConta;

        public TelaPrincipal()
        {
            RepositorioMesa = new RepositorioMesa();
            RepositorioGarcom = new RepositorioGarcom();
            RepositorioProduto = new RepositorioProduto();
            RepositorioConta = new RepositorioConta();

            TelaMesa = new TelaMesa(RepositorioMesa);
            TelaGarcom = new TelaGarcom(RepositorioGarcom);
            TelaProduto = new TelaProduto(RepositorioProduto);
            TelaConta = new TelaConta(RepositorioConta);
        }

        public void MostrarMenuGeral()
        {
            Console.WriteLine("  --------------------------------------");
            Console.WriteLine(" |                                      |");
            Console.WriteLine(" |           CLUBE DA LEITURA           |");
            Console.WriteLine(" |                                      |");
            Console.WriteLine("  --------------------------------------");

            Console.WriteLine("\n 1 - Gestão de Mesa");
            Console.WriteLine(" 2 - Gestão de Garçons");
            Console.WriteLine(" 3 - Gestão de Produtos");
            Console.WriteLine(" 4 - Gestão de Contas");
            Console.WriteLine(" S - Sair");
            Console.Write("\n Escolha uma das opções acima: ");

            Opcao = Console.ReadLine()[0];
        }

        public TelaModelo SelecionarTela()
        {
            switch (Opcao)
            {
                case '1':
                    return TelaMesa;
                case '2':
                    return TelaGarcom;
                case '3':
                    return TelaProduto;
                case '4':
                    return TelaConta;
            }
            return null;
        }
    }
}
