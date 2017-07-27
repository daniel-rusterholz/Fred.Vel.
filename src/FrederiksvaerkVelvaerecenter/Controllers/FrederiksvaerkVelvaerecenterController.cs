using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FrederiksvaerkVelvaerecenter.Data;
using FrederiksvaerkVelvaerecenter.Models;

namespace FrederiksvaerkVelvaerecenter.Controllers
{
    public class FrederiksvaerkVelvaerecenterController : Controller
    {
        private HealerRepository _HealerRepository = null;

        public FrederiksvaerkVelvaerecenterController()
        {
            _HealerRepository = new HealerRepository();
        }

        public ActionResult Detail()
        {
            var healers = _HealerRepository.GetHealers();

            return View(healers);
        }
    }
}