using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Odyssey.DiagnosticCertificateService.WebApi.Controllers.CertificateGenerationStatus
{
    public class CertificateGenerationStatus : Controller
    {
        // GET: CertificateGenerationStatus
        public ActionResult Index()
        {
            return View();
        }

        // GET: CertificateGenerationStatus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CertificateGenerationStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateGenerationStatus/Create
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

        // GET: CertificateGenerationStatus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CertificateGenerationStatus/Edit/5
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

        // GET: CertificateGenerationStatus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CertificateGenerationStatus/Delete/5
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
