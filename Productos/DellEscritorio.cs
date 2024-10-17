namespace TiendaGamer.Productos
{
    // Productos concretos para Dell
    public class DellEscritorio : IEscritorio
    {
        private string _processor;
        private int _ram;
        private int _storage;

        public DellEscritorio(string processor, int ram, int storage)
        {
            _processor = processor;
            _ram = ram;
            _storage = storage;
        }

        public void GetSpecifications()
        {
            Console.WriteLine($"Dell Desktop Specifications: Processor: {_processor}, RAM: {_ram}GB, Storage: {_storage}GB");
        }
    }
}
