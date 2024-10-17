using TiendaGamer.Productos.FactoryMethod;

namespace TiendaGamer.Productos.AbstractFactory
{
    // Fábricas concretas utilizando Abstract Factory
    public class DellBrandFactory : IBrandFactory
    {
        public ComputadorFactory CrearComputadorFactory()
        {
            return new DellFactory();
        }
    }

}
