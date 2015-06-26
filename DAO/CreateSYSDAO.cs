using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*************************************************************************************
    * CLR 版本：       4.0.30319.33440
    * 类 名 称：       CreateSYSDAO
    * 机器名称：       SEPHIROTHBF0C
    * 命名空间：       DAO
    * 文 件 名：       CreateSYSDAO
    * 创建时间：       15/5/17 09:23:45
    * 作    者：       吴占超
    * 说    明：       
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

namespace DAO
{
    public class CreateSYSDAO
    {
        public static Interface_Dapper.SystemDAO GetSephiroth_System()
        {
            Interface_Dapper.SystemDAO sys = new Interface_Dapper.SystemDAO();
            sys.datasource = System.Configuration.ConfigurationManager.AppSettings["datasource"];
            sys.dbsource = System.Configuration.ConfigurationManager.AppSettings["dbsource"];
            sys.dbtype = System.Configuration.ConfigurationManager.AppSettings["dbtype"];
            sys.username = System.Configuration.ConfigurationManager.AppSettings["username"];
            sys.password = System.Configuration.ConfigurationManager.AppSettings["password"];
            return sys;
        }
    }
}
