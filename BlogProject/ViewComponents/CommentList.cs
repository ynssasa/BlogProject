using BlogProjectUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Yunus"
                },
                new UserComment
                {
                    Id = 2,
                    UserName = "Murat"
                },
                new UserComment
                {
                    Id = 3,
                    UserName = "Merve"
                }
            };
            return View(values);
        }
    }
}
