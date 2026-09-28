using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NkmLesson07Demo.Models;
namespace NkmLesson07Demo.Controllers
{
    public class NkmMemberController : Controller
    {
        private static List<NkmMember> nkmMembers = new List<NkmMember>();
        // GET: NkmMemberController
        public ActionResult Index()
        {
            return View(nkmMembers);
        }

        // GET: NkmMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NkmMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NkmMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NkmMember nkmMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(nkmMember);
                }
                nkmMembers.Add(nkmMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NkmMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NkmMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NkmMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NkmMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
