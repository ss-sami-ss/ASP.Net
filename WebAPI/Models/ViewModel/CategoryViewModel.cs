using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebAPI.Models.DomainModel.DTO.EF;
using WebAPI.Models.DomainModel.POCO;


namespace WebAPI.Models.ViewModel
{
    public class CategoryViewModel
    {
        #region [- cotr -]
        public CategoryViewModel()
        {
            Ref_CategoryRepository = new CategoryRepository();
        }
        #endregion

        #region [- Props -]

        #region [- Props For Class -]

        public CategoryRepository Ref_CategoryRepository { get; set; }



        #endregion

        #region [- Props For Models -]

        public int Id { get; set; }
        public int? Code { get; set; }
        public string Title { get; set; }
        #endregion
        #endregion

        #region [- Methods -]

        #region [- Get_Category() -]
        public async Task<List<Category>> Get_Category()
        {
            var categories = Ref_CategoryRepository.SelectAll();
            return await categories;
        }
        #endregion

        #region [- Post_Category(CategoryViewModel ref_CategoryViewModel) -]
        public void Post_Category(CategoryViewModel ref_CategoryViewModel)
        {
            Category ref_Category = new Category();
            ref_Category.Code = ref_CategoryViewModel.Code;
            ref_Category.Title = ref_CategoryViewModel.Title;
            Ref_CategoryRepository.InsertInto(ref_Category);
        }
        #endregion

        #region [- Find_Category(int? id) -]
        public async Task<CategoryViewModel> Find_Category(int? id)
        {
            var ref_Category = await Ref_CategoryRepository.FindCategory(id);
            CategoryViewModel ref_CategoryViewModel = new CategoryViewModel();
            ref_CategoryViewModel.Id = ref_Category.Id;
            ref_CategoryViewModel.Code = ref_Category.Code;
            ref_CategoryViewModel.Title = ref_Category.Title;
            return  ref_CategoryViewModel;


            //var  ref_category = Ref_CategoryRepository.FindCategory(id);
            //CategoryViewModel ref_CategoryViewModel = new  CategoryViewModel();
            //ref_CategoryViewModel.Id = ref_category.Id;
            //ref_CategoryViewModel.Code = ref_category.Code;
            //ref_CategoryViewModel.Title = ref_category.Title;
            //return await ref_CategoryViewModel;
        }
        #endregion

        #region [- Put_Category(CategoryViewModel ref_CategoryViewModel) -]
        public void Put_Category(CategoryViewModel ref_CategoryViewModel)
        {
            Category ref_Category = new Category();
            ref_Category.Id = ref_CategoryViewModel.Id;
            ref_Category.Code = ref_CategoryViewModel.Code;
            ref_Category.Title = ref_CategoryViewModel.Title;
            Ref_CategoryRepository.Update(ref_Category);

        }
        #endregion

        #region [- Delete_Category(int? id) -]
        public void Delete_Category(int? id)
        {
            Ref_CategoryRepository.Delete(id);
        }
        #endregion


        #endregion
    }
}