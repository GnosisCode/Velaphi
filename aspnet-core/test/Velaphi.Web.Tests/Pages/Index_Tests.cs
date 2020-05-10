using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Velaphi.Pages
{
    public class Index_Tests : VelaphiWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
