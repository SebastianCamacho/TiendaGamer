namespace TiendaGamer.Productos
{
    // Productos concretos para HP
    public class HPEscritorio : IEscritorio
    {
        private string _processor;
        private int _ram;
        private int _storage;

        public HPEscritorio(string processor, int ram, int storage)
        {
            _processor = processor;
            _ram = ram;
            _storage = storage;
        }

        public void GetSpecifications()
        {
            Console.WriteLine($"HP Desktop Specifications: Processor: {_processor}, RAM: {_ram}GB, Storage: {_storage}GB");
        }
    }
}
