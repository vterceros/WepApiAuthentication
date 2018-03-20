using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiauth.Modules
{
    public class ModuleVictor : IHttpModule
    {
        public String ModuleName { get { return "ModuleVictor"; } }        
        public void Init(HttpApplication context)
        {
            //if (context.Request != null)
            //{
            //    if (VirtualPathUtility.GetExtension(context.Request.FilePath).Equals(".asmx"))
            //    { }
            //}
            
            //context.Response.Write("<h1>Hello Victor<h1>");
        }
        public void Dispose()
        {
        }
    }
}