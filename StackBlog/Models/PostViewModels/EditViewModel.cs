using Microsoft.AspNetCore.Http;
using StackBlog.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace StackBlog.Models.PostViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Header Image")]
        public IFormFile HeaderImage { get; set; }
        public Post Post { get; set; }
    }
}