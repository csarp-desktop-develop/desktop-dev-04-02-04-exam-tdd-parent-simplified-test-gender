using Kreta.Desktop.SchoolCitizens;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public interface IStudentRepo
    {
        public List<Student> FindAll();
    }
}
