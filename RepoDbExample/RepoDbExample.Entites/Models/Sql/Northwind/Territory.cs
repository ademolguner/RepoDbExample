using RepoDbExample.Core.Entities;
using System.Collections.Generic;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class Territory : IEntity, ISqlEntityType
    {
        public Territory()
        {
            Employees = new HashSet<Employee>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}