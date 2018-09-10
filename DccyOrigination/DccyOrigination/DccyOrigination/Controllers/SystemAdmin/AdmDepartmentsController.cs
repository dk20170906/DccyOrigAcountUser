using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DccyOrigination.EF;
using DccyOrigination.Models.SysManagement;
using Microsoft.AspNetCore.Http;
using DccyOrigination.Common.IRepository;
using Newtonsoft.Json;
using DccyOrigination.Models.Result;
using DccyOrigination.Models;

namespace DccyOrigination.Controllers.SystemAdmin
{
    public class AdmDepartmentsController : Controller
    {
        private readonly DccyDbContext _context;

        private readonly IDataTree _dataTree;

        private readonly IToolUnit _toolUnit;

        private static List<string> depGuidList = new List<string>();
        private static List<int> depIdList = new List<int>();
        private static List<AdmDepartment> deps = new List<AdmDepartment>();

        public AdmDepartmentsController(DccyDbContext context, IDataTree dataTree, IToolUnit toolUnit)
        {
            _context = context;
            _dataTree = dataTree;
            _toolUnit = toolUnit;
        }


        // GET: AdmDepartments
        public IActionResult Index()
        {
            string userSession = HttpContext.Session.GetString("AdmUserSession");
            if (!string.IsNullOrEmpty(userSession) && JsonConvert.DeserializeObject<AdmUser>(userSession).Id > 0)
            {
                Task<List<AdmDepartment>> task = Task.Run(() => _dataTree.GetDepIdListByAcountUser(_context, JsonConvert.DeserializeObject<AdmUser>(userSession), out depIdList, out depGuidList));
                task.Wait();
                if (task.Result.Count > 0)
                {
                    deps = task.Result;
                    GetAcountUserAdmDepsTree();
                    if (DepsList.Count>0)
                    {
                        return View(DepsList);
                    }
                }
                return RedirectToAction("Index", "Error", new ResultModel() { StateCode = (int)ResultEnum.NODEP, Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.NODEP) });
            }
            return RedirectToAction("Index", "Login");
        }

        // GET: AdmDepartments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admDepartment == null)
            {
                return NotFound();
            }

            return View(admDepartment);
        }

        // GET: AdmDepartments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmDepartments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepName,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmDepartment admDepartment)
        {
            if (ModelState.IsValid)
            {
                admDepartment.CreateTime = DateTime.Now;
                admDepartment.Guid = Guid.NewGuid().ToString().ToUpper();
                _context.Add(admDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admDepartment);
        }


        public JsonResult GetAdmUserPDeps()
        {
            if (deps.Count > 0)
            {
                return Json(new
                {
                    StateCode = (int)ResultEnum.SUCCESS,
                    Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.SUCCESS),
                    Data = deps,
                    DepGuidList = depGuidList
                });
            }
            return Json(new
            {
                StateCode = (int)ResultEnum.ERROR,
                Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.ERROR),
            });
        }

        #region 部门树                                                        

        private List<string> RootDepGuidList = new List<string>();
        private List<AdmDepartment> RootDeps = new List<AdmDepartment>();
        private List<AdmDepartment> DepsList = new List<AdmDepartment>();

        /// <summary>
        /// 获取当前用户权限内的部门集合
        /// </summary>
        /// <returns></returns>
        public List<AdmDepartment> GetPAdmDeps()
        {
            return deps;
        }

        public JsonResult GetAcountUserAdmDepsTree()
        {
            try
            {
                List<string> depguid = new List<string>();
                if (deps != null && deps.Count > 0)
                {
                    RootDepGuidList.Clear();
                    RootDeps.Clear();
                    deps.ForEach(u =>
                    {
                        GetRootNodes(deps, u);
                    });
                    if (RootDeps.Count > 0)
                    {
                        DepsList.Clear();
                        RootDeps.ForEach(u =>
                        {
                            DepsList.Add(CreateNodeTree(deps, u));
                        });
                    }
                }
                if (DepsList.Count > 0)
                {
                    return Json(new
                    {
                        StateCode = (int)ResultEnum.SUCCESS,
                        Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.SUCCESS),
                        Data = DepsList
                    });
                }
                return Json(new
                {
                    StateCode = (int)ResultEnum.ERROR,
                    Message = _toolUnit.GetEnumDescriptionByReflex(ResultEnum.ERROR),
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetRootNodes(List<AdmDepartment> admDepartments, AdmDepartment admDepartment)
        {
            try
            {
                if (admDepartments.Count > 0)
                {
                    if (admDepartments.Count > 0)
                    {
                        var menu = admDepartments.FirstOrDefault(u => u.Guid == admDepartment.PGuid);
                        if (menu != null && menu.Id > 0)
                        {
                            GetRootNodes(admDepartments, menu);
                        }
                        else
                        {
                            if (!RootDepGuidList.Contains(admDepartment.Guid))
                            {
                                RootDepGuidList.Add(admDepartment.Guid);
                                RootDeps.Add(admDepartment);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public AdmDepartment CreateNodeTree(List<AdmDepartment> admDepartments, AdmDepartment admDepartment)
        {
            if (admDepartments.Count > 0)
            {
                List<AdmDepartment> listm = admDepartments.Where(u => u.PGuid == admDepartment.Guid).ToList();
                if (listm != null && listm.Count > 0)
                {
                    admDepartment.Children = listm;
                    listm.ForEach(m =>
                    {
                        CreateNodeTree(admDepartments, m);
                    });
                }
            }
            return admDepartment;

        }

        #endregion

        // GET: AdmDepartments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment.FindAsync(id);
            if (admDepartment == null)
            {
                return NotFound();
            }
            return View(admDepartment);
        }

        // POST: AdmDepartments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepName,Pid,Guid,PGuid,Id,CreateTime,IsDelete,Description,TimestampV")] AdmDepartment admDepartment)
        {
            if (id != admDepartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmDepartmentExists(admDepartment.Id))
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
            return View(admDepartment);
        }

        // GET: AdmDepartments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admDepartment = await _context.AdmDepartment
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admDepartment == null)
            {
                return NotFound();
            }

            return View(admDepartment);
        }

        // POST: AdmDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admDepartment = await _context.AdmDepartment.FindAsync(id);
            _context.AdmDepartment.Remove(admDepartment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmDepartmentExists(int id)
        {
            return _context.AdmDepartment.Any(e => e.Id == id);
        }
    }
}
