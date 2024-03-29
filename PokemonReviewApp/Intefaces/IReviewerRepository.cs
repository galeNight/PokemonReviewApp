﻿using PokemonReviewApp.Models;
using System.Collections;

namespace PokemonReviewApp.Intefaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewsByReviwer(int reviwerId);
        bool ReviewerExists(int reviwerId);
        bool CreaterReviewer(Reviewer reviewer);
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReviewer(Reviewer reviewer);
        bool Save();
    }
}
