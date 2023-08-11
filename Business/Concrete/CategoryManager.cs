using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CategoryManager : ICategoryService
{
    private ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public IDataResult<List<Category>> GetList()
    {
        var data = _categoryDal.GetListFromDatabase();
        return new SuccessDataResult<List<Category>>(data);
    }

    public IDataResult<Category> GetById(int categoryId)
    {
        var data = _categoryDal.GetFromDatabase(c => c.CategoryId == categoryId);
        return new SuccessDataResult<Category>(data);
    }

    public IResult Add(Category category)
    {
        _categoryDal.AddToDatabase(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Update(Category category)
    {
        _categoryDal.UpdateInDatabase(category);
        return new SuccessResult(Messages.CategoryUpdated);
    }

    public IResult Delete(Category category)
    {
        _categoryDal.DeleteFromDatabase(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }
}