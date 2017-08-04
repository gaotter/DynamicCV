using DynamicCv.DataContext.CvDbContext;
using DynamicCv.Entities.CvEntities;
using DynamicCv.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using DynamicCv.Common.Enums;

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

        public async Task<Statuses> UpdateEntry(Entry entry)
        {
            try
            {
                _cvContext.Entrys.Update(entry);
                var updated = await _cvContext.SaveChangesAsync();

                return updated >= 1 ? Statuses.Ok : Statuses.NotFound;
            }
            catch (DbUpdateConcurrencyException)
            {
                // TODO: Add Logging.
                return Statuses.NotFound;
            }
        }
        
    }
}
