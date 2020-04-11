using RepoDb;
using RepoDb.Enumerations;
using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class PostManager : IPostService
    {
        private readonly IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

         /// <summary>
         /// Acıklama
         /// </summary>
         /// <returns></returns>
        public List<Post> TumPostlariGetir()
        {
            return _postDal.GetList();
        }

        /// <summary>
        /// Acıklama
        /// </summary>
        /// <param name="count"> Kac adet istiyorsunuz</param>
        /// <returns></returns>
        public List<Post> TumPostlariGetir_Adet(int count)
        {
            return _postDal.GetList(count);
        }

        /// <summary>
        /// Acıklama
        /// </summary>
        /// <param name="orderCreatedDate"> Sıralama parametresi CreatedDate-  Asc or Desc</param>
        /// <param name="orderIsActive">Sıralama parametresi IsActive -  Asc or Desc</param>
        /// <returns></returns>
        public List<Post> TumPostlariGetir_Order(Order orderCreatedDate, Order orderIsActive)
        {
            var sort = new[] { new OrderField("CreatedDate", orderCreatedDate),
                               new OrderField("IsActive", orderIsActive)
                             };

            return _postDal.GetList(sort);
        }

         
        public List<Post> TumPostlariGetir_Order_Adet(Order orderCreatedDate, int count)
        {
            var sort = new[] { new OrderField("CreatedDate", orderCreatedDate) };
            return _postDal.GetList(sort, count);
        }

         
        public List<Post> TumPostlariGetir_Where(bool isActive)
        {

            return _postDal.GetList(x => x.IsActive == isActive);
        }

         
        public List<Post> TumPostlariGetir_Where_Adet(bool isActive, int count)
        {
            return _postDal.GetList(x => x.IsActive == isActive, count);
        }

        
        public List<Post> TumPostlariGetir_Where_Order(int categoryId, bool isActive, Order orderCreatedDate)
        {
            var sort = new[] { new OrderField("CreatedDate", orderCreatedDate) };
            return _postDal.GetList(c => c.CategoryId == categoryId && c.IsActive == isActive);
        }

         
        
        public List<Post> TumPostlariGetir_Where_Order_Adet(int categoryId, bool isActive, Order orderCreatedDate, Order orderTitle, int adet)
        {
            var sort = new[] {
                                new OrderField("CreatedDate", orderCreatedDate),
                                new OrderField("Title", orderTitle)
                              };
            return _postDal.GetList(c => c.CategoryId == categoryId && c.IsActive == isActive, sort, adet);
        }

        //public List<Post> TumPostlariGetir()
        //{
        //    return _postDal.GetList();
        //}

        //public List<Post> TumPostlariGetir_Adet(int count)
        //{
        //    return _postDal.GetList(count);
        //}

        //public List<Post> TumPostlariGetir_Order(IEnumerable<OrderField> orderFields)
        //{
        //    return _postDal.GetList(orderFields);
        //}

        //public List<Post> TumPostlariGetir_Order_Adet(IEnumerable<OrderField> orderFields, int count)
        //{
        //    return _postDal.GetList(orderFields, count);
        //}

        //public List<Post> TumPostlariGetir_Where(Expression<Func<Post, bool>> filter)
        //{
        //    return _postDal.GetList(filter);
        //}

        //public List<Post> TumPostlariGetir_Where_Adet(Expression<Func<Post, bool>> filter, int count)
        //{
        //    return _postDal.GetList(filter, count);
        //}

        //public List<Post> TumPostlariGetir_Where_Order(Expression<Func<Post, bool>> filter, IEnumerable<OrderField> orderFields)
        //{
        //    return _postDal.GetList(filter, orderFields);
        //}

        //public List<Post> TumPostlariGetir_Where_Order_Adet(Expression<Func<Post, bool>> filter, IEnumerable<OrderField> orderFields, int count)
        //{
        //    return _postDal.GetList(filter, orderFields, count);
        //}




        //public List<Post> TumPostlariGetirTariheGoreSiraliAdetsiz(IEnumerable<OrderField> orderFields, int? count)
        //{
        //    return _postDal.GetList(null, orderFields, count);
        //}

        //public List<Post> TumPostlariGetirTariheGoreSirasiz(IEnumerable<OrderField> orderFields)
        //{
        //    var data = _postDal.GetList(null, null, null);
        //    return data;
        //}
    }
}
