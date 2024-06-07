namespace Kreta.Desktop.Service
{
    public interface IParentService
    {
        // az anyukák száma
        public int GetNumberOfMums();
        // az apukák száma
        public int GetNumberOfDads();
    }
}
