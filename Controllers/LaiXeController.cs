using Microsoft.AspNetCore.Mvc;
using Bai21_TranVanQuang.Data;
using Bai21_TranVanQuang.Interfaces;
using Bai21_TranVanQuang.Repositories;
using Bai21_TranVanQuang.Models;
using System.Text.Json;

namespace Bai21_TranVanQuang.Controllers;

public class LaiXeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILaiXeRepository _laixeRepository;


    public LaiXeController(ApplicationDbContext context, ILaiXeRepository memberRepository)
    {
        _context = context;
        _laixeRepository = memberRepository;
    }

    public IActionResult Index()
    {
        var laixe = _laixeRepository.GetAll();
        Console.WriteLine(JsonSerializer.Serialize(laixe));
        return View();
    }
}
