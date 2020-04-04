using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models
{
    public   class Region : IEntity
    {
          public Region()
        {
            this.Territories = new HashSet<Territory>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }



        public virtual ICollection<Territory> Territories { get; set; }
    }
}
