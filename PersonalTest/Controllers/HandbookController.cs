using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PersonalTest.Data;
using PersonalTest.Models;

namespace PersonalTest.Controllers
{
    public class HandbookController : Controller
    {
        ApplicationDbContext db;

        public HandbookController(ApplicationDbContext context)
        {
            db = context;

        }
        public IActionResult Appoint()
        {
            int i = 1;
            ViewBag.Count = i;

            //var app = db.Appoints.Include("Category")
            //    //.OrderBy(s=>s.Id)
            //    .ToList();
            //IEnumerable<Appoint> app = db.Appoints;
            //var app = from a in db.Appoints
            //          join c in db.Categories
            //            on a.CategoryId equals c.Id
            //          select a;
            //          //select new { AppId=a.Id};
            ////ViewBag.App = db.Appoints;
            ////ViewBag.App = app;
            return View(db.Appoints.ToList());
        }
        [HttpGet]
        public IActionResult AppDel(int? id)
        {
            if (id == null) return RedirectToAction("Appoint");
            Appoint app = db.Appoints.Find(id);
            db.Appoints.Remove(app);
            db.SaveChanges();
            return Redirect("Appoint");
        }
        [HttpGet]
        public async Task<IActionResult> AppointEdit(int? id)
        {
            if (id != null)
            {
                Appoint app = await db.Appoints.FirstOrDefaultAsync(p => p.Id == id);
                if (app != null)
                    return View(app);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AppEdit(Appoint app)
        {
            //Appoint app = db.Appoints.Find(id);
            //db.Entry(app).State = EntityState.Modified;
            db.Update(app);
            await db.SaveChangesAsync();
            return RedirectToAction("Appoint");
        }

        [HttpPost]
        public IActionResult AppAdd(Appoint app)
        {
            if (ModelState.IsValid)
            {
                //ViewBag.Message = "Валидация пройдена";
                db.Appoints.Add(app);
                db.SaveChanges();
                return RedirectToAction("Appoint");
            }
            //ViewBag.Message = "Запрос не прошел валидацию";
            return View(app);
        }
        public IActionResult Category()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Categories.ToList());
        }
        public IActionResult Structure()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Structures.ToList());
        }

        public IActionResult Vacation()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Vacations.ToList());
        }

        public IActionResult WorkCondition()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.WorkConditions.ToList());
        }
        public IActionResult Dismiss()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Dismisses.ToList());
        }
        public IActionResult Education()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Educations.ToList());
        }
        public IActionResult School()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Schools.ToList());
        }
        public IActionResult FamilyStatus()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.FamilyStatuses.ToList());
        }
        public IActionResult Experience()
        {
            int i = 1;
            ViewBag.Count = i;
            return View(db.Experiences.ToList());
        }

        public IActionResult AppointAdd()
        {
            //ViewBag.Category = db.Categories;
            return View();
        }
        public IActionResult CategoryAdd()
        {
            return View();
        }

        public IActionResult DismissAdd()
        {
            return View();
        }
        public IActionResult EducationAdd()
        {
            return View();
        }
        public IActionResult FamilyStatusAdd()
        {
            return View();
        }
        public IActionResult ExperienceAdd()
        {
            return View();
        }
        public IActionResult SchoolAdd()
        {
            return View();
        }
        public IActionResult StructureAdd()
        {
            return View();
        }
        public IActionResult VacationAdd()
        {
            return View();
        }
        public IActionResult WorkConditionAdd()
        {
            return View();
        }
        //============Добавление данных в форму============
        [HttpPost]
        public IActionResult WorkAdd(WorkCondition work)
        {
            if (ModelState.IsValid)
            {
                db.WorkConditions.Add(work);
                db.SaveChanges();
                return Redirect("WorkCondition");
            }
            return View(work);
        }
        [HttpPost]
        public IActionResult CatAdd(Category cat)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return RedirectToAction("Category");
            }
            return View(cat);
        }
        [HttpPost]
        public IActionResult StrAdd(Structure str)
        {
            if (ModelState.IsValid)
            {
                db.Structures.Add(str);
                db.SaveChanges();
                return RedirectToAction("Structure");
            }
            return View(str);
        }
        [HttpPost]
        public IActionResult DisAdd(Dismiss dis)
        {
            if (ModelState.IsValid)
            {
                db.Dismisses.Add(dis);
                db.SaveChanges();
                return Redirect("Dismiss");
            }
            return View(dis);
        }
        [HttpPost]
        public IActionResult EduAdd(Education edu)
        {
            if (ModelState.IsValid)
            {
                db.Educations.Add(edu);
                db.SaveChanges();
                return Redirect("Education");
            }
            return View(edu);
        }
        [HttpPost]
        public IActionResult FamAdd(FamilyStatus fam)
        {
            if (ModelState.IsValid)
            {
                db.FamilyStatuses.Add(fam);
                db.SaveChanges();
                return Redirect("FamilyStatus");
            }
            return View(fam);
        }
        [HttpPost]
        public IActionResult ExpAdd(Experience rel)
        {
            if (ModelState.IsValid)
            {
                db.Experiences.Add(rel);
                db.SaveChanges();
                return Redirect("Experience");
            }
            return View(rel);
        }
        [HttpPost]
        public IActionResult SchAdd(School sch)
        {
            if (ModelState.IsValid)
            {
                db.Schools.Add(sch);
                db.SaveChanges();
                return Redirect("School");
            }
            return View(sch);
        }
        [HttpPost]
        public IActionResult VacAdd(Vacation vac)
        {
            if (ModelState.IsValid)
            {
                db.Vacations.Add(vac);
                db.SaveChanges();
                return Redirect("Vacation");
            }
            return View(vac);
        }
        //===========Удаление данных из формы=====================
        [HttpGet]
        public IActionResult WorkDel(int? id)
        {
            if (id == null) return RedirectToAction("WorkCondition");

            WorkCondition work = db.WorkConditions.Find(id);
            db.WorkConditions.Remove(work);
            db.SaveChanges();
            return Redirect("WorkCondition");
        }
        [HttpGet]
        public IActionResult CatDel(int? id)
        {
            if (id == null) return RedirectToAction("Category");

            Category cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
            return Redirect("Category");
        }
        [HttpGet]
        public IActionResult DisDel(int? id)
        {
            if (id == null) return RedirectToAction("Dismiss");

            Dismiss dis = db.Dismisses.Find(id);
            db.Dismisses.Remove(dis);
            db.SaveChanges();
            return Redirect("Dismiss");
        }
        [HttpGet]
        public IActionResult EduDel(int? id)
        {
            if (id == null) return RedirectToAction("Education");

            Education edu = db.Educations.Find(id);
            db.Educations.Remove(edu);
            db.SaveChanges();
            return Redirect("Education");
        }
        [HttpGet]
        public IActionResult FamDel(int? id)
        {
            if (id == null) return RedirectToAction("FamilyStatus");

            FamilyStatus fam = db.FamilyStatuses.Find(id);
            db.FamilyStatuses.Remove(fam);
            db.SaveChanges();
            return Redirect("FamilyStatus");
        }
        [HttpGet]
        public IActionResult ExpDel(int? id)
        {
            if (id == null) return RedirectToAction("Experience");

            Experience rel = db.Experiences.Find(id);
            db.Experiences.Remove(rel);
            db.SaveChanges();
            return Redirect("Experience");
        }
        [HttpGet]
        public IActionResult SchDel(int? id)
        {
            if (id == null) return RedirectToAction("School");

            School sch = db.Schools.Find(id);
            db.Schools.Remove(sch);
            db.SaveChanges();
            return Redirect("School");
        }
        [HttpGet]
        public IActionResult StrDel(int? id)
        {
            if (id == null) return RedirectToAction("Structure");

            Structure str = db.Structures.Find(id);
            db.Structures.Remove(str);
            db.SaveChanges();
            return Redirect("Structure");
        }
        [HttpGet]
        public IActionResult VacDel(int? id)
        {
            if (id == null) return RedirectToAction("Vacation");

            Vacation vac = db.Vacations.Find(id);
            db.Vacations.Remove(vac);
            db.SaveChanges();
            return Redirect("Vacation");
        }
        //=============Редактирование данных===========================
        [HttpGet]
        public async Task<IActionResult> CategoryEdit(int? id)
        {
            if (id != null)
            {
                Category cat = await db.Categories.FirstOrDefaultAsync(p => p.Id == id);
                if (cat != null)
                    return View(cat);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> CatEdit(Category cat)
        {
            db.Update(cat);
            await db.SaveChangesAsync();
            return RedirectToAction("Category");
        }
        [HttpGet]
        public async Task<IActionResult> DismissEdit(int? id)
        {
            if (id != null)
            {
                Dismiss dis = await db.Dismisses.FirstOrDefaultAsync(p => p.Id == id);
                if (dis != null)
                    return View(dis);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> DisEdit(Dismiss dis)
        {
            db.Update(dis);
            await db.SaveChangesAsync();
            return RedirectToAction("Dismiss");
        }
        [HttpGet]
        public async Task<IActionResult> EducationEdit(int? id)
        {
            if (id != null)
            {
                Education edu = await db.Educations.FirstOrDefaultAsync(p => p.Id == id);
                if (edu != null)
                    return View(edu);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EduEdit(Education edu)
        {
            db.Update(edu);
            await db.SaveChangesAsync();
            return RedirectToAction("Education");
        }
        [HttpGet]
        public async Task<IActionResult> FamilyStatusEdit(int? id)
        {
            if (id != null)
            {
                FamilyStatus fam = await db.FamilyStatuses.FirstOrDefaultAsync(p => p.Id == id);
                if (fam != null)
                    return View(fam);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> FamEdit(FamilyStatus fam)
        {
            db.Update(fam);
            await db.SaveChangesAsync();
            return RedirectToAction("FamilyStatus");
        }
        [HttpGet]
        public async Task<IActionResult> ExperienceEdit(int? id)
        {
            if (id != null)
            {
                Experience rel = await db.Experiences.FirstOrDefaultAsync(p => p.Id == id);
                if (rel != null)
                    return View(rel);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ExpEdit(Experience rel)
        {
            db.Update(rel);
            await db.SaveChangesAsync();
            return RedirectToAction("Experience");
        }
        [HttpGet]
        public async Task<IActionResult> SchoolEdit(int? id)
        {
            if (id != null)
            {
                School sch = await db.Schools.FirstOrDefaultAsync(p => p.Id == id);
                if (sch != null)
                    return View(sch);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> SchEdit(School sch)
        {
            db.Update(sch);
            await db.SaveChangesAsync();
            return RedirectToAction("School");
        }
        [HttpGet]
        public async Task<IActionResult> StructureEdit(int? id)
        {
            if (id != null)
            {
                Structure str = await db.Structures.FirstOrDefaultAsync(p => p.Id == id);
                if (str != null)
                    return View(str);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> StrEdit(Structure str)
        {
            db.Update(str);
            await db.SaveChangesAsync();
            return RedirectToAction("Structure");
        }
        [HttpGet]
        public async Task<IActionResult> VacationEdit(int? id)
        {
            if (id != null)
            {
                Vacation vac = await db.Vacations.FirstOrDefaultAsync(p => p.Id == id);
                if (vac != null)
                    return View(vac);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> VacEdit(Vacation vac)
        {
            db.Update(vac);
            await db.SaveChangesAsync();
            return RedirectToAction("Vacation");
        }
        [HttpGet]
        public async Task<IActionResult> WorkConditionEdit(int? id)
        {
            if (id != null)
            {
                WorkCondition work = await db.WorkConditions.FirstOrDefaultAsync(p => p.Id == id);
                if (work != null)
                    return View(work);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> WorkEdit(WorkCondition work)
        {
            db.Update(work);
            await db.SaveChangesAsync();
            return RedirectToAction("WorkCondition");
        }
    }

}
