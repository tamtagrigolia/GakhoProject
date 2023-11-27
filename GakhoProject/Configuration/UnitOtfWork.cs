using GakhoProject.Data;
using GakhoProject.Repository;
using GakhoProject.Repository.Interfaces;
using GakhoProject.Services;
using GakhoProject.Services.Interfaces;

namespace GakhoProject.Configuration
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AplicationDbContext _context;

		public IPolitPartiesRepository PolitParty { get; private set; }
		public IMemberRepository Member { get; private set; }


		public IPolitPartieService PolitPartieService { get; private set; }
		public IMemberService MemberService { get; private set; }


		public UnitOfWork(AplicationDbContext context)
		{
			_context = context;
			PolitParty = new PolitPartiesRepository(_context);
			PolitPartieService = new PolitPartieService(PolitParty);

		}

			public async Task Save()
		{
			await _context.SaveChangesAsync();
				}

	}
}
