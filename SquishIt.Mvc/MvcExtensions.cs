using System.Web.Mvc;
using SquishIt.Framework.Css;
using SquishIt.Framework.JavaScript;

namespace SquishIt.Mvc
{
    //TODO: convert back to MVC1 / IHtmlString return type
	public static class MvcExtensions
	{
		public static MvcHtmlString RenderMvc(this ICssBundleBuilder cssBundleBuilder, string renderTo)
		{
			return MvcHtmlString.Create(cssBundleBuilder.Render(renderTo));
		}

        public static MvcHtmlString RenderMvc(this IJavaScriptBundleBuilder javaScriptBundleBuilder, string renderTo)
		{
            return MvcHtmlString.Create(javaScriptBundleBuilder.Render(renderTo));
		}

        public static MvcHtmlString RenderNamedMvc(this IJavaScriptBundle javaScriptBundle, string name)
		{
            return MvcHtmlString.Create(javaScriptBundle.RenderNamed(name));
		}

        public static MvcHtmlString RenderNamedMvc(this ICssBundle cssBundle, string name)
		{
            return MvcHtmlString.Create(cssBundle.RenderNamed(name));
		}
	}
}