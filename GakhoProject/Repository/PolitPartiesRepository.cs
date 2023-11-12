using GakhoProject.Data;
using GakhoProject.Models;
using GakhoProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GakhoProject.Repository
{
	public class PolitPartiesRepository : Repository<PolitParties>, IPolitPartiesRepository

	{
		private readonly AplicationDbContext _context;


		public PolitPartiesRepository(AplicationDbContext context) : base(context)
		{
			_context = context;
		}

        public Task update(PolitParties entity)
        {
            throw new NotImplementedException();
        }


        //public async Task update(PolitParties entity)
        //{
        //    var PolitPartiesUpdate = await _context.Yourr
        //}
    }
}
