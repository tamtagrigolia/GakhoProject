using GakhoProject.Models;
using GakhoProject.Repository;
using GakhoProject.Repository.Interfaces;
using GakhoProject.Services.Interfaces;

namespace GakhoProject.Services
{
	public class PolitPartieService : IPolitPartieService
	{
		private readonly IPolitPartiesRepository _PolitPartiesRepository;
		public PolitPartieService(IPolitPartiesRepository PolitPartiesRepository)

		{
			_PolitPartiesRepository = PolitPartiesRepository;
		}
public async Task Add(PolitParties model)
		{
			if (model is null)
				throw new ArgumentNullException(nameof(model));
			await _PolitPartiesRepository.Add(model);

		}
		public async  Task DeletePolitParties(PolitParties model)
		{
			var result = await _PolitPartiesRepository.Get(YourName => YourName.Id == model.Id);

			if (result is not null)
			{
				_PolitPartiesRepository.Remove(result);
			}
			else
			{
				throw new NullReferenceException();
			}
		}

		public async Task<List<PolitParties>> GetAllPolitParties()
		{
			var result = await _PolitPartiesRepository.GetAll();

			if (result.Count() > 0)
			{
				return result.ToList();
			}
			else
			{
				throw new NullReferenceException();
			}
		}

		public async Task<PolitParties> GetPolitParts(int id)
		{
			var result = await _PolitPartiesRepository.Get(author => author.Id == id);

			if (result is not null)
			{
				return result;
			}
			else
			{
				throw new NullReferenceException();
			}
		}

		public void Update(PolitParties politParties)
		{
			if (politParties is not null)
			{
				_PolitPartiesRepository.update(politParties);
			}
			else
			{
				throw new NullReferenceException();
			}
		}
	}
}
