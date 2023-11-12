using System.Linq.Expressions;

namespace GakhoProject.Repository.Interfaces
{
	public interface IRepository <T> where T : class
	{
		Task<IEnumerable<T>> GetAll(string? includeProperties = null);
		Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, string? includeProperties = null);
		Task<T> Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
		Task Add(T entity);
		void Remove(T entity);
	}
}
