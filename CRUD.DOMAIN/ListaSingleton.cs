

using CRUD.Modelos;

namespace CRUD
{
    public sealed class ListaSingleton
    {
        private static List<JogadorModelo>? instancia;
        private static int Id;

        private ListaSingleton() { }
        public static List<JogadorModelo> ObterInstancia()
        {
            if (instancia == null)
            {
                instancia = new();
            }
            return instancia;
        }

        public static int ObterProximoId()
        {
            return ++Id;
        }
    }
}
