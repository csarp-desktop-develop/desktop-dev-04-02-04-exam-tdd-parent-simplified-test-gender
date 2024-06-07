using Kreta.Desktop.Repos;

namespace Kreta.Desktop.Service
{
    public class ParentService : IParentService
    {
        private readonly IParentRepo? _parentRepo;

        public ParentService(IParentRepo? parentRepo)
        {
            _parentRepo = parentRepo;
        }

        public int GetNumberOfDads()
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfMums()
        {
            throw new System.NotImplementedException();
        }
    }
}
