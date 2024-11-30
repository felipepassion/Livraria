using Bunit;
using Niu.Nutri.WebApp.Client.Pages;

namespace Niu.Nutri.WebApp.Client.Tests
{
    public class IndexTest
    {
        [Fact]
        public void Index_ShouldRender()
        {
            using var ctx = new TestContext();

            var cut = ctx.RenderComponent<Pages.Index>();

            cut.MarkupMatches("");


        }
    }
}