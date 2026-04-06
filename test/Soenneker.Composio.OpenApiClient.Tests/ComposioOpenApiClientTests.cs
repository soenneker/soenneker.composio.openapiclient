using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Composio.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ComposioOpenApiClientTests : FixturedUnitTest
{
    public ComposioOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
