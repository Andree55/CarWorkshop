using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static CarWorkshop.Application.ApplicationUser.userContext;

namespace CarWorkshop.Application.ApplicationUser
{
    public class userContext : IUserContext
    {
        public interface IUserContext
        {
            CurrentUser? GetCurrentUser();
        }
        private readonly IHttpContextAccessor _httpContextAccessor;

        public userContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public CurrentUser? GetCurrentUser()
        {
            var user = _httpContextAccessor?.HttpContext?.User;
            if (user == null)
            {
                throw new InvalidOperationException("Context user is not present");
            }

            if(user.Identity==null||!user.Identity.IsAuthenticated)
            {
                return null;
            }

            var id = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value;

            var email = user.FindFirst(c => c.Type == ClaimTypes.Email)!.Value;

            return new CurrentUser(id, email);

        }
    }
}
