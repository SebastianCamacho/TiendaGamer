using TiendaGamer.Productos.FactoryMethod;

namespace TiendaGamer.Productos.AbstractFactory
{
    public class HPBrandFactory : IBrandFactory
    {
        public ComputadorFactory CrearComputadorFactory()
        {
            return new HPFactory();
        }
    }

}
