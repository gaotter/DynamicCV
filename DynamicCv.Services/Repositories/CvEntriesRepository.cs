using DynamicCv.DataContext.CvDbContext;
using DynamicCv.Entities.CvEntities;
using DynamicCv.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicCv.Services.Repositories
{
    public class CvEntriesRepository : ICvEntriesRepositoriy
    {
        private readonly CvContext _cvContext;

        
        

        public CvEntriesRepository(CvContext cvContext)
        {
            _cvContext = cvContext;
        }

        
    }
}
