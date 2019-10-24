
using UnitOfWorkSample.Repository;
using UnitOfWorkSample.UnitOfWork;

namespace UnitOfWorkSample.Services
{
    public class DummyService : IDummyService
    {
        private readonly IUnitOfWorkBase _unitOfWork;
        private readonly IProductRepository _productRepository;

        public DummyService(
            IUnitOfWorkBase unitOfWork,
            IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
        }

        public void HandleDummyOperation()
        {
        }
    }
}
