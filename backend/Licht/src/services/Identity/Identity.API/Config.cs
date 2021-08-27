using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace Identity.API
{
    public class Config
    {
        public static IEnumerable<Client> Clients()
        {
            return new Client[]
            {
                //Block 2:  MVC client using hybrid flow
                new Client
                {
                    ClientId = "webclient",
                    ClientName = "Web Client",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    RedirectUris = { "https://localhost:5002/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:5002/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "identity.api","test.api" }
                },

                //Block 3: SPA client using Code flow
                new Client
                {
                    ClientId = "spaclient",
                    ClientName = "SPA Client",
                    ClientUri = "https://localhost:5003",
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris =
                    {
                        "https://localhost:5003/index.html",
                        "https://localhost:5003/callback.html"
                    },

                    PostLogoutRedirectUris = { "https://localhost:5003/index.html" },
                    AllowedCorsOrigins = { "https://localhost:5003" },

                    AllowedScopes = { "openid", "profile", "identity.api" ,"test.api" }
                },
                new Client
                {
                    ClientId = "identityClient",
                    ClientName = "Client Credentials Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedScopes = { "apiread", "apiwrite" }
                },
            };
        }

        public static IEnumerable<ApiResource> ApiResources()
        {
            return new ApiResource[]
           {
                new ApiResource("ApiGateway.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },

                new ApiResource("Aggregator.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },

                new ApiResource("Article.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("Bookmark.API")
                {
                Scopes = new List<string> { "apiread", "apiwrite" },
                ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("Comment.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("FileStorage.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("Article.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("ImageAlbum.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("Posts.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                },
                new ApiResource("User.API")
                {
                    Scopes = new List<string> { "apiread", "apiwrite" },
                    ApiSecrets = new List<Secret> { new Secret("supersecret".Sha256()) }
                }
           };
        }

        public static IEnumerable<ApiScope> ApiScopes()
        {
            return new ApiScope[]
            {
                    new ApiScope("apiread"),
                    new ApiScope("apiwrite"),
                    new ApiScope("openid"),
                    new ApiScope("profile"),
                    new ApiScope("identity.api"),
                    new ApiScope("test.api")
            };
        }

        public static List<TestUser> TestUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "123",
                    Username = "Andre",
                    Password = "Andre",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Monty Python"),
                        new Claim(JwtClaimTypes.GivenName, "Monty"),
                        new Claim(JwtClaimTypes.FamilyName, "Python"),
                        new Claim(JwtClaimTypes.WebSite, "http://test.com"),
                    }
                }
            };
        }

        public static IEnumerable<IdentityResource> IdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }
    }
}