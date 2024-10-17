using TiendaGamer.Productos;
using TiendaGamer.Productos.AbstractFactory;
using TiendaGamer.Productos.Builder;
using TiendaGamer.Productos.FactoryMethod;

namespace TiendaGamer.Servicios
{
    // IComputadoraService.cs
    // Interfaz del Servicio de Computadores
    public interface IComputadorService
    {
        void AddDellDesktop(string processor, int ram, int storage);
        void AddDellLaptop(string processor, int ram, int storage);
        void AddHPDesktop(string processor, int ram, int storage);
        void AddHPLaptop(string processor, int ram, int storage);
        List<IEscritorio> GetAllDesktops();
        List<IPortatil> GetAllLaptops();
        void RemoveDesktop(IEscritorio desktop);
        void RemoveLaptop(IPortatil laptop);
    }
    // Servicio de Computadores
    public class ComputadorService: IComputadorService
    {
        private readonly List<IEscritorio> _desktops = new();
        private readonly List<IPortatil> _laptops = new();

        public void AddDellDesktop(string processor, int ram, int storage)
        {
            var desktop = new ComputadorBuilder()
                .SetProcessor(processor)
                .SetRAM(ram)
                .SetStorage(storage)
                .BuildHPEscritorio();

            _desktops.Add(desktop);
        }

        public void AddDellLaptop(string processor, int ram, int storage)
        {
            var laptop = new ComputadorBuilder()
                .SetProcessor(processor)
                .SetRAM(ram)
                .SetStorage(storage)
                .BuildDellPortatil();

            _laptops.Add(laptop);
        }

        public void AddHPDesktop(string processor, int ram, int storage)
        {
            var desktop = new ComputadorBuilder()
                .SetProcessor(processor)
                .SetRAM(ram)
                .SetStorage(storage)
                .BuildHPEscritorio();

            _desktops.Add(desktop);
        }

        public void AddHPLaptop(string processor, int ram, int storage)
        {
            var laptop = new ComputadorBuilder()
                .SetProcessor(processor)
                .SetRAM(ram)
                .SetStorage(storage)
                .BuildHPPortatil();

            _laptops.Add(laptop);
        }

        public List<IEscritorio> GetAllDesktops()
        {
            return _desktops;
        }

        public List<IPortatil> GetAllLaptops()
        {
            return _laptops;
        }

        public void RemoveDesktop(IEscritorio desktop)
        {
            _desktops.Remove(desktop);
        }

        public void RemoveLaptop(IPortatil laptop)
        {
            _laptops.Remove(laptop);
        }
    }



}
