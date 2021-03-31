using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalTest.Data;

namespace PersonalTest.Models
{
    public static class SampleData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            //using (PersonalContext db = new PersonalContext())
            //{
            if (db.Categories.Count() == 0)
            {
                Category cat1 = new Category { CatName = "Руководители" };
                Category cat2 = new Category { CatName = "Специалисты" };
                Category cat3 = new Category { CatName = "Служащие" };
                Category cat4 = new Category { CatName = "Ученики" };
                Category cat5 = new Category { CatName = "Водители" };
                Category cat6 = new Category { CatName = "Рабочие" };
                db.Categories.AddRange(new List<Category> { cat1, cat2, cat3, cat4, cat5, cat6 });
                db.SaveChanges();
            }
            if (db.Appoints.Count() == 0)
            {
                db.Appoints.AddRange(new Appoint { AppName = "Водитель 1 класса" },
                new Appoint { AppName = "Оператор" },
                new Appoint { AppName = "Электрик" },
                new Appoint { AppName = "Директор" },
                new Appoint { AppName = "Зам. директора" },
                new Appoint { AppName = "Главный инженер" },
                new Appoint { AppName = "Главный бухгалтер" },
                new Appoint { AppName = "Главный энергетик" },
                new Appoint { AppName = "Мастер" },
                new Appoint { AppName = "Производитель работ" },
                new Appoint { AppName = "Начальник отдела" },
                new Appoint { AppName = "Секретарь" },
                new Appoint { AppName = "Агент по снабжению" },
                new Appoint { AppName = "Кладовщик" },
                new Appoint { AppName = "Торговый агент" },
                new Appoint { AppName = "Ведущий специалист по кадрам" },
                new Appoint { AppName = "Энергетик" },
                new Appoint { AppName = "Механик" },
                new Appoint { AppName = "Ведущий бухгалтер" },
                new Appoint { AppName = "Юрисконсульт" },
                new Appoint { AppName = "Бухгалтер 1 категории" },
                new Appoint { AppName = "Экономист" });
                db.SaveChanges();
            }
            if (db.Structures.Count() == 0)
            {
                //    //db.Structures.AddRange(
                db.Structures.Add(new Structure { StructName = "Дирекция" });
                db.Structures.Add(new Structure { StructName = "Бухгалтерия" });
                db.Structures.Add(new Structure { StructName = "Юридический отдел" });
                db.Structures.Add(new Structure { StructName = "Транспортный отдел" });
                db.Structures.Add(new Structure { StructName = "Отдел маркетинга" });
                db.Structures.Add(new Structure { StructName = "Плановый отдел" });
                db.Structures.Add(new Structure { StructName = "Отдел кадров" });
                db.Structures.Add(new Structure { StructName = "Отдел деловодства" });
                db.Structures.Add(new Structure { StructName = "Цех №1" });
                db.Structures.Add(new Structure { StructName = "Цех №2" });
                db.Structures.Add(new Structure { StructName = "Отдел сбыта" });
                //db.Structures.OrderBy(i => i.Id);
                db.SaveChanges();
            }
            if (db.Vacations.Count() == 0)
            {
                db.Vacations.Add(new Vacation { Name = "Ежегодный отпуск" });
                db.Vacations.Add(new Vacation { Name = "Дополнительный отпуск за характер работы" });
                db.Vacations.Add(new Vacation { Name = "Учебный отпуск" });
                db.Vacations.Add(new Vacation { Name = "Творческий отпуск" });
                db.Vacations.Add(new Vacation { Name = "Отпуск для подготовки к соревнованиям" });
                db.Vacations.Add(new Vacation { Name = "Отпуск без сохранения зарплаты" });
                db.Vacations.Add(new Vacation { Name = "Отпуск по беременности и родам" });
                db.Vacations.Add(new Vacation { Name = "Отпуск по уходу за ребенком до 3 лет" });
                db.Vacations.Add(new Vacation { Name = "Дополнительный отпуск имеющим детей" });
                //db.Vacations.OrderBy(i => i.Id);
                db.SaveChanges();
            }
            if (db.Educations.Count() == 0)
            {
                db.Educations.AddRange(new Education { Name = "Общее среднее образование" },
                new Education { Name = "Внешкольное образование" },
                new Education { Name = "Профессионально-техническое образование" },
                new Education { Name = "Высшее образование" },
                new Education { Name = "Последипломное образование" },
                new Education { Name = "Аспирантура" },
                new Education { Name = "Докторантура" });
                //db.Educations.OrderBy(o => o.Id);
                db.SaveChanges();
            }
            if (db.WorkConditions.Count() == 0)
            {
                db.WorkConditions.AddRange(new WorkCondition { Name = "Оптимальные условия труда" },
                new WorkCondition { Name = "Допустимые условия труда" },
                new WorkCondition { Name = "Вредные условия труда" },
                new WorkCondition { Name = "Опасные условия труда" });
                //db.WorkConditions.OrderBy(o => o.Id);
                db.SaveChanges();
            }
            if (db.Dismisses.Count() == 0)
            {
                db.Dismisses.Add(new Dismiss { Name = "По собственному желанию" });
                db.Dismisses.Add(new Dismiss { Name = "По сокращению штатов" });
                db.Dismisses.Add(new Dismiss { Name = "По соглашению сторон" });
                db.Dismisses.Add(new Dismiss { Name = "По истечению срока трудового договора" });
                db.Dismisses.Add(new Dismiss { Name = "За прогул" });
                db.Dismisses.Add(new Dismiss { Name = "На испытательном сроке" });
                db.Dismisses.Add(new Dismiss { Name = "В связи с ликвидацией предприятия" });
                db.Dismisses.Add(new Dismiss { Name = "За нарушение трудовой дисциплины" });
                db.Dismisses.Add(new Dismiss { Name = "В связи с длительной нетрудоспособностью" });
                db.Dismisses.Add(new Dismiss { Name = "За несоответствие занимаемой должности" });
                //db.Dismisses.OrderBy(i => i.Id);
                db.SaveChanges();
            }
            if (db.Schools.Count() == 0)
            {
                db.Schools.Add(new School { Name = "Средняя школа" });
                db.Schools.Add(new School { Name = "Лицей (профессионально-техническое училище)" });
                db.Schools.Add(new School { Name = "Колледж (техникум)" });
                db.Schools.Add(new School { Name = "Университет" });
                db.Schools.Add(new School { Name = "Академия" });
                db.Schools.Add(new School { Name = "Высшее училище" });

                //db.Dismisses.OrderBy(i => i.Id);
                db.SaveChanges();
            }
            if (db.FamilyStatuses.Count() == 0)
            {
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Холост" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Не замужем" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Женат" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Замужем" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Разведен" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Разведена" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Вдовец" });
                db.FamilyStatuses.Add(new FamilyStatus { Name = "Вдова" });
                db.SaveChanges();
            }
            if (db.Experiences.Count() == 0)
            {
                db.Experiences.Add(new Experience { Name = "Общий стаж" });
                db.Experiences.Add(new Experience { Name = "Непрерывный стаж" });
                db.Experiences.Add(new Experience { Name = "Страховой стаж" });
                db.Experiences.Add(new Experience { Name = "Специальный стаж" });
                db.Experiences.Add(new Experience { Name = "Стаж госслужбы" });
                db.SaveChanges();
            }
            if (db.Staffs.Count() == 0)
            {
                db.Staffs.Add(new StaffingTable { });
                db.SaveChanges();
            }
            if (db.Employees.Count() == 0)
            {
                db.Employees.Add(new Employee { });
                db.SaveChanges();
            }

        }
    }
}
