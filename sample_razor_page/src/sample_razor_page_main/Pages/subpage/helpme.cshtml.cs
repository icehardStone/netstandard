using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MyApp.Namespace
{
    public class helpmeModel : PageModel
    {
        private readonly ILogger<helpmeModel> _logger;
        public helpmeModel(ILogger<helpmeModel> logger)
        {
            this._logger = logger;
        }
        #region 基础属性
        public string Name{set;get;}
        public string ID{set;get;}
        public int Age{set;get;}
        #endregion
        public void OnGet()
        {
            this.Name = "admas";
            this.ID = Guid.NewGuid().ToString();
            this.Age = 18;

            this._logger.LogInformation("get {0}'s message!");
        }
    }
}
