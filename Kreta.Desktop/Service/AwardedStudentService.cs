using Kreta.Desktop.Repos;
using System.Linq;

namespace Kreta.Desktop.Service
{
    public class AwardedStudentService : IAwardedStudentService
    {
        private readonly IAwardedStudentRepo _awardedStudentRepo;

        public AwardedStudentService(IAwardedStudentRepo awardedStudentRepo)
        {
            _awardedStudentRepo = awardedStudentRepo;
        }

        public int GetNumberOfAwardedStudent()
        {
            return _awardedStudentRepo
                .FindAll()
                .Select(awardedStudent => awardedStudent.StudentId)
                .Distinct()
                .Count();
        }
    }
}
