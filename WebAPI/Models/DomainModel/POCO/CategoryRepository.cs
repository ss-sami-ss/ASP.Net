using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models.DomainModel.DTO.EF;
using System.Data.Entity;
using System.Threading.Tasks;

namespace WebAPI.Models.DomainModel.POCO
{
    public class CategoryRepository
    {

        #region [- ctor -]
        public CategoryRepository()
        {

        }
        #endregion

        #region [- Tasks -]

        #region [- SelectAll() -]
        public async Task<List<Models.DomainModel.DTO.EF.Category>> SelectAll()
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Category.ToListAsync();
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

        #region [- InsertInto(Category ref_Category) -]
        public  void InsertInto(Category ref_Category)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Category.Add(ref_Category);
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

        #region [- FindCategory(int? id) -]
        public async Task<Category> FindCategory(int? id)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    var q = context.Category.FindAsync(id);
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

        #region [- Update(Category ref_Category) -]
        public void Update(Category ref_Category)
        {
            using (var context = new Models.DomainModel.DTO.EF.Sam_StoreEntities())
            {
                try
                {
                    context.Entry(ref_Category).State = EntityState.Modified;
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
                    var q = context.Category.Find(id);
                    context.Category.Remove(q);
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