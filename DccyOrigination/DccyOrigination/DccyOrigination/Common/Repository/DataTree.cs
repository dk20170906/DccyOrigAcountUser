using DccyOrigination.Common.IRepository;
using DccyOrigination.EF;
using DccyOrigination.Models;
using DccyOrigination.Models.SysManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace DccyOrigination.Common.Repository
{
    public class DataTree : IDataTree
    {
        #region  生成当前用户的菜单树


        /// <summary>
        ///        根节点菜单guid集合
        /// </summary>
        private List<string> RootMenuGuidList = new List<string>();
        /// <summary>
        /// 用户根节点集合
        /// </summary>
        private List<AdmJurisdiction> RootMenuList = new List<AdmJurisdiction>();

        /// <summary>
        /// 用户菜单集合
        /// </summary>
        private List<AdmJurisdiction> MenuList = new List<AdmJurisdiction>();

        public List<AdmDepartment> GetDepIdListByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> depIdList, out List<string> depGuidList)
        {
            try
            {
                List<AdmDepartment> userDeps = null;
                List<int> idlist = null;
                List<string> Guidlist = null;
                if (admUser != null)
                {
                    //得到用户部门对应表数据
                    List<AdmUserDepartment> admUserDepartments = dbContext.AdmUserDepartment.Where(u => u.AdmUserGuid == admUser.Guid).ToList();
                    //通过用户部门表得到当前用户的部门集合
                    userDeps = dbContext.AdmDepartment.Where(h => admUserDepartments.Select(c1 => c1.AdmDepGuid).Any(c2 => h.Guid.Equals(c2) && h.IsDelete == false)).ToList();
                    if (userDeps.Count > 0)
                    {
                        idlist = new List<int>();
                        Guidlist = new List<string>();
                        userDeps.ForEach(u =>
                        {
                            if (!Guidlist.Contains(u.Guid))
                            {
                                Guidlist.Add(u.Guid);
                            }
                            if (!idlist.Contains(u.Id))
                            {
                                idlist.Add(u.Id);
                            }
                        });
                    }
                }
                depIdList = idlist;
                depGuidList = Guidlist;
                return userDeps;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<AdmRole> GetRoleIdListByDepIdList(DccyDbContext dbContext, List<string> depGuidList, out List<int> roleIdList, out List<string> roleGuidList)
        {
            try
            {
                List<AdmRole> admRoles = null;
                List<int> roleidlist = null;
                List<string> roleGuidlist = null;
                if (depGuidList.Count > 0)
                {
                    //通过部门Id集合得到部门角色集合
                    IEnumerable<AdmDepRole> admDepRoles = dbContext.AdmDepRole.Where(u => depGuidList.Select(c => c).Any(h => h.Equals(u.AdmDepGuid))).ToList();
                    //通过部门角色集合得到角色集合
                    admRoles = dbContext.AdmRole.Where(u => admDepRoles.Select(c => c.AdmRoleGuid).Any(h => h.Equals(u.Guid)) && u.IsDelete == false).ToList();
                    if (admRoles.Count > 0)
                    {
                        roleidlist = new List<int>();
                        roleGuidlist = new List<string>();
                        admRoles.ForEach(u =>
                        {
                            if (true)
                            {
                                if (!roleidlist.Contains(u.Id))
                                {
                                    roleidlist.Add(u.Id);
                                }
                                if (!roleGuidlist.Contains(u.Guid))
                                {
                                    roleGuidlist.Add(u.Guid);
                                }
                            }
                        });
                    }
                }
                roleIdList = roleidlist;
                roleGuidList = roleGuidlist;
                return admRoles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AdmJurisdiction> GetJurListByRoleIdList(DccyDbContext dbContext, List<string> roleGuidList, out List<string> jurGuidList, out List<int> jurIdList)
        {
            try
            {
                List<AdmJurisdiction> admJurisdictions = null;
                List<string> jurGuids = null;
                List<int> jurids = null;
                if (roleGuidList.Count > 0)
                {
                    IEnumerable<AdmRoleJur> admRoleJurs = dbContext.AdmRoleJur.Where(u => roleGuidList.Select(c => c).Any(h => u.AdmRoleGuid.Equals(h))).ToList();
                    admJurisdictions = dbContext.AdmJurisdiction.Where(u => admRoleJurs.Select(c => c.AdmJurGuid).Any(h => h.Equals(u.Guid))).ToList();
                    if (admJurisdictions.Count > 0)
                    {
                        jurGuids = new List<string>();
                        jurids = new List<int>();
                        admJurisdictions.ForEach(u =>
                        {
                            if (!jurGuids.Contains(u.Guid))
                            {
                                jurGuids.Add(u.Guid);
                                jurids.Add(u.Id);
                            }
                        });
                    }
                }
                jurGuidList = jurGuids;
                jurIdList = jurids;
                return admJurisdictions;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AdmJurisdiction> CreateNodesTreeList(DccyDbContext dbContext, List<AdmJurisdiction> admJurList)
        {
            try
            {
                if (admJurList.Count > 0)
                {
                    RootMenuGuidList.Clear();
                    RootMenuList.Clear();
                    admJurList.ForEach(u =>
                    {
                        GetRootNodes(admJurList, u);
                    });
                    if (RootMenuList.Count > 0)
                    {
                        MenuList.Clear();
                        RootMenuList.ForEach(u =>
                        {
                            MenuList.Add(CreateNodeTree(MenuList, u));
                        });
                    }
                }
                return MenuList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetRootNodes(List<AdmJurisdiction> admJurisdictionList, AdmJurisdiction admJurisdiction)
        {
            try
            {
                if (admJurisdictionList.Count > 0)
                {
                    if (admJurisdictionList.Count > 0)
                    {
                        var menu = admJurisdictionList.FirstOrDefault(u => u.Guid == admJurisdiction.PGuid);
                        if (menu != null && menu.Id > 0)
                        {
                            GetRootNodes(admJurisdictionList, menu);
                        }
                        else
                        {
                            if (!RootMenuGuidList.Contains(admJurisdiction.Guid))
                            {
                                RootMenuGuidList.Add(admJurisdiction.Guid);
                                RootMenuList.Add(admJurisdiction);
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


        public AdmJurisdiction CreateNodeTree(List<AdmJurisdiction> admJurisdictionList, AdmJurisdiction RootAdmJurisdiction)
        {
            if (admJurisdictionList.Count > 0)
            {
                List<AdmJurisdiction> listm = admJurisdictionList.Where(u => u.PGuid == RootAdmJurisdiction.Guid).ToList();
                if (listm != null && listm.Count > 0)
                {
                    RootAdmJurisdiction.Children = listm;
                    listm.ForEach(m =>
                    {
                        CreateNodeTree(admJurisdictionList, m);
                    });
                }
            }
            return RootAdmJurisdiction;

        }

        #region 角色树

        /// <summary>
        ///        根节点菜单guid集合
        /// </summary>
        private List<string> RootMenuGuidListRole = new List<string>();
        /// <summary>
        /// 用户根节点集合
        /// </summary>
        private List<AdmRole> RootMenuListRole = new List<AdmRole>();

        /// <summary>
        /// 用户菜单集合
        /// </summary>
        private List<AdmRole> MenuListRole = new List<AdmRole>();
        public List<AdmRole> CreateNodesTreeListRole(DccyDbContext dbContext, List<AdmRole> admJurList)
        {
            try
            {
                if (admJurList.Count > 0)
                {
                    RootMenuGuidListRole.Clear();
                    RootMenuListRole.Clear();
                    admJurList.ForEach(u =>
                    {
                        GetRootNodesRole(admJurList, u);
                    });
                    if (RootMenuListRole.Count > 0)
                    {
                        MenuListRole.Clear();
                        RootMenuListRole.ForEach(u =>
                        {
                            MenuListRole.Add(CreateNodeTreeRole(MenuListRole, u));
                        });
                    }
                }
                return MenuListRole;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetRootNodesRole(List<AdmRole> admJurisdictionList, AdmRole admJurisdiction)
        {
            try
            {
                if (admJurisdictionList.Count > 0)
                {
                    if (admJurisdictionList.Count > 0)
                    {
                        var menu = admJurisdictionList.FirstOrDefault(u => u.Guid == admJurisdiction.PGuid);
                        if (menu != null && menu.Id > 0)
                        {
                            GetRootNodesRole(admJurisdictionList, menu);
                        }
                        else
                        {
                            if (!RootMenuGuidListRole.Contains(admJurisdiction.Guid))
                            {
                                RootMenuGuidListRole.Add(admJurisdiction.Guid);
                                RootMenuListRole.Add(admJurisdiction);
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


        public AdmRole CreateNodeTreeRole(List<AdmRole> admJurisdictionList, AdmRole RootAdmJurisdiction)
        {
            if (admJurisdictionList.Count > 0)
            {
                List<AdmRole> listm = admJurisdictionList.Where(u => u.PGuid == RootAdmJurisdiction.Guid).ToList();
                if (listm != null && listm.Count > 0)
                {
                    RootAdmJurisdiction.Children = listm;
                    listm.ForEach(m =>
                    {
                        CreateNodeTreeRole(admJurisdictionList, m);
                    });
                }
            }
            return RootAdmJurisdiction;

        }

        #endregion
        public List<AdmRole> GetAcountUserRolesListByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> depIdList, out List<string> depGuidList, out List<int> roleIdList, out List<string> roleGuidList)
        {
            try
            {
                GetDepIdListByAcountUser(dbContext, admUser, out depIdList, out depGuidList);
                return GetRoleIdListByDepIdList(dbContext, depGuidList, out roleIdList, out roleGuidList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 通过当前用户得到用记角色
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="admUser"></param>
        /// <param name="roleIdList"></param>
        /// <param name="roleGuidList"></param>
        /// <returns></returns>
        public List<AdmRole>GetAcountUserRoleListTREEByAcountUser(DccyDbContext dbContext,AdmUser admUser,out List<int> roleIdList,out List<string> roleGuidList)
        {
            List<int> depidList = new List<int>();
            List<string> depguidList = new List<string>();
            List<int> roleidList = new List<int>();
            List<string> roleguidList = new List<string>();
            List<int> juridlist = new List<int>();
            List<string> jurguidlist = new List<string>();
            List<AdmRole> admRoles = new List<AdmRole>();
            try
            {
               var roles= GetAcountUserRolesListByAcountUser(dbContext, admUser, out depidList, out depguidList, out roleidList, out roleguidList);
                roleGuidList = roleguidList;
                roleIdList = roleidList;
                return CreateNodesTreeListRole(dbContext, roles);
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// 当前用户的菜单权限树
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="admUser"></param>
        /// <param name="jurIdList"></param>
        /// <param name="jurGuidList"></param>
        /// <returns></returns>
        public List<AdmJurisdiction> GetAcountUserJurListTREEByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> jurIdList, out List<string> jurGuidList)
        {
            List<int> depIdList = new List<int>();
            List<string> depGuidList = new List<string>();
            List<int> roleIdList = new List<int>();
            List<string> roleGuidList = new List<string>();
            List<int> juridlist = new List<int>();
            List<string> jurguidlist = new List<string>();
            try
            {
                List<AdmJurisdiction> admuserjurtree = new List<AdmJurisdiction>();
                GetAcountUserRolesListByAcountUser(dbContext, admUser, out depIdList, out depGuidList, out roleIdList, out roleGuidList);
                if (roleGuidList.Count > 0)
                {
                    List<AdmJurisdiction> admuserjur = GetJurListByRoleIdList(dbContext, roleGuidList, out jurguidlist, out juridlist);
                    admuserjurtree = CreateNodesTreeList(dbContext, admuserjur);
                }
                jurIdList = juridlist;
                jurGuidList = jurguidlist;
                return admuserjurtree;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
