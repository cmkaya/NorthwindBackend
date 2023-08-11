using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IProductService
{
    /// <summary>
    /// Retrieves a list of products.
    /// </summary>
    /// <returns> An encapsulated list of products
    /// and result information. </returns>
    /// <seealso cref="IDataResult{T}"/>
    IDataResult<List<Product>> GetList();
    
    /// <summary>
    /// Retrieves a filtered list of products by category.
    /// </summary>
    /// <param name="categoryId"> Filters the product. </param>
    /// <returns>
    /// Encapsulated list consists of the list of filtered products and
    /// additional result information which may include success result
    /// and error messages.</returns>
    /// <seealso cref="IDataResult{T}"/>
    IDataResult<List<Product>> GetListByCategory(int categoryId);
    
    /// <summary>
    /// Retrieves a product by its id.
    /// </summary>
    /// <param name="productId"> The desired product. </param>
    /// <returns> Detailed information about the product. </returns>
    /// <seealso cref="IDataResult{T}"/>
    IDataResult<Product> GetById(int productId);
    
    /// <summary>
    /// Adds a new product.
    /// </summary>
    /// <param name="product"> Contains the information of the product
    /// to be added. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Add(Product product);
    
    /// <summary>
    /// Updates an existing product.
    /// </summary>
    /// <param name="product"> Contains the information of the product
    /// to be updated. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Update(Product product);
    
    /// <summary>
    /// Deletes a product.
    /// </summary>
    /// <param name="product"> Contains the information of the product
    /// to be deleted. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Delete(Product product);
}