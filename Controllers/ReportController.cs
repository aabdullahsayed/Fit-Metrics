using FitnessTracker.Data;
using FitnessTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Fitness_Tracker.Controllers;

public class ReportController:Controller
{
    public readonly AppDbContext _context;

    public ReportController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var report = _context.reports;

        return View(report);
    }

[HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Report report)
    {
        _context.Add(report);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}