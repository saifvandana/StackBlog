﻿using Microsoft.AspNetCore.Mvc;
using PagedList;
using StackBlog.BusinessManagers.Interfaces;
using StackBlog.Data.Models;
using StackBlog.Models.HomeViewModels;
using StackBlog.Service.Interfaces;
using System.Linq;

namespace StackBlog.BusinessManagers
{
    public class HomeBusinessManager : IHomeBusinessManager
    {
        private readonly IPostService postService;
        private readonly IUserService userService;

        public HomeBusinessManager(
            IPostService postService,
            IUserService userService)
        {
            this.postService = postService;
            this.userService = userService;
        }

        public ActionResult<AuthorViewModel> GetAuthorViewModel(string authorId, string searchString, int? page)
        {
            if (authorId is null)
                return new BadRequestResult();

            var applicationUser = userService.Get(authorId);

            if (applicationUser is null)
                return new NotFoundResult();

            int pageSize = 20;
            int pageNumber = page ?? 1;

            var posts = postService.GetPosts(searchString ?? string.Empty)
                .Where(post => post.Published && post.Creator == applicationUser && post.Approved);

            return new AuthorViewModel
            {
                Author = applicationUser,
                Posts = new StaticPagedList<Post>(posts.Skip((pageNumber - 1) * pageSize).Take(pageSize), pageNumber, pageSize, posts.Count()),
                SearchString = searchString,
                PageNumber = pageNumber
            };
        }
    }
}