using GakhoProject.Data;
using GakhoProject.Models;
using GakhoProject.Repository.Interfaces;

namespace GakhoProject.Repository
{
	public class MemberRepository : Repository<Member>, IMemberRepository
	{
		private readonly AplicationDbContext _context;

		public MemberRepository(AplicationDbContext context) : base(context)
		{
			_context = context;

		}

		public Task update(Member entity)
		{
			throw new NotImplementedException();
		}
	}
}
