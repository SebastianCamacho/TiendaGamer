namespace TiendaGamer.Productos.FactoryMethod
{
    // Fábrica (abstracta) utilizando Factory Method
    public abstract class ComputadorFactory
    {
        public abstract IEscritorio CrearEscritorio();
        public abstract IPortatil CrearPortatil();
    }
}
