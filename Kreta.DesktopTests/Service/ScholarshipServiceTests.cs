using Kreta.Desktop.Repos;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class ScholarshipServiceTests
    {
        private readonly ScholarshipService _scholarshipService;
        private readonly Mock<IAwardedStudentRepo> _awardedStudentRepoMock = new Mock<IAwardedStudentRepo>();
        private readonly Mock<IStudentRepo> _studentRepoMock= new Mock<IStudentRepo>();

        public ScholarshipServiceTests()
        {
            _scholarshipService = new ScholarshipService(_studentRepoMock.Object, _awardedStudentRepoMock.Object);
        }

        [TestMethod()]
        public void Test()
        {
        }
    }
}