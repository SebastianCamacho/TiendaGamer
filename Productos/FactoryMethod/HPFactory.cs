using TiendaGamer.Productos.Builder;

namespace TiendaGamer.Productos.FactoryMethod
{
    // Fábricas concretas para HP
    public class HPFactory : ComputadorFactory
    {
        public override IEscritorio CrearEscritorio()
        {
            return new ComputadorBuilder()
                .SetProcessor("AMD Ryzen 5")
                .SetRAM(16)
                .SetStorage(1024)
                .BuildHPEscritorio();
        }

        public override IPortatl CrearPortatil()
        {
            return new ComputadorBuilder()
                .SetProcessor("AMD Ryzen 3")
                .SetRAM(8)
                .SetStorage(512)
                .BuildHPPortatil();
        }
    }
}
