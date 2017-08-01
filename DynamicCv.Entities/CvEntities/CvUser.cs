using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class CvUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string About { get; set; }

        public string Role { get; set; }

        public string UserLogin { get; set; }

        public virtual IEnumerable<Entry> Entires { get; set; }

        [NotMapped]
        public string LoginStatus { get; set; }

        [NotMapped]
        public string PictureUrl { get; set; }


    }
}
