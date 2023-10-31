using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Eol.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Eol.Controllers;

public class MessagesController : Controller
{
  private readonly ILogger<MessagesController> _logger;

  public MessagesController(ILogger<MessagesController> logger)
  {
    _logger = logger;
  }

  public ActionResult Private()
  {
    return View();
  }
}
