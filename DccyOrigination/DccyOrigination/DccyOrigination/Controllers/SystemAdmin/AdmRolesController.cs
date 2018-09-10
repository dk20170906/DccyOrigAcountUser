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
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using DccyOrigination.Models.Result;
using DccyOrigination.Models;

namespace DccyOrigination.Controllers.SystemAdmin
{
    public class AdmRolesController : Controller
    {
        private readonly DccyDbContext _context;
        private readonly IToolUnit _toolUnit;
        private readonly IDataTree _dataTree;

        private static List<AdmRole> admRoles = new List<AdmRole>();
        private static List<int> DepIDList = new List<int>();
        private static List<int> roleIDList = new List<int>();
        private static List<string> DepGuidList = new List<string>();
        private static List<string> admRolesGuidList = new List<string>();
        public AdmRolesController(DccyDbContext context, IToolUnit toolUnit, IDataTree dataTree)
        {
            _context = context;
            _toolUnit = toolUnit;
            _dataTree = dataTree;
        }

        // GET: AdmRoles
        public IActionResult Index()
        {
            string userSession = HttpContext.Session.GetString("AdmUserSession");
            if (!string.IsNullOrEmpty(userSession) && JsonConvert.DeserializeObject<AdmUser>(userSession).Id > 0)
            {
                Task<List<AdmRole>> task = Task.Run(() => _dataTree.GetAcountUserRolesListByAcountUser(_context, JsonConvert.DeserializeObject<AdmUser>(userSession), out DepIDList, out DepGuidList, out roleIDList, out admRolesGuidList));
                task.Wait();
                if (task.Result.Count > 0)
                {
                    admRoles = task.Result;
                    return View(task.Result);
                }
                return RedirectToAction("Index", "Error", new ResultModel() { StateCode = (int)ResultEnum.NOROLE, Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.NOROLE) });
            }
            return RedirectToAction("Index", "Login");
            // return View("此用户暂无权限相关配置，请联系管理员！");
        }

        // GET: AdmRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admRole = await _context.AdmRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admRole == null)
            {
                return NotFound();
            }

            return View(admRole);
        }

        // GET: AdmRoles/Create
        public IActionResult Create()
        {
            return View();
        }
        public JsonResult GetAcountUserRoles()
        {
            if (admRoles.Count > 0)
            {
                return Json(new
                {
                    StateCode = (int)ResultEnum.SUCCESS,
                    Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.SUCCESS),
                    Data = admRoles
                });
            }
            return Json(new
            {
                StateCode = (int)ResultEnum.ERROR,
                Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.ERROR)
            });
        }

        // POST: AdmRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleName,MenuGuid,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmRole admRole)
        {
            if (ModelState.IsValid)
            {
                admRole.CreateTime = DateTime.Now;
                admRole.Guid = Guid.NewGuid().ToString().ToUpper();
                _context.Add(admRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admRole);
        }

        // GET: AdmRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admRole = await _context.AdmRole.FindAsync(id);
            if (admRole == null)
            {
                return NotFound();
            }
            return View(admRole);
        }

        // POST: AdmRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleName,MenuGuid,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmRole admRole)
        {
            if (id != admRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmRoleExists(admRole.Id))
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
            return View(admRole);
        }

        // GET: AdmRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admRole = await _context.AdmRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admRole == null)
            {
                return NotFound();
            }

            return View(admRole);
        }

        // POST: AdmRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admRole = await _context.AdmRole.FindAsync(id);
            _context.AdmRole.Remove(admRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmRoleExists(int id)
        {
            return _context.AdmRole.Any(e => e.Id == id);
        }


    }
}
