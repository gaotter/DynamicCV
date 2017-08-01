using DynamicCv.Entities.CvEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCv.Services.Interfaces
{
    public interface IUserRepsitory
    {
        Task<CvUser> GetUser(string userLogin);
       
    }
}
