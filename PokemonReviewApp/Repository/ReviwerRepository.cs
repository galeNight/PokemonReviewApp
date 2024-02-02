using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Intefaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class ReviwerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReviwerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers.Where(r => r.Id == reviewerId).Include(e => e.Reviews).FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public ICollection<Review> GetReviewsByReviwer(int reviwerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviwerId).ToList();
        }

        public bool ReviewerExists(int reviwerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviwerId);
        }
    }
}
