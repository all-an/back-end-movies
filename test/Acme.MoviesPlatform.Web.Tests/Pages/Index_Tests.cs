using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.MoviesPlatform.Pages
{
    public class Index_Tests : MoviesPlatformWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
