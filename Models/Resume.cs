using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EfFuncCallSK.Models;
public class Resume(string fullName, string email, string experiences, string education, string skills, string projects)
{
    [Key]
    public int ResumeId { get; set; }
    public string FullName { get; set; } = fullName;
    public string Email { get; set; } = email;

    public string Experiences { get; set; } = experiences;
    public string Education { get; set; } = education;
    public string Skills { get; set; } = skills;

    public string Projects { get; set; } = projects;

    [ForeignKey("JobDescription")]
    public int JobDescriptionId { get; set; }

    public JobDescription JobDescription { get; set; }
}
