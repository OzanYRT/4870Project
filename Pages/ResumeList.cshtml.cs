using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfFuncCallSK.Data;
using EfFuncCallSK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
namespace EfFuncCallSK.Pages;

[Authorize]
public class ResumeListModel : PageModel
{

    private readonly ApplicationDbContext _context;
    private readonly ILogger<ResumeListModel> _logger;
    private readonly UserManager<IdentityUser> _userManager;

    private readonly Resume[]? resumes;
    public ResumeListModel(ILogger<ResumeListModel> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _logger = logger;
        _userManager = userManager;
        resumes = _context.Resumes.ToArray();
    }

    [BindProperty]
    public Resume[]? resumes { get; set; }

    public void OnGet()
    {
        resumes = _context.Resumes
        .Where(r => r.Email == _userManager.GetUserName(User))
        .ToList();
    }
}