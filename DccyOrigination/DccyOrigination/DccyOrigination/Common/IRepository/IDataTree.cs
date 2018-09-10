using DccyOrigination.EF;
using DccyOrigination.Models;
using DccyOrigination.Models.SysManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Common.IRepository
{
    public interface IDataTree
    {

        #region 生成当前用户的菜单树


        /// <summary>
        /// 通过当前用户得到部门ID
        /// </summary>
        /// <param name="dbContext">数据上下文</param>
        /// <param name="admUser">当前用户</param>
        /// <param name="depIdList">带出的部门ID集合</param>
        ///  /// <param name="depGuidList">带出的部门Guid集合</param>
        /// <returns>当前用户部门集合</returns>
        List<AdmDepartment> GetDepIdListByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> depIdList ,out List<string> depGuidList);
        /// <summary>
        /// 通过当前用户部门得到角色集合
        /// </summary>
        /// <param name="dbContext">数据上下文</param>
        /// <param name="depGuidList">部门id集合</param>
        /// <param name="roleIdList">返回带出的角色id信合</param>
        ///      /// <param name="roleGuidList">返回带出的角色Guid集合</param>
        /// <returns>当前用户角色集合</returns>
        List<AdmRole> GetRoleIdListByDepIdList(DccyDbContext dbContext, List<string> depGuidList, out List<int> roleIdList,out List<string>roleGuidList);
        /// <summary>
        /// 通过角色id集合得到用户权限菜单集合
        /// </summary>
        /// <param name="dbContext">数据上下文</param>
        /// <param name="roleGuidList">角色id集合</param>
        /// <param name="jurGuidList">权限菜单guid集合</param>
        /// <returns>权限集合</returns>
        List<AdmJurisdiction> GetJurListByRoleIdList(DccyDbContext dbContext, List<string> roleGuidList,out List<string> jurGuidList,out List<int> jurIdList);
        /// <summary>
        /// 创建多根节点的树集合
        /// </summary>
        /// <param name="dbContext">数据上下文</param>
        /// <param name="admJurList">根节点集合</param>
        /// <param name="rootJurGuidList">根节点的guid集合</param>
        /// <returns>多根节点集合树</returns>
        List<AdmJurisdiction> CreateNodesTreeList(DccyDbContext dbContext, List<AdmJurisdiction> admJurList);
        /// <summary>
        /// 向上找根节点
        /// </summary>
        /// <param name="admJurisdictionList">节点集合</param>
        /// <param name="AdmJurisdiction">当前节点，以用于方法迭代</param>
        /// <param name="rootMenuList">返回根节点集合</param>
        /// <param name="rootKeyGuidList">返回节点属性集合</param>
        void GetRootNodes(List<AdmJurisdiction> admJurisdictionList, AdmJurisdiction admJurisdiction);
        /// <summary>
        /// 由单一根节点向下构建树
        /// </summary>
        /// <param name="admJurisdictionList">节点集合</param>
        /// <param name="RootAdmJurisdiction">根节点</param>
        /// <returns></returns>
        AdmJurisdiction CreateNodeTree(List<AdmJurisdiction> admJurisdictionList, AdmJurisdiction RootAdmJurisdiction);


         List<AdmRole> GetAcountUserRolesListByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> depIdList, out List<string> depGuidList, out List<int> roleIdList, out List<string> roleGuidList);

        List<AdmRole> GetAcountUserRoleListTREEByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> roleIdList, out List<string> roleGuidList);


        List<AdmJurisdiction> GetAcountUserJurListTREEByAcountUser(DccyDbContext dbContext, AdmUser admUser, out List<int> jurIdList, out List<string> jurGuidList);
        #endregion


    }
}
