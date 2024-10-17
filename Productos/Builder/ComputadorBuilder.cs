namespace TiendaGamer.Productos.Builder
{
    // Builder
    public interface IComputadorBuilder
    {
        IComputadorBuilder SetProcesador(string processor);
        IComputadorBuilder SetRAM(int ram);
        IComputadorBuilder SetAlmacenamiento(int storage);

        IEscritorio BuildEscritorio();
        IPortatil BuildPortatil();
    }
}
