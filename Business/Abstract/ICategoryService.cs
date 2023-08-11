using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ICategoryService
{
    /// <summary>
    /// Retrieves a list of categories.
    /// </summary>
    /// <returns> An encapsulated list of categories
    /// and result information. </returns>
    /// <seealso cref="IDataResult{T}"/>
    IDataResult<List<Category>> GetList();
    
    /// <summary>
    /// Retrieves a category by its id.
    /// </summary>
    /// <param name="categoryId"> The desired category. </param>
    /// <returns> Detailed information about the category. </returns>
    /// <seealso cref="IDataResult{T}"/>
    IDataResult<Category> GetById(int categoryId);
    
    /// <summary>
    /// Adds a new category.
    /// </summary>
    /// <param name="category"> Contains the information of the category
    /// to be added. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Add(Category category);
    
    /// <summary>
    /// Updates an existing category.
    /// </summary>
    /// <param name="category"> Contains the information of the category
    /// to be updated. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Update(Category category);
    
    /// <summary>
    /// Deletes a category.
    /// </summary>
    /// <param name="category"> Contains the information of the category
    /// to be deleted. </param>
    /// <returns> A result indicating whether the addition was successful,
    /// along with any relevant error messages. </returns>
    /// <seealso cref="IResult"/>
    IResult Delete(Category category);
}