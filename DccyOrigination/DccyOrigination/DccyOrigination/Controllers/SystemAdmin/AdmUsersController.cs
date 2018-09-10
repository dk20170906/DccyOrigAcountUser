using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DccyOrigination.EF;
using DccyOrigination.Models.SysManagement;
using DccyOrigination.Common.IRepository;
using DccyOrigination.Models;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using DccyOrigination.Models.Result;
using DccyOrigination.Common.Repository;

namespace DccyOrigination.Controllers.SystemAdmin
{
    public class AdmUsersController : Controller
    {
        private readonly DccyDbContext _context;
        private readonly IEncryptionAndDecryption _encryptionAndDecryption;
        private readonly AppSetting _appSetting;
        private readonly IToolUnit _toolUnit;
        //当前登陆用户
        private static AdmUser admUserModel;
        public AdmUsersController(DccyDbContext context, IEncryptionAndDecryption encryptionAndDecryption, IOptions<AppSetting> appSetting, IToolUnit toolUnit)
        {
            _context = context;
            _encryptionAndDecryption = encryptionAndDecryption;
            _appSetting = appSetting.Value;
            _toolUnit = toolUnit;
        }

        // GET: AdmUsers
        public IActionResult Index()
        {
            string userSession = HttpContext.Session.GetString("AdmUserSession");
            if (!string.IsNullOrEmpty(userSession) && JsonConvert.DeserializeObject<AdmUser>(userSession).Id > 0)
            {
                admUserModel = JsonConvert.DeserializeObject<AdmUser>(userSession);
                Task<List<AdmUser>> task = Task.Run(() => _context.AdmUser.Where(u => u.PGuid == admUserModel.Guid && admUserModel.IsDelete == false).ToList());
                task.Wait();
                return View(task.Result);
            }
            return RedirectToAction("Index", "Login");
            // return View(await _context.AdmUser.ToListAsync());
        }

        // GET: AdmUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admUser = await _context.AdmUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admUser == null)
            {
                return NotFound();
            }

            return View(admUser);
        }

        // GET: AdmUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Guid,UserAccounts,UserName,Password,LastLoginTime,RoleId,DepId,Sex,Email,Tel,Address,DetailedAddress,NumOfLogins,ThumbnailImage,Id,CreateTime,IsDelete,Description,TimestampV")] AdmUser admUser)
        {
            if (ModelState.IsValid)
            {
                AdmUser user = _context.AdmUser.Where(u => u.UserAccounts == admUser.UserAccounts || u.UserName == admUser.UserName || u.Tel == admUser.Tel).ToList().FirstOrDefault();
                if (user != null && user.Id > 0)
                {
                    if (user.IsDelete == true)
                    {
                        ViewBag.Message = "此用户已存在，但暂时为停用状态";
                        return View(user);
                    }
                    else
                    {
                        ViewBag.Message = "此用户已存在";
                        return View(user);
                    }

                }
                admUser.CreateTime = DateTime.Now;
                admUser.Guid = Guid.NewGuid().ToString().ToUpper();
                admUser.PGuid = admUserModel.Guid;
                admUser.Password = _encryptionAndDecryption.AESEncrypt(admUser.Password, _appSetting.EncryptKey);
                _context.Add(admUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admUser);
        }

        // GET: AdmUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admUser = await _context.AdmUser.FindAsync(id);
            if (admUser == null)
            {
                return NotFound();
            }
            return View(admUser);
        }

        // POST: AdmUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Guid,UserAccounts,UserName,Password,LastLoginTime,RoleId,DepId,Sex,Email,Tel,Address,DetailedAddress,NumOfLogins,ThumbnailImage,Id,CreateTime,IsDelete,Description,TimestampV")] AdmUser admUser)
        {
            if (id != admUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmUserExists(admUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(admUser);
        }

        // GET: AdmUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admUser = await _context.AdmUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admUser == null)
            {
                return NotFound();
            }

            return View(admUser);
        }

        // POST: AdmUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admUser = await _context.AdmUser.FindAsync(id);
            _context.AdmUser.Remove(admUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmUserExists(int id)
        {
            return _context.AdmUser.Any(e => e.Id == id);
        }
    }
}
