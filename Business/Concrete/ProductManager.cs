using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IDataResult<List<Product>> GetList()
    {
        List<Product> fetchedProducts = _productDal.GetListFromDatabase().ToList();
        return new SuccessDataResult<List<Product>>(fetchedProducts);
    }

    public IDataResult<List<Product>> GetListByCategory(int categoryId)
    {
        List<Product> fetchedProducts = _productDal.GetListFromDatabase(
            p => p.CategoryId == categoryId).ToList();
        return new SuccessDataResult<List<Product>>(fetchedProducts);
    }

    public IDataResult<Product> GetById(int productId)
    {
        Product fetchedProduct = _productDal.GetFromDatabase(
            p => p.ProductId == productId);
        return new SuccessDataResult<Product>(fetchedProduct);
    }

    public IResult Add(Product product)
    {
        _productDal.AddToDatabase(product);
        return new SuccessResult(Messages.ProductAdded);
    }

    public IResult Update(Product product)
    {
        _productDal.UpdateInDatabase(product);
        return new SuccessResult(Messages.ProductUpdated);
    }

    public IResult Delete(Product product)
    {
        _productDal.DeleteFromDatabase(product);
        return new SuccessResult(Messages.ProductDeleted);
    }
}