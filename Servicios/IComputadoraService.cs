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
        IEscritorio CrearEscritorio(string marca);
        IPortatil CrearPortatil(string marca);
        IEscritorio PersonalizarEscritorio(string marca, string procesador, int ram, int almacenamiento);
        IPortatil PersonalizarPortatil(string marca, string procesador, int ram, int almacenamiento);
        List<IEscritorio> ObtenerEscritorios();
        List<IPortatil> ObtenerPortatiles();
    }

    public class ComputadorService : IComputadorService
    {
        private readonly List<IEscritorio> _escritorios;
        private readonly List<IPortatil> _portatiles;

        public ComputadorService()
        {
            _escritorios = new List<IEscritorio>();
            _portatiles = new List<IPortatil>();
        }

        public IEscritorio CrearEscritorio(string marca)
        {
            var factory = ObtenerFabricaPorMarca(marca);
            var escritorio = factory.CrearEscritorio();
            _escritorios.Add(escritorio);
            return escritorio;
        }

        public IPortatil CrearPortatil(string marca)
        {
            var factory = ObtenerFabricaPorMarca(marca);
            var portatil = factory.CrearPortatil();
            _portatiles.Add(portatil);
            return portatil;
        }

        public IEscritorio PersonalizarEscritorio(string marca, string procesador, int ram, int almacenamiento)
        {
            var builder = ObtenerBuilderPorMarca(marca);
            var escritorio = builder.SetProcesador(procesador).SetRAM(ram).SetAlmacenamiento(almacenamiento).BuildEscritorio();
            _escritorios.Add(escritorio);
            return escritorio;
        }

        public IPortatil PersonalizarPortatil(string marca, string procesador, int ram, int almacenamiento)
        {
            var builder = ObtenerBuilderPorMarca(marca);
            var portatil = builder.SetProcesador(procesador).SetRAM(ram).SetAlmacenamiento(almacenamiento).BuildPortatil();
            _portatiles.Add(portatil);
            return portatil;
        }

        public List<IEscritorio> ObtenerEscritorios() => _escritorios;
        public List<IPortatil> ObtenerPortatiles() => _portatiles;

        private ComputadorFactory ObtenerFabricaPorMarca(string marca)
        {
            return marca.ToLower() switch
            {
                "dell" => new DellFactory(),
                "hp" => new HPFactory(),
                _ => throw new ArgumentException("Marca no soportada")
            };
        }

        private IComputadorBuilder ObtenerBuilderPorMarca(string marca)
        {
            return marca.ToLower() switch
            {
                "dell" => new DellComputadorBuilder(),
                "hp" => new HPComputadorBuilder(),
                _ => throw new ArgumentException("Marca no soportada")
            };
        }
    }


}
