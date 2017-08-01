using DynamicCv.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DynamicCv.Entities.CvEntities;
using DynamicCv.DataContext.CvDbContext;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Knowit.Amende.Helpers.Extensions;

namespace DynamicCv.Services.Repositories
{

    public class UserReposistory : IUserRepsitory
    {

        private readonly CvContext _cvContext;

        public UserReposistory(CvContext cvContext)
        {
            _cvContext = cvContext;
        }

        public async Task<CvUser> GetUser(string userLogin)
        {
            var user = await _cvContext.CvUser.Where(u => u.UserLogin == userLogin)
                .Include(u2 => u2.Entires).ThenInclude(e => e.Projects)
                .Include(u => u.Entires).ThenInclude(e => e.Areas)
                .SingleOrDefaultAsync();
            
            user.Entires = user.Entires.OrderByDescending(e => e.From);
            user.Entires.ForEach(e => e.Projects = e.Projects.OrderByDescending(p => p.From));
            
            return user;
        }
    }
}
