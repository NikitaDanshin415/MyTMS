using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;

namespace TMS.WebApi
{
    public class ConfigurationIdentity
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("TmsWebAPI", "Web API")
            };

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new List<ApiResource>
            {
                new ApiResource("TmsWebAPI", "Web API", new[]{JwtClaimTypes.Name})
                {
                    Scopes = { "TmsWebAPI" }
                }
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "notes-web-api",
                    ClientName = "Notes Web",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,
                    RequirePkce = true,
                    RedirectUris =
                    {
                        "http://yandex.ru"
                    },
                    AllowedCorsOrigins =
                    {
                        "http://yandex.ru"
                    },
                    PostLogoutRedirectUris =
                    {
                        "http://yandex.ru"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "TmsWebAPI"
                    },
                    AllowAccessTokensViaBrowser = true
                }
            };
    }
}