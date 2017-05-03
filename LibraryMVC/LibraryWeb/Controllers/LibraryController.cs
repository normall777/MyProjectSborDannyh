using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryModel;
using System.Xml.Serialization;
using LibraryWeb.Models;
using Microsoft.AspNet.Identity;
using OfficeOpenXml;
using System.Web.Hosting;
using System.IO;

namespace LibraryWeb.Controllers
{
    public class LibraryController : Controller
    {
        // GET: Library
        public ActionResult Index()
        {
            return View();
        }

        //Загрузка файлов
        [HttpPost, Authorize]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {//На случай, если файл не был выбран
                var x = (Book)new XmlSerializer(typeof(Book)).Deserialize(file.InputStream);
                using (var context = new ApplicationDbContext())
                {
                    context.Books.Add(
                        new UserBook
                        {
                            UserId = User.Identity.GetUserId(),
                            Author = x.Author,
                            ISBN = x.ISBN,
                            Izdatelstvo = x.Izdatelstvo,
                            SumOfBooks = x.SumOfBooks,
                            Title = x.Title,
                            Town = x.Town,
                            YearOfPublic = x.YearOfPublic,
                            Students = x.student.Select(y => new UserStudent
                            {
                                Group = y.Group,
                                Name = y.Name,
                                Sdacha = y.Sdacha,
                                Surname = y.Surname,
                                Vidacha = y.Vidacha,
                            }).ToList()
                        }
                    );
                    context.SaveChanges();
                }
                return View(x);
        }
            catch (NullReferenceException)
            {
                return View("Index");
            }
        }


        public ActionResult Download(int resoureId)
        {
            var ctx = new ApplicationDbContext();
            var g = ctx.Books.Find(resoureId);

            ExcelPackage pkg;
            using (var stream = System.IO.File.OpenRead(HostingEnvironment.ApplicationPhysicalPath + "template.xlsx"))
            {
                pkg = new ExcelPackage(stream);
                stream.Dispose();
            }
            var worksheet = pkg.Workbook.Worksheets[1];
            worksheet.Name = g.Title;
            worksheet.Cells[1, 1].Value = g.Title;
            worksheet.Cells[3, 2].Value = g.Author;
            worksheet.Cells[4, 2].Value = g.Town;
            worksheet.Cells[5, 2].Value = g.Izdatelstvo;
            worksheet.Cells[6, 2].Value = g.YearOfPublic;
            worksheet.Cells[7, 2].Value = g.ISBN;
            worksheet.Cells[8, 2].Value = g.SumOfBooks;
            int row = 11;
            foreach (var student in g.Students)
            {
                worksheet.Cells[row, 1].Value = student;
                row++;
            }

            // Заполнение файла Excel вышими данными
            var ms = new MemoryStream();
            pkg.SaveAs(ms);

            return File(ms.ToArray(), "application/ooxml", (g.Title ?? "Без Названия").Replace(" ", "") + ".xlsx");
        }




    }
}