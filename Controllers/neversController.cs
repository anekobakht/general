using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pishnahad.Models;
using pishnahad.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using ClosedXML.Excel;




namespace pishnahad.Controllers
{
    [RequestFormLimits(MultipartBodyLengthLimit = 268435456)]
    
    public class neversController : Controller
    {
        private string[] Mobiles;
        private readonly pishnahadContext _context;

        public neversController(pishnahadContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> dashboard()
        {

            return View(_context.never);

        }

        //============================================================Jensiat
        //public async Task<IActionResult> chart01()
        //{

        //    var count=_context.count_jensiat.AsNoTracking().Select(s=>s.count).ToArray();
        //    var name_jensiat=_context.count_jensiat.AsNoTracking().Select(s=>s.name_jensiat).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = name_jensiat, count = count, backg = backG });

        //}


        //------------------------------------------------------------


        //===============================================================chart02
       
        
        //===========================chart02
        //public async Task<IActionResult> chart02()
        //{

        //    var count = _context.count_jensiat.AsNoTracking().Select(s => s.count).ToArray();
        //    var name_jensiat = _context.count_jensiat.AsNoTracking().Select(s => s.name_jensiat).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = name_jensiat, count = count, backg = backG });

        //}


        //public async Task<IActionResult> chart03()
        //{

        //    var count = _context.count_jensiat.AsNoTracking().Select(s => s.count).ToArray();
        //    var name_jensiat = _context.count_jensiat.AsNoTracking().Select(s => s.name_jensiat).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = name_jensiat, count = count, backg = backG });

        //}
        //public async Task<IActionResult> chart04()
        //{

        //    var count = _context.count_jensiat.AsNoTracking().Select(s => s.count).ToArray();
        //    var name_jensiat = _context.count_jensiat.AsNoTracking().Select(s => s.name_jensiat).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = name_jensiat, count = count, backg = backG });

        //}
        //============================================================Jensiat
        //============================================================code_khata
        //public async Task<IActionResult> chart05()
        //{
        //    var count = _context.count_khata.AsNoTracking().Select(s => s.count).ToArray();
        //    var num_khata = _context.count_khata.AsNoTracking().Select(s => s.num_khata).ToArray();
            
        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = num_khata, count = count, backg = backG });

        //}

        //public async Task<IActionResult> chart06()
        //{
        //    var count = _context.count_khata.AsNoTracking().Select(s => s.count).ToArray();
        //    var num_khata = _context.count_khata.AsNoTracking().Select(s => s.num_khata).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = num_khata, count = count, backg = backG });

        //}

        //public async Task<IActionResult> chart07()
        //{
        //    var count = _context.count_khata.AsNoTracking().Select(s => s.count).ToArray();
        //    var num_khata = _context.count_khata.AsNoTracking().Select(s => s.num_khata).ToArray();

        //    string[] backG = new string[count.Count()];
        //    for (int i = 0; i < count.Count(); i++)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            backG[i] = "rgba(255, 99, 132, 0.5)";
        //        }
        //        else if (i % 4 == 1)
        //        {
        //            backG[i] = "rgba(75, 192, 192, 0.5)";
        //        }
        //        else if (i % 4 == 2)
        //        {
        //            backG[i] = "rgba(153, 102, 255, 0.5)";
        //        }
        //        else if (i % 4 == 3)
        //        {
        //            backG[i] = "rgba(255, 159, 64, 0.5)";
        //        }

        //        else
        //        {
        //            backG[i] = "rgba(54, 162, 235, 0.5)";
        //        }
        //    }

        //    return new JsonResult(new { myDate = num_khata, count = count, backg = backG });

        //}

        //public async Task<IActionResult> chart08()
        //{
        //    //var count = _context.count_khata.AsNoTracking().Select(s => s.count).ToArray();
        //    //var num_khata = _context.count_khata.AsNoTracking().Select(s => s.num_khata).ToArray();

        //    //string[] backG = new string[count.Count()];
        //    //for (int i = 0; i < count.Count(); i++)
        //    //{
        //    //    if (i % 4 == 0)
        //    //    {
        //    //        backG[i] = "rgba(255, 99, 132, 0.5)";
        //    //    }
        //    //    else if (i % 4 == 1)
        //    //    {
        //    //        backG[i] = "rgba(75, 192, 192, 0.5)";
        //    //    }
        //    //    else if (i % 4 == 2)
        //    //    {
        //    //        backG[i] = "rgba(153, 102, 255, 0.5)";
        //    //    }
        //    //    else if (i % 4 == 3)
        //    //    {
        //    //        backG[i] = "rgba(255, 159, 64, 0.5)";
        //    //    }

        //    //    else
        //    //    {
        //    //        backG[i] = "rgba(54, 162, 235, 0.5)";
        //    //    }
        //    //}

        //    //return new JsonResult(new { myDate = num_khata, count = count, backg = backG });
        //    return View();
        //}

        

        //============================================================code_khata


        public async Task<IActionResult> export_excel()
        {

            //try
            //{
            //    var q =await _context.v_never.ToListAsync();
            //    string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            //    string fileName = "export_nevers.xlsx";
            //    using (var workbook = new XLWorkbook())
            //    {
            //        IXLWorksheet worksheet = workbook.Worksheets.Add("گزارش کلی");
            //        worksheet.Cell(1, 1).Value = "نام دانشگاه";
            //        worksheet.Cell(1, 2).Value = "نام بیمارستان";
            //        worksheet.Cell(1, 3).Value = "نام و نام خانوادگی کاربر";
            //        worksheet.Cell(1, 4).Value = "شماره خطا";
            //        worksheet.Cell(1, 5).Value = "عنوان خطا";
            //        worksheet.Cell(1, 6).Value = "نام و نام خانوادگی بیمار";
            //        worksheet.Cell(1, 7).Value = "جنسیت";
            //        worksheet.Cell(1, 8).Value = "سن";
            //        worksheet.Cell(1, 9).Value = "تاریخ مراجعه";
            //        worksheet.Cell(1, 10).Value = "تاریخ وقوع";
            //        worksheet.Cell(1, 11).Value = "ساعت";
            //        worksheet.Cell(1, 12).Value = "توضیحات";

            //        for (int index = 1; index <= q.Count; index++)
            //        {
            //            worksheet.Cell(index + 1, 1).Value = q[index - 1].name_uni;
            //            worksheet.Cell(index + 1, 2).Value = q[index - 1].name_hos;
            //            worksheet.Cell(index + 1, 3).Value = q[index - 1].u_flname;
            //            worksheet.Cell(index + 1, 4).Value = q[index - 1].num_khata;
            //            worksheet.Cell(index + 1, 5).Value = q[index - 1].name_khata;
            //            worksheet.Cell(index + 1, 6).Value = q[index - 1].demo_bimar_name_never;
            //            worksheet.Cell(index + 1, 7).Value = q[index - 1].demo_jensiat_never;
            //            worksheet.Cell(index + 1, 8).Value = q[index - 1].demo_sen_never;
            //            worksheet.Cell(index + 1, 9).Value = q[index - 1].demo_date_morajee_never;
            //            worksheet.Cell(index + 1, 10).Value = q[index - 1].demo_date_voghu_never;
            //            worksheet.Cell(index + 1, 11).Value = q[index - 1].demo_saat_never;
            //            worksheet.Cell(index + 1, 12).Value = q[index - 1].sharh_never;
            //        }
            //        using (var stream = new MemoryStream())
            //        {
            //            workbook.SaveAs(stream);
            //            var content = stream.ToArray();
            //            return File(content, contentType, fileName);
            //            return RedirectToAction("index_user", "nevers");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    return RedirectToAction("index_user", "nevers");
            //}

            return RedirectToAction("index_user", "nevers");
        }

        public async Task<IActionResult> download_file1(int id)
        {
            var q = _context.never.Where(s => s.id_never == id).FirstOrDefault();

            byte[] byteArr = q.peyvast1_never;
            string mimeType = "application/jpg";
            return new FileContentResult(byteArr, mimeType)
            {
                FileDownloadName = $" فایل  {q.id_never + " " + q.demo_bimar_name_never + ""}." + q.peyvast1_kind_never
            };

        }
        public async Task<IActionResult> download_file2(int id)
        {
            var q = _context.never.Where(s => s.id_never == id).FirstOrDefault();

            byte[] byteArr = q.peyvast2_never;
            string mimeType = "application/jpg";
            return new FileContentResult(byteArr, mimeType)
            {
                FileDownloadName = $" فایل  {q.id_never + " " + q.demo_bimar_name_never + ""}." + q.peyvast2_kind_never
            };

        }

        // GET: nevers
        public async Task<IActionResult> Index()
        {
            //List<khata> khata_list = _context.khata.ToList();
            //ViewBag.khata = khata_list;
              return _context.never != null ? 
                          View(await _context.never.ToListAsync()) :
                          Problem("Entity set 'pishnahadContext.never'  is null.");
        }


        //===========================================index_user
        public async Task<IActionResult> index_user()
        {
            List<never> khata_list = _context.never.ToList();
            ViewBag.khata = khata_list;
            return _context.never != null ?
                        View(await _context.never.Where(s => s.id_user.ToString() == HttpContext.Session.GetString("id_user")).ToListAsync()) :
                        Problem("Entity set 'pishnahadContext.never'  is null.");
        }

        // GET: nevers/Details/5


        // GET: nevers/Create
        public IActionResult Create()
        {
            //List<khata> khata_list = _context.khata.ToList();
            //ViewBag.khata = khata_list;
            //ViewBag.num_khata = new SelectList(_context.khata,"num_khata","num_khata");
            //ViewBag.jensiat = new SelectList(_context.jensiat, "name_jensiat", "name_jensiat");
            return View();
        }

        // POST: nevers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Int64 num_khata,string jensiat,IFormFile peyvast1_never,IFormFile peyvast2_never, [Bind("id_never,num_khata,id_user,demo_jensiat_never,demo_bimar_name_never,demo_sen_never,demo_date_morajee_never,demo_date_voghu_never,demo_saat_never,sharh_never")] never never)
        {
            //try
            //{

            //    var never_asli = new never();
            //    if (peyvast1_never != null)
            //    {
            //        using (var memoryStream = new MemoryStream())
            //        {
            //            await peyvast1_never.CopyToAsync(memoryStream);
            //            // Upload the file if less than 2 MB
            //            if (memoryStream.Length < 10097152)
            //            {
            //                never_asli.peyvast1_never = memoryStream.ToArray();
            //                never_asli.peyvast1_kind_never = Path.GetExtension(peyvast1_never.FileName);
            //            }
            //            else
            //            {
            //                ModelState.AddModelError("peyvast1_never", "فایل پیوست اول بزرگتر از 2 مگ میباشد");
            //            }
            //        }
            //    }
            //    if (peyvast2_never != null)
            //    {
            //        using (var memoryStream = new MemoryStream())
            //        {
            //            await peyvast2_never.CopyToAsync(memoryStream);
            //            // Upload the file if less than 2 MB
            //            if (memoryStream.Length < 10097152)
            //            {
            //                never_asli.peyvast2_never = memoryStream.ToArray();
            //                never_asli.peyvast2_kind_never = Path.GetExtension(peyvast2_never.FileName);
            //            }
            //            else
            //            {
            //                ModelState.AddModelError("peyvast1_never", "فایل پیوست دوم بزرگتر از 2 مگ میباشد");
            //            }
            //        }
            //    }

            //    if(HttpContext.Session.GetString("id_user")==null)
            //    {
            //        return RedirectToAction("login","users");
            //    }

            //    never_asli.id_user = Int64.Parse(HttpContext.Session.GetString("id_user").ToString());
            //    never_asli.num_khata = num_khata;
            //    never_asli.sharh_never = never.sharh_never;
            //    never_asli.demo_sen_never = never.demo_sen_never;
            //    never_asli.demo_bimar_name_never = never.demo_bimar_name_never;
            //    never_asli.demo_date_morajee_never = never.demo_date_morajee_never;
            //    never_asli.demo_date_voghu_never = never.demo_date_voghu_never;
            //    never_asli.demo_jensiat_never = jensiat;
            //    never_asli.demo_saat_never = never.demo_saat_never;

            //    _context.Add(never_asli);
            //    await _context.SaveChangesAsync();
            //    _context.Entry(never_asli).State = EntityState.Detached;
            //    //================================================sms
            //    var q = _context.khata.AsNoTracking().Where(s => s.num_khata == never_asli.num_khata).FirstOrDefault();
            //    if (q.sms == true)
            //    {
            //        var e = _context.user.AsNoTracking().Where(s => s.id_user == never_asli.id_user).FirstOrDefault();
            //        Int64 id_bakhsh = e.id_bakhsh;
            //        var r=_context.bakhsh.AsNoTracking().Where(s=>s.id_bakhsh==id_bakhsh).FirstOrDefault(); 
            //        var client = new AmootSMS.AmootSMSWebService2SoapClient(
            //         AmootSMS.AmootSMSWebService2SoapClient.EndpointConfiguration.AmootSMSWebService2Soap12,
            //         "https://portal.amootsms.com/webservice2.asmx");
            //        string UserName = "09127784722";
            //        string Password = "@Alireza17439";
            //        DateTime SendDateTime = DateTime.Now;

            //        var w = _context.mobile.AsNoTracking().ToList();
            //        string[] Mobiles = new string[w.Count];
            //        for (int i = 0; i < w.Count; i++)
            //        {

            //            Mobiles[i]=w[i].num_mobile.ToString(); 

            //        }
            //        string SMSMessageText ="Never Event: "+ " خطا با شماره " + " " +" توسط بخش"+" "+ never_asli.num_khata + r.name_bakhsh+ " ثبت شد";
            //        string LineNumber = "Service";
            //        // AmootSMS.AmootSMSWebService2SoapClient client = new AmootSMS.AmootSMSWebService2SoapClient("AmootSMSWebService2Soap12");

            //        AmootSMS.SendResult result = client.SendSimpleAsync(UserName, Password, SendDateTime, SMSMessageText, LineNumber, Mobiles).Result;

            //        if (result.Status == AmootSMS.Status.Success)
            //        {
            //            sentsms sentsms=new sentsms();
            //            sentsms.status = "موفق";
            //            sentsms.id_never = never_asli.id_never;
            //            sentsms.id_user = never_asli.id_user;
            //            _context.Add(sentsms);
            //            await _context.SaveChangesAsync();
            //            _context.Entry(sentsms).State = EntityState.Detached;
            //        }
            //    }
            //    //================================================sms
            //    TempData["succ"] = "ثبت به درستی انجام شد";
            //    return RedirectToAction(nameof(index_user));
            //}
            //catch(Exception ex)
            //{
            //    TempData["er"] = ex;
            //    return RedirectToAction("Create","nevers");
            //};
            return RedirectToAction("Create", "nevers");

        }



        // GET: nevers/Edit/5
        //public async Task<IActionResult> Edit(long? id)
        //{
        //    if (id == null || _context.never == null)
        //    {
        //        return NotFound();
        //    }

        //    var never = await _context.never.FindAsync(id);
        //    if (never == null)
        //    {
        //        return NotFound();
        //    }
        //    List<khata> khata_list = _context.khata.ToList();
        //    ViewBag.khata = khata_list;
        //    ViewBag.num_khata = new SelectList(_context.khata, "num_khata", "num_khata");
        //    ViewBag.jensiat = new SelectList(_context.jensiat, "name_jensiat", "name_jensiat");
        //    ViewBag.id_never = id;
        //    return View(never);
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Int64 num_khata, string jensiat, IFormFile peyvast1_never, IFormFile peyvast2_never, [Bind("id_never,num_khata,id_user,demo_bimar_name_never,demo_jensiat_never,demo_sen_never,demo_date_morajee_never,demo_date_voghu_never,demo_saat_never,peyvast1_never,peyvast1_kind_never,peyvast2_never,peyvast2_kind_never,sharh_never")] never never)
        {
            if (id != never.id_never)
            {
                return NotFound();
            }
            try
            {
                var never_asli = new never();
                var p1 = _context.never.AsNoTracking().Where(s => s.id_never == id).FirstOrDefault();
                never_asli.peyvast1_never = p1.peyvast1_never;
                never_asli.peyvast1_kind_never = p1.peyvast1_kind_never;
                never_asli.peyvast2_never = p1.peyvast2_never;
                never_asli.peyvast2_kind_never= p1.peyvast2_kind_never;

                if (peyvast1_never != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await peyvast1_never.CopyToAsync(memoryStream);
                        // Upload the file if less than 2 MB
                        if (memoryStream.Length < 10097152)
                        {
                            never_asli.peyvast1_never = memoryStream.ToArray();
                            never_asli.peyvast1_kind_never = Path.GetExtension(peyvast1_never.FileName);
                        }
                        else
                        {
                            ModelState.AddModelError("peyvast1_never", "فایل پیوست اول بزرگتر از 2 مگ میباشد");
                        }
                    }
                }
                if (peyvast2_never != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await peyvast2_never.CopyToAsync(memoryStream);
                        // Upload the file if less than 2 MB
                        if (memoryStream.Length < 10097152)
                        {
                            never_asli.peyvast2_never = memoryStream.ToArray();
                            never_asli.peyvast2_kind_never = Path.GetExtension(peyvast2_never.FileName);
                        }
                        else
                        {
                            ModelState.AddModelError("peyvast1_never", "فایل پیوست دوم بزرگتر از 2 مگ میباشد");
                        }
                    }
                }
                never_asli.id_user = Int64.Parse(HttpContext.Session.GetString("id_user").ToString());
                never_asli.num_khata = num_khata;
                never_asli.sharh_never = never.sharh_never;
                never_asli.demo_sen_never = never.demo_sen_never;
                never_asli.demo_bimar_name_never = never.demo_bimar_name_never;
                never_asli.demo_date_morajee_never = never.demo_date_morajee_never;
                never_asli.demo_date_voghu_never = never.demo_date_voghu_never;
                never_asli.demo_jensiat_never = jensiat;
                never_asli.demo_saat_never = never.demo_saat_never;
                never_asli.id_never = id;

                _context.Update(never_asli);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!neverExists(never.id_never))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

        }

        // GET: nevers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.never == null)
            {
                return NotFound();
            }

            var never = await _context.never
                .FirstOrDefaultAsync(m => m.id_never == id);
            if (never == null)
            {
                return NotFound();
            }

            return View(never);
        }

        // POST: nevers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.never == null)
            {
                return Problem("Entity set 'pishnahadContext.never'  is null.");
            }
            var never = await _context.never.FindAsync(id);
            if (never != null)
            {
                _context.never.Remove(never);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool neverExists(long id)
        {
          return (_context.never?.Any(e => e.id_never == id)).GetValueOrDefault();
        }
    }
}
