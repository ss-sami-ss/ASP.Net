using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models.DomainModel.DTO.EF;
using System.Data.Entity;
using System.Threading.Tasks;

namespace WebAPI.Models.DomainModel.POCO
{
    public class ProductRepository
    {
        #region [- ctor -]
        public ProductRepository()
        {

        }
        #endregion

        #region [- Tasks -]

        #region [- SelectAll() -]
        public async Task<List<Models.DomainModel.DTO.EF.Product>> SelectAll()
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Product.ToListAsync();
                    return await q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- InsertInto(Product ref_Product) -]
        public void InsertInto(Product ref_Product)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Product.Add(ref_Product);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- FindProduct(int? id) -]
        public async Task <Product> FindProduct(int? id)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Product.FindAsync(id);
                    return await q;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Update(Product ref_Product) -]
        public void Update(Product ref_Product)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Entry(ref_Product).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- Delete(int? id) -]
        public void Delete(int? id)
        {
            using (var context = new Sam_StoreEntities())
            {
                try
                {
                    var q = context.Product.Find(id);
                    context.Product.Remove(q);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion


        #endregion
    }
}