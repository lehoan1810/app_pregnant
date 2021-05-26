using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pred.Data;
using Pred.Models;

namespace Pred.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;

        public ChatController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            this._userManager = userManager;
            this._context = context;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        public JsonResult GetMessages(string group)
        {
            var hs = Json(_context.chatMessages.Where(x => x.group == group)
                .OrderBy(x => x.time).Take(10),
                new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            var messages = _context.chatMessages.Where(x => x.group == group).ToList();
            return hs;
        }

        public void SaveMessage(string group, string message, string userId)
        {
            var user = _context.Users.Where(u => u.Id == userId);
            ChatMessage chatMessage = new ChatMessage()
            {
                message = message,
                sender = userId,
                group = group,
                time = DateTime.Now
            };
            _context.chatMessages.Add(chatMessage);
            _context.SaveChanges();
        }
    }
}
