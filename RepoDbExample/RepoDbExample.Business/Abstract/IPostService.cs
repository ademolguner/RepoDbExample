using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System.Collections.Generic;

namespace RepoDbExample.Business.Abstract
{
    public interface IPostService
    {
        List<Post> TumPostlariGetir();

        List<Post> TumPostlariGetir_AktifOlanlari(bool isActive);

        List<Post> TumPostlariGetir_SiralıOlsun_CreatedDate_Des_Aktif_Asc(RepoDb.Enumerations.Order orderCreateDate, RepoDb.Enumerations.Order orderIsActive);

        List<Post> TumPostlariGetir_Where_CategoryIdGoreGetir_Sirala_CreatedDate(int categoryId, bool isActive, RepoDb.Enumerations.Order orderCreateDate);

        List<Post> TumPostlariGetir_Ilk_10_Adet(int count);

        List<Post> TumPostlariGetir_Ilk_10_Atla_Sonraki_3_Adet(int skip, int count);

        List<Post> TumPostlariGetir_Where_Adet(bool isActive, int count);

        List<Post> TumPostlariGetir_Where_Adet(bool isActive, int skip, int count);

        List<Post> TumPostlariGetir_Order_Adet(RepoDb.Enumerations.Order orderCreateDate, int count);

        List<Post> TumPostlariGetir_Order_Adet(RepoDb.Enumerations.Order orderCreateDate, int skip, int count);

        List<Post> TumPostlariGetir_Where_Order_Adet(int categoryId, bool isActive, RepoDb.Enumerations.Order orderCreateDate, RepoDb.Enumerations.Order orderTitle, int adet);

        List<Post> TumPostlariGetir_Where_Order_Adet(int categoryId, bool isActive, RepoDb.Enumerations.Order orderCreateDate, RepoDb.Enumerations.Order orderTitle, int skip, int adet);

        ///// <summary>
        ///// Tümünü getir
        ///// </summary>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir();
        ///// <summary>
        ///// aktif olanları getir
        ///// </summary>
        ///// <param name="filter">aktif olanları getir</param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Where(Expression<Func<Post, bool>> filter);
        ///// <summary>
        ///// CreateDate alanına göre ve IsActive durumuna göre getir
        ///// </summary>
        ///// <param name="orderFields">CreateDate alanına göre ve IsActive durumuna göre  sırala getir </param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Order(IEnumerable<OrderField> orderFields);
        ///// <summary>
        ///// CategoryId 5 olan
        ///// </summary>
        ///// <param name="filter">CategoryId 5 olan ve aktif olan </param>
        ///// <param name="orderFields">Createdate alanına göre sırala getir </param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Where_Order(Expression<Func<Post, bool>> filter, IEnumerable<OrderField> orderFields);
        ///// <summary>
        /////
        ///// </summary>
        ///// <param name="count">3 tane getir</param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Adet(int count);
        ///// <summary>
        /////
        ///// </summary>
        ///// <param name="filter">aktif olanları getir</param>
        ///// <param name="count">2 tane getir</param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Where_Adet(Expression<Func<Post, bool>> filter, int count);
        ///// <summary>
        /////
        ///// </summary>
        ///// <param name="orderFields">Createdate alanına göre sırala </param>
        ///// <param name="count">3 tane getir</param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Order_Adet(IEnumerable<OrderField> orderFields, int count);
        ///// <summary>
        /////
        ///// </summary>
        ///// <param name="filter">CategoryId 5 olan ve aktif olanlardan</param>
        ///// <param name="orderFields">Create date alanına göre ve Title alanına göre sırala</param>
        ///// <param name="count">4 tane getir</param>
        ///// <returns></returns>
        //List<Post> TumPostlariGetir_Where_Order_Adet(Expression<Func<Post, bool>> filter, IEnumerable<OrderField> orderFields, int count);
    }
}