using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DccyOrigination.Common;
using DccyOrigination.Common.IRepository;
using DccyOrigination.EF;
using DccyOrigination.Models;
using DccyOrigination.Models.Result;
using DccyOrigination.Models.SysManagement;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace DccyOrigination.Controllers
{
    public class LoginController : Controller
    {
        private readonly DccyDbContext _dbContext;
        private readonly IToolUnit _toolUnit;
        private readonly IEncryptionAndDecryption _encryptionAndDecryption;
        private readonly AppSetting _appSetting;
        private static string SecurityCode_Odd { get; set; }
       public LoginController(DccyDbContext dbContext,IToolUnit toolUnit ,IEncryptionAndDecryption encryptionAndDecryption,IOptions<AppSetting> options)
        {
            _dbContext=dbContext;
            _toolUnit = toolUnit;
            _encryptionAndDecryption = encryptionAndDecryption;
            _appSetting = options.Value;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SecurityCode()
        {
            string code = _toolUnit.CreateRandomCode(4); //验证码的字符为4个
            SecurityCode_Odd = code.ToString();
            //      TempData["SecurityCode"] = code; //验证码存放在TempData中
            //TempData.Keep("SecurityCode");
            //string oldcode = TempData["SecurityCode"] as string;

            return File(_toolUnit.CreateValidateGraphic(code), "image/Jpeg");
        }
        [HttpPost]
        public ActionResult Login(string acountName, string Tel, string password, string code)
        {
            AdmUser admUser = null;
            #region 用户名验证
            if (acountName != null && acountName.Length > 0 && acountName != "")
            {
                var user =_dbContext.AdmUser.FirstOrDefault(u => u.UserAccounts == acountName || u.Email == acountName || u.Tel == acountName || u.UserName == acountName || u.Tel == Tel || u.UserAccounts == Tel || u.UserName == Tel || u.Email == Tel);
                if (user != null && user.Id > 0)
                {
                    admUser = user;
                }
                else
                {
                    ViewBag.LoginMsg = "请输入合法的登录帐号或帐号不存在！！！";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.LoginMsg = "请输入合法的登录帐号！！！";
                return View("Index");
            }
            #endregion
            #region 密码验证
            if (password != null && password.Length > 0 && password != "")
            {
                var userPwdEncode = _encryptionAndDecryption.AESEncrypt(password, _appSetting.EncryptKey);
                if (admUser.Password.Equals(userPwdEncode))
                {
                }
                else
                {
                    ViewBag.LoginMsg = "密码错误！！！";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.LoginMsg = "请输入合法的登录密码！！！";
                return View("Index");
            }
            #endregion
            #region 验证码
            if (code != null && code.Length > 0 && code != "")
            {
                if (code.Equals(SecurityCode_Odd))
                {
                    SecurityCode_Odd = null;
                    HttpContext.Session.SetString("AdmUserSession", JsonConvert.SerializeObject(admUser));
                    Logger.Info(JsonConvert.SerializeObject(admUser.UserAccounts+","+admUser.UserName+","+admUser.Email+","+admUser.Tel));
                    return RedirectToRoute(new { Controller = "SysAdm", Action = "Index" });
                }
                else
                {
                    ViewBag.LoginMsg = "验证码输入错误！！！";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.LoginMsg = "请输入合法的验证码！！！";
                return View("Index");
            }
            #endregion

        }
        /// <summary>
        /// 协议书
        /// </summary>
        /// <returns></returns>
        public ActionResult Agreement()
        {
            return View();
        }
        /// <summary>
        /// 找回密码
        /// </summary>
        /// <returns></returns>
        public IActionResult FindPassword()
        {
            return View();
        }
        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, AdmUser admUser)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public static int mm = 0;
        #region 初始化数据
        public string InitSystem()
        {
            List<AdmJurisdiction> admjurs = new List<AdmJurisdiction>();
            for (int i = 0; i < 5; i++)
            {
                admjurs.Add(new AdmJurisdiction()
                {
                    CreateTime = DateTime.Now,
                    Guid = Guid.NewGuid().ToString().ToUpper(),
                    Description = i.ToString(),
                    IsAuthorization = true,
                    IsDelete = false,
                    IsOpen = true,
                    JurName = "权限" + i.ToString(),


                });
            }
            _dbContext.AdmJurisdiction.AddRange(admjurs);

            List<AdmDepartment> adms = new List<AdmDepartment>();
            for (int i = 0; i < 5; i++)
            {
                adms.Add(new AdmDepartment()
                {
                    CreateTime = DateTime.Now,
                    DepName = "部门" + i.ToString(),
                    Description = i.ToString(),
                    Guid = Guid.NewGuid().ToString().ToUpper(),
                    IsDelete = false,


                });
            }
            _dbContext.AdmDepartment.AddRange(adms);

            List<AdmRole> admrole = new List<AdmRole>();
            for (int i = 0; i < 5; i++)
            {
                admrole.Add(new AdmRole()
                {
                    CreateTime = DateTime.Now,
                    Description = i.ToString(),
                    Guid = Guid.NewGuid().ToString().ToUpper(),
                    IsDelete = false,
                    RoleName = "角色" + i.ToString(),

                });
            }
            _dbContext.AdmRole.AddRange(admrole);


            var admUser = new AdmUser()
            {
                UserName = "张三",
                Address = "杭州",
                DetailedAddress = "滨江聚光中心",
                CreateTime = DateTime.Now,
                Description = "测试",
                Email = "123456@qq.com",
                Guid = Guid.NewGuid().ToString().ToUpper(),
                IsDelete = false,
                LastLoginTime = DateTime.Now,
                Password = _encryptionAndDecryption.AESEncrypt("123456", _appSetting.EncryptKey),
                Sex = 0,
                Tel = "125489654",
                UserAccounts = "123456",
            };
            _dbContext.AdmUser.Add(admUser);



            List<AdmUserDepartment> admuserdep = new List<AdmUserDepartment>();
            for (int i = 0; i < 3; i++)
            {
                admuserdep.Add(new AdmUserDepartment()
                {
                    AdmDepGuid = Guid.NewGuid().ToString().ToUpper(),
                    AdmUserGuid = Guid.NewGuid().ToString().ToUpper(),
                    CreateTime = DateTime.Now,
                    Description = i.ToString(),
                    IsDelete = false,
                    JurType = i,

                });
            }
            _dbContext.AdmUserDepartment.AddRange(admuserdep);


            List<AdmDepRole> admdeprole = new List<AdmDepRole>();
            for (int i = 0; i < 3; i++)
            {
                admdeprole.Add(new AdmDepRole()
                {
                    AdmDepGuid = Guid.NewGuid().ToString().ToUpper(),
                    AdmRoleGuid = Guid.NewGuid().ToString().ToUpper(),
                    CreateTime = DateTime.Now,
                    Description = i.ToString(),
                    IsDelete = false,
                    JurType = i,

                });
            }
            _dbContext.AdmDepRole.AddRange(admdeprole);


            List<AdmRoleJur> admrolejur = new List<AdmRoleJur>();
            for (int i = 0; i < 3; i++)
            {
                admrolejur.Add(new AdmRoleJur()
                {
                    AdmJurGuid = Guid.NewGuid().ToString().ToUpper(),
                    AdmRoleGuid = Guid.NewGuid().ToString().ToUpper(),
                    CreateTime = DateTime.Now,
                    Description = i.ToString(),
                    IsDelete = false,
                    JurType = i,

                });
            }
            _dbContext.AdmRoleJur.AddRange(admrolejur);
            if (mm==0)
            {
                mm++;
                int m = _dbContext.SaveChanges();
                return "初始化成功：" + m.ToString();
            }
            else
            {
                return "已初始化";
            }
         
        } 
        #endregion
    }
}
