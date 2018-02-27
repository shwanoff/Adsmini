using Adsmini.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Adsmini.Controllers
{
    [Route("api/card")]
    public class CardController : Controller
    {
        private static List<Card> _cards = new List<Card>
        {
            new Card{ Id = 1, Title = "Заголовок из БД", Date = DateTime.Now, Text = "Не очень подробное описание"}
        };

        private readonly AdsminiContext _context;

        public CardController()
        {
            _context = new AdsminiContext();
        }

        [HttpGet("getall")]
        public IActionResult Index()
        {
            var cards = _context.Cards.ToList().Take(20);
            return new ObjectResult(cards);
        }

        [HttpGet("get/{id}")]
        public IActionResult Details(int id)
        {
            var card = _context.Cards.Find(id);
            if (card == null)
            {
                return NotFound();
            }

            return new ObjectResult(card);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]Card card)
        {
            if (card == null)
            {
                return NotFound();
            }

            card.Date = DateTime.Now.ToUniversalTime();
            _context.Cards.Add(card);
            _context.SaveChanges();

            return new ObjectResult(card);
        }
    }
}
