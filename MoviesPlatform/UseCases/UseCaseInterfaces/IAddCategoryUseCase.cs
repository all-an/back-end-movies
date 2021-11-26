using CoreActions;

namespace UseCases
{
    public interface IAddCategoryUseCase
    {
        public void Execute(Category category);
    }
}