using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCandidate.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        
        public SelectList Parties { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CandidateParties { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> partyQuery = from m in _context.Candidate
                                            orderby m.Party
                                            select m.Party;

            var candidates = from m in _context.Candidate
                        select m;
            
            if (!string.IsNullOrEmpty(CandidateParties))
            {
              candidates = candidates.Where(x => x.Last == CandidateParties);
            }
            Parties = new SelectList(await partyQuery.Distinct().ToListAsync());
            
            Candidate = await candidates.ToListAsync();
        }
    }
}
