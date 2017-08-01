using DynamicCv.DataContext.CvDbContext;
using DynamicCv.Entities.CvEntities;
using DynamicCv.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCv.Services.Repositories
{
    public class CvEntriesRepository : ICvEntriesRepository
    {
        private readonly CvContext _cvContext;

        
        

        public CvEntriesRepository(CvContext cvContext)
        {
            _cvContext = cvContext;
        }


        public async Task<IEnumerable<DynamicCv.Entities.CvEntities.Entry>> GetAllEntires()
        {
            return await _cvContext.Entrys.ToListAsync();
        }
        
    }
}
