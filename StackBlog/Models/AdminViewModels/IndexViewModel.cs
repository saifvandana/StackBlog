using StackBlog.Data.Models;
using System.Collections.Generic;

namespace StackBlog.Models.AdminViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}