using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalTest.Data;
using PersonalTest.Models;

namespace PersonalTest.Controllers
{
    public class TabelVar
    {
        public string TabVar { get; set; }
    }
    public class DocumentController : Controller
    {
        ApplicationDbContext db;
       
        public DocumentController(ApplicationDbContext context)
        {
            db = context;
        }


        public IActionResult StaffingTable()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Staffs.Include("Structure").Include("Appoint").ToList());
        }

        [HttpGet]
        public IActionResult StaffingAdd()
        {
            SelectList str = new SelectList(db.Structures, "Id", "StructName");
            SelectList app = new SelectList(db.Appoints, "Id", "AppName");
            ViewBag.Str = str;
            ViewBag.App = app;
            return View();
        }
        [HttpPost]
        public IActionResult StaffAdd(StaffingTable staff)
        {
            if (ModelState.IsValid)
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
                return Redirect("StaffingTable");
            }
            return View(staff);
        }

        [HttpGet]
        public IActionResult StaffDel(int? id)
        {
            if (id == null) return RedirectToAction("StaffingTable");
            StaffingTable sta = db.Staffs.Find(id);
            db.Staffs.Remove(sta);
            db.SaveChanges();
            return Redirect("StaffingTable");
        }

        [HttpGet]
        public async Task<IActionResult> StaffingEdit(int? id)
        {
            if (id != null)
            {
                StaffingTable sta = await db.Staffs.FirstOrDefaultAsync(p => p.Id == id);
                if (sta != null)
                    return View(sta);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult StaffEdit(StaffingTable sta)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(sta).State = EntityState.Modified;
                db.Update(sta);
                db.SaveChanges();
                return RedirectToAction("StaffingTable");
            }
            return View(sta);
        }
        public IActionResult Employee()
        {
            return View(db.Employees.ToList());
        }
        [HttpGet]
        public IActionResult EmployeeAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmpAdd(Employee emp)
        {
            if (ModelState.IsValid)
            {
                emp.Fio = emp.LastName + " " + emp.FirstName[0] + ". " + emp.Patronymic[0] + ".";
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Employee");
            }
            return View(emp);
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeEdit(int? id)
        {
            if (id != null)
            {
                Employee emp = await db.Employees.FirstOrDefaultAsync(p => p.Id == id);
                if (emp != null)
                {
                    ViewBag.Emp = emp;
                    return View(emp);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult EmpEdit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(sta).State = EntityState.Modified;
                db.Update(emp);
                db.SaveChanges();
                return RedirectToAction("Employee");
            }
            return View(emp);
        }
        [HttpGet]
        public IActionResult EmpDel(int? id)
        {
            if (id == null) return RedirectToAction("Employee");
            Employee emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return Redirect("Employee");
        }
        public IActionResult Tabel()
        {
            TabelVar tb = new TabelVar();

            return View(tb);
        }

        [HttpPost]
        public IActionResult TabelSelect(TabelVar tab)
        {
            if (ModelState.IsValid)
                {
                if (tab.TabVar == "select")
                    return Redirect("TabSelect");
                else if (tab.TabVar == "new")
                    return Redirect("TabelNew");
            }
            return View("Tabel");
        }
        public IActionResult TabSelect()
        {

            SelectList tab = new SelectList(db.Tabels, "Id", "NumDataMaking");
            ViewBag.Tab = tab;
            return View();
        }
        [HttpGet]
        public IActionResult TabelNew()
        {
            //int yrs = 20;
            int[] year = new int[21];
            for (int i = 0; i < 21; i++)
            {
                year[i] = (DateTime.Now.Year - 10) + i;
            }
            SelectList str = new SelectList(db.Structures, "Id", "StructName");
            ViewBag.Str = str;
            ViewBag.Month = new SelectList(new string[]
            { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" }) ;
            SelectList years = new SelectList(year);
            ViewBag.Year = years;
            return View();
        }
        [HttpPost]
        public IActionResult TabNew(Tabel tab)
        {
            if (ModelState.IsValid)
            {
                tab.NumDataMaking = "№ " + tab.Number + " от " + tab.DateMaking.ToShortDateString();
                db.Tabels.Add(tab);
                db.SaveChanges();
                return View(db.Tabels.Include("Structure").AsEnumerable().LastOrDefault());
            }
            return View(tab);
        }
        //Временный модуль для отображения таблицы 
        public IActionResult TabNewMain()
        {
            return View("TabNew", db.Tabels.Include("Structure").AsEnumerable().LastOrDefault());
        }
        [HttpGet]
        public IActionResult TabelWork(int? id)
        {
            Tabel tb = db.Tabels.Find(id);
            TempData["Id"] = id;
            //TempData["Tabel"] = tb;
            int[] year = new int[21];
            for (int i = 0; i < 21; i++)
            {
                year[i] = (DateTime.Now.Year - 10) + i;
            }
            SelectList tab = new SelectList(db.Tabels, "Id", "NumDataMaking");
            SelectList fio = new SelectList(db.Employees, "Id", "Fio");
            SelectList app = new SelectList(db.Appoints, "Id", "AppName");
            ViewBag.Tab = tb.NumDataMaking;
            ViewBag.Fio = fio;
            ViewBag.App = app;
            ViewBag.Month = new SelectList(new string[]
            { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" });
            SelectList years = new SelectList(year);
            ViewBag.Year = years;
            return View();
        }
        [HttpPost]
        public IActionResult TabAdd(TabelWork tab)
        {
            //tab.TabelId = 3;
            if (ModelState.IsValid)
            {
                tab.TabelId = (int)TempData["Id"];
                db.TabelWorks.Add(tab);
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[TabWorks] ON;");
                db.SaveChanges();
                //db.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[TabWorks] OFF;");
                
                return Redirect("TabWork");
            }
            return View(tab);
        }

     
        public IActionResult TabWork()
        {
            int i = 1;
            ViewBag.Count = i;
            int id = (int)TempData["Id"];
            Tabel tbw = db.Tabels.Find(id);
            var tabid = id;
            ViewBag.Tab = tbw;
            return View(db.TabelWorks.Where(p => p.TabelId == id)
                .Include("Employee").Include("Appoint").Include("Tabel").ToList());
        }
        [HttpPost]
        public IActionResult TabResult(Tabel tab)
        {
            int id = tab.Id;
            return View(db.Tabels.Where(p => p.Id == tab.Id).Include("Structure").FirstOrDefault()) ;
        }

        [HttpGet]
        public IActionResult TabelWorkResult(int? id)
        {
            int i = 1;
            ViewBag.Count = i;
            //int id = (int)TempData["Id"];
            TempData["Id"] = id;
            Tabel tbw = db.Tabels.Find(id);
            //var tabid = id;
            ViewBag.Tab = tbw;
            return View(db.TabelWorks.Where(p => p.TabelId == id).Include("Employee").Include("Appoint").Include("Tabel").ToList());
        }

        
        public IActionResult TabResultAdd()
        {

            return View(db.Tabels.Where(p => p.Id == (int)TempData["Id"]).Include("Structure").FirstOrDefault());
        }

    }
}