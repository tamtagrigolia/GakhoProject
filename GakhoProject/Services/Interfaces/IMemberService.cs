using GakhoProject.Models;

namespace GakhoProject.Services.Interfaces
{
	public interface IMemberService
	{
		Task<List<Member>> GetAllMembers();


	}
}
