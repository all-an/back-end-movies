using CoreActions;
using System.Collections.Generic;

namespace UseCases
{
    public interface IViewCategory
    {
        IEnumerable<Category> Execute();
    }
}