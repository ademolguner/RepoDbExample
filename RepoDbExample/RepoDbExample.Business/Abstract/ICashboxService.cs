using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
    public interface ICashboxService
    {
        IEnumerable<Cashbox> QueryAll(Cashbox cashbox);
        void NewItem(Cashbox cashbox);
    }
}
