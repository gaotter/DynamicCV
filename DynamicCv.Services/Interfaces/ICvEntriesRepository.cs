using DynamicCv.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DynamicCv.Services.Interfaces
{
    public interface ICvEntriesRepository
    {
        Task<IEnumerable<Entities.CvEntities.Entry>> GetAllEntires();

        Task<Statuses> UpdateEntry(Entities.CvEntities.Entry entry);
    }
}
