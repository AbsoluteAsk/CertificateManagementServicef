using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerator
{
    public class CertificateGenerator : Controller
    {
        // GET: CertificateGenerator
        public ActionResult Index()
        {
            return View();
        }

        // GET: CertificateGenerator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CertificateGenerator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateGenerator/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CertificateGenerator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificateGenerator/Edit/5
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

        // GET: CertificateGenerator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificateGenerator/Delete/5
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
