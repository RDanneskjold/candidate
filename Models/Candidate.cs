using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorCandidate.Models
{
  public class Candidate
  {
    public int ID { get; set; }
    public string Last { get; set; }
    public string First { get; set; }

    [DataType(DataType.Date)]
    public DateTime AnnounceDate { get; set; }
    public string Party { get; set; }
  }
}