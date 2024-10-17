using TiendaGamer.Productos.Builder;

namespace TiendaGamer.Productos.FactoryMethod
{
    // Fábricas concretas para HP
    public class HPFactory : ComputadorFactory
    {
        public override IEscritorio CrearEscritorio()
        {
            return new HPComputadorBuilder()
                .SetProcesador("AMD Ryzen 5")
                .SetRAM(16)
                .SetAlmacenamiento(1024)
                .BuildEscritorio();
        }

        public override IPortatil CrearPortatil()
        {
            return new HPComputadorBuilder()
                .SetProcesador("AMD Ryzen 3")
                .SetRAM(8)
                .SetAlmacenamiento(512)
                .BuildPortatil();
        }
    }
}
