[![](https://img.shields.io/nuget/v/soenneker.composio.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.composio.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.composio.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.composio.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.composio.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.composio.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.composio.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.composio.openapiclient/actions/workflows/codeql.yml)

# Soenneker.Composio.OpenApiClient

A generated .NET client for Composio's platform API, covering toolkits, tools, connected accounts, auth configurations, triggers, webhooks, files, and organization operations.

## Installation

```bash
dotnet add package Soenneker.Composio.OpenApiClient
```

## Create the client directly

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Composio.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);

var authentication = new AnonymousAuthenticationProvider();
using var adapter = new HttpClientRequestAdapter(authentication, httpClient: httpClient);
var client = new ComposioOpenApiClient(adapter);
```

The generated client defaults to `https://backend.composio.dev`. Set `adapter.BaseUrl` before constructing `ComposioOpenApiClient` when using an alternate endpoint.

## List toolkits

```csharp
var result = await client.Api.V3.Toolkits.GetAsync(request =>
{
    request.QueryParameters.Limit = 50;
    request.QueryParameters.Search = "github";
}, cancellationToken);
```

Endpoints follow Kiota's request-builder hierarchy beneath `client.Api`. Collection items are selected through generated indexers, request bodies use types from `Soenneker.Composio.OpenApiClient.Models`, and methods accept an optional request-configuration callback and `CancellationToken`.

For managed client reuse and application configuration, use `Soenneker.Composio.OpenApiClientUtil`, which composes this generated client with `Soenneker.Composio.HttpClients`.

This repository contains generated source. Keep application-specific behavior in wrapper services or separate partial-class files because regeneration can replace generated files.
