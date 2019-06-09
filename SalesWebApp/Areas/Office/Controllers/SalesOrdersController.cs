using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesWebApp.Models;

namespace SalesWebApp.Areas.Office.Controllers
{
    public class SalesOrdersController : Controller
    {
        private IdEntities db = new IdEntities();

        // GET: Office/SalesOrders
        public ActionResult Index()
        {
            return View(db.SalesOrders.ToList());
        }

        // GET: Office/SalesOrders/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = db.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }
            return View(salesOrder);
        }

        // GET: Office/SalesOrders/Create
        public ActionResult Create()
        {
            ViewBag.salesDetail = db.SalesOrderDetails.ToList();
            ViewBag.salesDetailForm = new SalesOrderDetail();
            return View();
        }

        // POST: Office/SalesOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DocEntry,CardCode,CardName,DocNum,NumAtCard,DocDate,DocDueDate,DocType,Printed,DocStatus,DocCur,DocRate,SalesOrderNo,GroupNum,SalesEmployee,ContactPerson,ShipTo,BillTo,TaxRate,TotalTax,TaxAmountFC,DiscountForDocument,TotalDiscount,TotalDiscountFC,DocumentTotal,DocumentTotalFC,PaidToDate,PaidFC,Remark")] SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                salesOrder.Id = Guid.NewGuid();
                db.SalesOrders.Add(salesOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesOrder);
        }

        // GET: Office/SalesOrders/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = db.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }
            return View(salesOrder);
        }

        // POST: Office/SalesOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DocEntry,CardCode,CardName,DocNum,NumAtCard,DocDate,DocDueDate,DocType,Printed,DocStatus,DocCur,DocRate,SalesOrderNo,GroupNum,SalesEmployee,ContactPerson,ShipTo,BillTo,TaxRate,TotalTax,TaxAmountFC,DiscountForDocument,TotalDiscount,TotalDiscountFC,DocumentTotal,DocumentTotalFC,PaidToDate,PaidFC,Remark")] SalesOrder salesOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesOrder);
        }

        // GET: Office/SalesOrders/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalesOrder salesOrder = db.SalesOrders.Find(id);
            if (salesOrder == null)
            {
                return HttpNotFound();
            }
            return View(salesOrder);
        }

        // POST: Office/SalesOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            SalesOrder salesOrder = db.SalesOrders.Find(id);
            db.SalesOrders.Remove(salesOrder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
