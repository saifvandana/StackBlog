using Microsoft.AspNetCore.Mvc;
using StackBlog.Models.HomeViewModels;

namespace StackBlog.BusinessManagers.Interfaces
{
    public interface IHomeBusinessManager
    {
        ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page);
    }
}