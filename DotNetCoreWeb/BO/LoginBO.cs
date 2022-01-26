using DotNetCoreWeb.DBContext;
using DotNetCoreWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWeb.BO
{
    public class LoginBO
    {
        public readonly DAO db;
        public LoginBO(DAO DAOService)
        {
            db = DAOService;
        }
        #region 登入流程
        public bool CheckLogin(string LoginID, string Password)
        {            
            // 登入
            bool ret = false;

            return ret;
        }
        public void SetLoginTime(string LoginID)
        {
            // 更新登入時間
        }
        public void SetState(string LoginID, bool On=true)
        {
            // 設定帳號狀態
        }
        public void CheckGroup(string LoginID)
        {
            // 取得登入群組
        }
        #endregion
        #region sysSecurity
        /// <summary>
        /// 取得單一筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public sysSecurity GetOne(string id)
        {
            return db.sysSecurity.Where(m => m.UID == id).FirstOrDefault();
        }
        /// <summary>
        /// 取得清單
        /// </summary>
        /// <returns></returns>
        public List<sysSecurity> GetList()
        {
            return db.sysSecurity.ToList();
        }
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool sysSecurityInsert(sysSecurity vo)
        {
            bool ret = true;
            try
            {
                vo.UID = Guid.NewGuid().ToString();
                db.Add(vo);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                ret = false;
                // save exception log
            }

            return ret;
        }
        /// <summary>
        /// 更新資料
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool sysSecurityUpdate(sysSecurity vo)
        {
            bool ret = true;
            try
            {
                db.sysSecurity.Update(vo);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ret = false;
                // save exception log
            }

            return ret;
        }
        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool sysSecurityDelete(string id)
        {
            bool ret = true;
            try
            {
                var obj = db.sysSecurity.Where(m => m.UID == id).FirstOrDefault();
                db.sysSecurity.Remove(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ret = false;
                // save exception log
            }

            return ret;
        }
        #endregion
    }
}
