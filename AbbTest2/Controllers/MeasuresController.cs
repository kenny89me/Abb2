using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AbbTest2.DAL;
using AbbTest2.Models;
using AbbTest2.ServiceReference1;
using AbbTest2.ServiceReference2;





namespace AbbTest2.Controllers
{
    public class MeasuresController : Controller
    {
        AbbTest2Context db = new AbbTest2Context();

        //private AbbTest2Context db = new AbbTest2Context();

        // GET: Measures
        public ActionResult Index()
        {


            var measures = db.Measures.Include(m => m.Motor);
            foreach (var mes in measures)
            {
                mes.CurrentA = mes.Motor.CurrentA;
                mes.MaxTorque = mes.Motor.MaxTorque;
                mes.MaxPressure = mes.Motor.MaxPressure;

                switch (mes.MotorId)
                {
                    case 1:
                        mes.Difference = mes.Motor.CurrentA - mes.ActualCurrentA;
                        break;

                    case 2:
                        mes.Difference = mes.MaxTorque - mes.ActualRevsRpm;
                        break;

                    case 3:
                        mes.Difference = mes.MaxPressure - mes.ActualPressureBar;
                        break;
                }


                db.SaveChanges();

            }
            return View(measures.ToList());

        }

        public ActionResult Index2()
        {

            var measures = db.Measures.Include(m => m.Motor);
            foreach (var mes in measures)
            {
                mes.CurrentA = mes.Motor.CurrentA;
                mes.MaxTorque = mes.Motor.MaxTorque;
                mes.MaxPressure = mes.Motor.MaxPressure;

                switch (mes.MotorId)
                {
                    case 1:
                        mes.Difference = mes.Motor.CurrentA - mes.ActualCurrentA;
                        break;

                    case 2:
                        mes.Difference = mes.MaxTorque - mes.ActualRevsRpm;
                        break;

                    case 3:
                        mes.Difference = mes.MaxPressure - mes.ActualPressureBar;
                        break;
                }

            }

            db.SaveChanges();


            ServiceClient l = new ServiceClient();
            ServiceReference2.Service1Client k = new Service1Client();


            /*List<object> mlkList = null;
            foreach (var k in l.GetMeasures())
            {

            }*/

            return View(k.GetMeasures());
        }



        // GET: Measures/Details/5
        /*public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            return View(measure);
        }

        // GET: Measures/Create
        public ActionResult Create()
        {
            ViewBag.MotorId = new SelectList(db.Motors, "MotorId", "MotorName");
            return View();
        }

        // POST: Measures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeasureId,Timestamp,MotorId,MotorName,CurrentA,MaxTorque,MaxPressure,ActualCurrentA,ActualRevsRpm,ActualPressureBar,Difference")] Measure measure)
        {
            if (ModelState.IsValid)
            {
                db.Measures.Add(measure);
                db.SaveChanges();
                return RedirectToAction("Index2");
            }

            ViewBag.MotorId = new SelectList(db.Motors, "MotorId", "MotorName", measure.MotorId);
            return View(db.Measures);
        }

        // GET: Measures/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            ViewBag.MotorId = new SelectList(db.Motors, "MotorId", "MotorName", measure.MotorId);
            return View(measure);
        }

        // POST: Measures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeasureId,Timestamp,MotorId,MotorName,CurrentA,MaxTorque,MaxPressure,ActualCurrentA,ActualRevsRpm,ActualPressureBar,Difference")] Measure measure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(measure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index2");
            }
            ViewBag.MotorId = new SelectList(db.Motors, "MotorId", "MotorName", measure.MotorId);
            return View(measure);
        }

        // GET: Measures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measure measure = db.Measures.Find(id);
            if (measure == null)
            {
                return HttpNotFound();
            }
            return View(measure);
        }

        // POST: Measures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Measure measure = db.Measures.Find(id);
            db.Measures.Remove(measure);
            db.SaveChanges();
            return RedirectToAction("Index2");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }*/
    }
}
