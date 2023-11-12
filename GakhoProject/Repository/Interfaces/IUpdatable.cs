namespace GakhoProject.Repository.Interfaces
{
	public interface IUpdatable <T> where T : class
	{
		Task update (T entity);
	}
}
