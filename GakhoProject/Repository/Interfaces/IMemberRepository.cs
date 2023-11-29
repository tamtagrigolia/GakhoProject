using GakhoProject.Models;

namespace GakhoProject.Repository.Interfaces
{
	public interface IMemberRepository : IRepository<Member>, IUpdatable<Member>
	{
	}
}
