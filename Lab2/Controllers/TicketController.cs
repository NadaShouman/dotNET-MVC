using Microsoft.AspNetCore.Mvc;
using Lab2.Models.View;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;
using Lab2.Models.Domain;
using System.Net.Sockets;

namespace Lab2.Controllers
{
    public class TicketController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTicketVM ticketVM)
        {

            var newTicket = new Ticket
            {
                CreatedTime = DateTime.Now,
                IsClosed = ticketVM.IsClosed,
                Severity = ticketVM.Severity,
                Description = ticketVM.Description,
            };
            Ticket.GetTickets().Add(newTicket);
            return RedirectToAction(nameof(GetAll));
        }

        public IActionResult GetAll()
        {
            var tickets = Ticket.GetTickets();
            return View(tickets);
        }


    }
}
