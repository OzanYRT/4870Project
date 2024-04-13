using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace EfFuncCallSK.Models;

public class JobDescription(string companyName, string jobTitle, string jobResponsibilities, string jobRequirements)
{
    [Key]
    public int JobDescriptionId { get; set; }

    [ForeignKey("User")]
    public string UserId { get; set; }

    public string CompanyName { get; set; } = companyName;
    public string JobTitle { get; set; } = jobTitle;
    public string JobResponsibilities { get; set; } = jobResponsibilities;
    public string JobRequirements { get; set; } = jobRequirements;
}


