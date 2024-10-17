using TiendaGamer.Productos.Builder;

namespace TiendaGamer.Productos.FactoryMethod
{
    // Fábricas concretas para Dell
    public class DellFactory : ComputadorFactory
    {
        public override IEscritorio CrearEscritorio()
        {
            return new ComputadorBuilder()
                .SetProcessor("Intel Core i7")
                .SetRAM(16)
                .SetStorage(512)
                .BuildDellEscritorio();
        }

        public override IPortatl CrearPortatil()
        {
            return new ComputadorBuilder()
                .SetProcessor("Intel Core i5")
                .SetRAM(8)
                .SetStorage(256)
                .BuildDellPortatil();
        }
    }
}
