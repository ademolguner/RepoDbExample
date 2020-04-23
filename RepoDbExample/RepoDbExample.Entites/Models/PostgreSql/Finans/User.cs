using RepoDbExample.Core.Entities;
using System;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans
{
    public class User : IEntity, IPostgresqlEntityType
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool IsActivatedMailSend { get; set; }
        public Guid UserGuid { get; set; }
    }
}