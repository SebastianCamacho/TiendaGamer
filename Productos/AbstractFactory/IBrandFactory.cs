using TiendaGamer.Productos.FactoryMethod;

namespace TiendaGamer.Productos.AbstractFactory
{
    // Interfaz de Fábrica Abstracta
    public interface IBrandFactory
    {
        ComputadorFactory CrearComputadorFactory();
    }

}
