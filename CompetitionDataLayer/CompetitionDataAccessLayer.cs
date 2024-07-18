using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionDomainModel;

namespace CompetitionDataLayer
{
    public class CompetitionDataAccessLayer
    {
        private readonly AppDbContext _appDbContext;

        public CompetitionDataAccessLayer(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Competition> GetAllCompetitions() 
        {
            return _appDbContext.Competitions.Include(t => t.Participants).ToList();
        }

        public Competition GetCompetitionById(Guid id)
        {
            try
            {
                var competition = _appDbContext.Competitions.FirstOrDefault(c => c.Id == id);
                if (competition == null)
                {
                    throw new InvalidOperationException($"Competition with ID {id} not found.");
                }
                return competition;
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
            
            
        } 

    }

}
