using Kreta.Desktop.Repos;
using Kreta.Desktop.SchoolCitizens;
using Moq;

namespace Kreta.Desktop.Service.Tests
{
    [TestClass()]
    public class ParentServiceTests
    {
        private readonly IParentService? _parentService;
        private readonly Mock<IParentRepo> moqParentRepo = new Mock<IParentRepo>();

        public ParentServiceTests()
        {
            _parentService = new ParentService(moqParentRepo.Object);
        }

        [TestMethod()]
        public void EmptyDatabase()
        {
            moqParentRepo
                .Setup(mock => mock.FindAll())
                .Returns(Enumerable.Empty<Parent>().ToList());

        }

        [TestMethod()]
        public void NoEmptyDatabase()
        {
            // arrange
            List<Parent> students = new List<Parent>
            {
                new Parent
                {
                    Id=Guid.NewGuid(),
                },
            };
        }
    }
}