using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlog
{
    /// <summary>  
    /// My view location expander  
    /// </summary>  
    public class MyViewLocationExpander : IViewLocationExpander
    {

        public IEnumerable<String> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<String> viewLocations)
        {
            return new[]
            {
            "/PLL/Views/{1}/{0}.cshtml",
            "/PLL/Views/Shared/{0}.cshtml"
        };
        }
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
