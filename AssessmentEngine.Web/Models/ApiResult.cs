using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AssessmentEngine.Web.Models
{
    public class ApiResult
    {
        public bool IsValid { get; set; }
        
        // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
        public IEnumerable<string> Errors { get; set; }
        public object Data { get; set; }

        public ApiResult()
        {
        }
        
        public ApiResult(ModelStateDictionary modelState)
        {
            IsValid = modelState.IsValid;
            Errors = modelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
        }
    }
}