namespace TiendaGamer.Productos
{
    public class DellPortatil : IPortatil
    {
        private string _processor;
        private int _ram;
        private int _storage;

        public DellPortatil(string processor, int ram, int storage)
        {
            _processor = processor;
            _ram = ram;
            _storage = storage;
        }

        public void GetSpecifications()
        {
            Console.WriteLine($"Dell Laptop Specifications: Processor: {_processor}, RAM: {_ram}GB, Storage: {_storage}GB");
        }
    }
}
