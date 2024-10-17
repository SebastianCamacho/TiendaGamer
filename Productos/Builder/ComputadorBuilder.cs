namespace TiendaGamer.Productos.Builder
{
    // Builder
    public class ComputadorBuilder
    {
        private string _processor;
        private int _ram;
        private int _storage;

        public ComputadorBuilder SetProcessor(string processor)
        {
            _processor = processor;
            return this;
        }

        public ComputadorBuilder SetRAM(int ram)
        {
            _ram = ram;
            return this;
        }

        public ComputadorBuilder SetStorage(int storage)
        {
            _storage = storage;
            return this;
        }

        public DellEscritorio BuildDellEscritorio()
        {
            return new DellEscritorio(_processor, _ram, _storage);
        }

        public DellPortatil BuildDellPortatil()
        {
            return new DellPortatil(_processor, _ram, _storage);
        }

        public HPEscritorio BuildHPEscritorio()
        {
            return new HPEscritorio(_processor, _ram, _storage);
        }

        public HPPortatil BuildHPPortatil()
        {
            return new HPPortatil(_processor, _ram, _storage);
        }
    }
}
