using Soenneker.Tests.HostedUnit;

namespace Soenneker.Composio.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ComposioOpenApiClientTests : HostedUnitTest
{
    public ComposioOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
