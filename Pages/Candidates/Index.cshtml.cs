using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCandidate.Models;

namespace candidate.Pages_Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RazorCandidate.Models.RazorCandidateContext _context;

        public IndexModel(RazorCandidate.Models.RazorCandidateContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }
    }
}
