using RepoDb;
using RepoDb.Extensions;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
    public interface IPostService
    {
        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// Tümünü getir
        /// </summary>
        /// <returns></returns>
        List<Post> TumPostlariGetir();

        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// aktif olanları getir
        /// </summary>
        /// <param name="filter">aktif olanları getir</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Where(bool isActive);

        /// <summary>
        /// Acıklama
        /// </summary>
        /// <param name="orderCreatedDate"> Sıralama parametresi CreatedDate-  Asc or Desc</param>
        /// <param name="orderIsActive"> Sıralama parametresi IsActive -  Asc or Desc</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Order(RepoDb.Enumerations.Order orderCreateDate, RepoDb.Enumerations.Order orderIsActive);

        ///
        List<Post> TumPostlariGetir_Where_Order(int categoryId,bool isActive, RepoDb.Enumerations.Order orderCreateDate);

        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// <param name="count">3 tane getir</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Adet(int count);

        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// <param name="filter">aktif olanları getir</param>
        /// <param name="count">2 tane getir</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Where_Adet(bool isActive, int count);

        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// <param name="orderFields">Createdate alanına göre sırala </param>
        /// <param name="count">3 tane getir</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Order_Adet(RepoDb.Enumerations.Order orderCreateDate, int count);

        /// <summary>
        /// Metot Hankında acıklama
        /// </summary>
        /// <param name="filter">CategoryId 5 olan ve aktif olanlardan</param>
        /// <param name="orderFields">Create date alanına göre ve Title alanına göre sırala</param>
        /// <param name="count">4 tane getir</param>
        /// <returns></returns>
        List<Post> TumPostlariGetir_Where_Order_Adet(int categoryId,bool isActive, RepoDb.Enumerations.Order orderCreateDate, RepoDb.Enumerations.Order orderTitle,int adet);


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
