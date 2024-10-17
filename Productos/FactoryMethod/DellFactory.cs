using TiendaGamer.Productos.Builder;

namespace TiendaGamer.Productos.FactoryMethod
{
    // Fábricas concretas para Dell
    public class DellFactory : ComputadorFactory
    {
        public override IEscritorio CrearEscritorio()
        {
            return new DellComputadorBuilder()
                .SetProcesador("Intel Core i7")
                .SetRAM(16)
                .SetAlmacenamiento(512)
                .BuildEscritorio();
        }

        public override IPortatil CrearPortatil()
        {
            return new DellComputadorBuilder()
                .SetProcesador("Intel Core i5")
                .SetRAM(8)
                .SetAlmacenamiento(256)
                .BuildPortatil();
        }
    }
}
