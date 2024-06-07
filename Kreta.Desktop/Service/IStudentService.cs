using Kreta.Desktop.Models;

namespace Kreta.Desktop.Service
{
    public interface IStudentService
    {
        // diáklányok száma
        public int GetNumberOfWomen();
        // diákok száma
        public int GetNumberOfMen();

        // előző feladatok, csak osztályonként: grade -> évfolyam, type-> "a", "b", "c"...
        public int GetNumberOfWomen(int grade, SchoolClassType schoolClassType);        
        public int GetNumberOfMen(int grade, SchoolClassType schoolClassType);
    }
}
