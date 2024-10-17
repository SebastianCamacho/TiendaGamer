namespace TiendaGamer.Productos.Builder
{
    // ConcreteBuilder para HP
    public class HPComputadorBuilder : IComputadorBuilder
    {
        private string _processor;
        private int _ram;
        private int _storage;

        public IComputadorBuilder SetProcesador(string processor)
        {
            _processor = processor;
            return this;
        }

        public IComputadorBuilder SetRAM(int ram)
        {
            _ram = ram;
            return this;
        }

        public IComputadorBuilder SetAlmacenamiento(int storage)
        {
            _storage = storage;
            return this;
        }

        public IEscritorio BuildEscritorio()
        {
            return new HPEscritorio(_processor, _ram, _storage);
        }

        public IPortatil BuildPortatil()
        {
            return new HPPortatil(_processor, _ram, _storage);
        }
    }
}
