using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentEngine.Core.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AssessmentEngine.Web.Common
{
    public class LookupHelper
    {
        public static async Task<List<SelectListItem>> GetSelectList(Func<Task<IEnumerable<LookupTypeDTO>>> getLookup)
        {
            var lookup = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "Select",
                    Value = ""
                }
            };

            lookup.AddRange((await getLookup()).Select(x => new SelectListItem {Text = x.Name, Value = x.Id.ToString()}));
            
            return lookup;
        }
    }
}