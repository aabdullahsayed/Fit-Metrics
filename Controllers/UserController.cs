using FitnessTracker.Data;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
namespace FitnessTracker.Controllers;

public class UserController:Controller
{
    public readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }
    
    
    public IActionResult Index()
    {
        var users = _context.users.ToList();
        return View(users);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
        // if (ModelState.IsValid)
        // {
        //     _context.Add(user);
        //     _context.SaveChanges();
        //     return RedirectToAction(nameof(Index));
        // }
        
        _context.Add(user);
        _context.SaveChanges();
    return RedirectToAction(nameof(Index));

        //return View(user);
    }
    
}