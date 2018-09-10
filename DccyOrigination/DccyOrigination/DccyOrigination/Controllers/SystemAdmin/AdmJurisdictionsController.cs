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
using DccyOrigination.Models;
using DccyOrigination.Models.Result;

namespace DccyOrigination.Controllers.SystemAdmin
{
    public class AdmJurisdictionsController : Controller
    {
        private readonly DccyDbContext _context;
        private readonly IToolUnit _toolUnit;
        private readonly IDataTree _dataTree;

        private static List<string> rolesGuidList = new List<string>();
        private static List<int> roleIDList = new List<int>();
        private static List<AdmRole> admRoles = new List<AdmRole>();
        public AdmJurisdictionsController(DccyDbContext context,IDataTree dataTree,IToolUnit toolUnit)
        {
            _context = context;
            _toolUnit = toolUnit;
            _dataTree = dataTree;
        }

        // GET: AdmJurisdictions
        public IActionResult Index()
        {
            string userSession = HttpContext.Session.GetString("AdmUserSession");
            if (!string.IsNullOrEmpty(userSession) && JsonConvert.DeserializeObject<AdmUser>(userSession).Id > 0)
            {
                Task<List<AdmRole>> task = Task.Run(() => _dataTree.GetAcountUserRoleListTREEByAcountUser(_context, JsonConvert.DeserializeObject<AdmUser>(userSession), out roleIDList, out rolesGuidList));
                task.Wait();
                if (task.Result.Count > 0)
                {
                    admRoles = task.Result;
                    return View(task.Result);
                }
                return RedirectToAction("Index", "Error", new ResultModel() { StateCode = (int)ResultEnum.NOROLE, Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.NOROLE) });
            }
            return RedirectToAction("Index", "Login");
            // return View(await _context.AdmJurisdiction.ToListAsync());
        }

        // GET: AdmJurisdictions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admJurisdiction = await _context.AdmJurisdiction
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admJurisdiction == null)
            {
                return NotFound();
            }

            return View(admJurisdiction);
        }

        // GET: AdmJurisdictions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmJurisdictions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JurName,Url,MenuStyle,RoleId,DepId,IsAuthorization,IsOpen,IsChildren,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmJurisdiction admJurisdiction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admJurisdiction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admJurisdiction);
        }

        // GET: AdmJurisdictions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admJurisdiction = await _context.AdmJurisdiction.FindAsync(id);
            if (admJurisdiction == null)
            {
                return NotFound();
            }
            return View(admJurisdiction);
        }

        // POST: AdmJurisdictions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JurName,Url,MenuStyle,RoleId,DepId,IsAuthorization,IsOpen,IsChildren,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmJurisdiction admJurisdiction)
        {
            if (id != admJurisdiction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admJurisdiction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmJurisdictionExists(admJurisdiction.Id))
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
            return View(admJurisdiction);
        }

        // GET: AdmJurisdictions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admJurisdiction = await _context.AdmJurisdiction
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admJurisdiction == null)
            {
                return NotFound();
            }

            return View(admJurisdiction);
        }

        // POST: AdmJurisdictions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admJurisdiction = await _context.AdmJurisdiction.FindAsync(id);
            _context.AdmJurisdiction.Remove(admJurisdiction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmJurisdictionExists(int id)
        {
            return _context.AdmJurisdiction.Any(e => e.Id == id);
        }
    }
}
