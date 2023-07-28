using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;

namespace RMS.Attributes
{
	public class ApiKeyAuthorizationAttribute : TypeFilterAttribute
	{
		public ApiKeyAuthorizationAttribute() : base(typeof(ApiKeyAuthorizationFilter))
		{
		}
	}

	public class ApiKeyAuthorizationFilter : IAsyncAuthorizationFilter
	{
		private readonly UserManager userManager;

		public ApiKeyAuthorizationFilter(UserManager userManager)
		{
			this.userManager = userManager;
		}

		public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
		{
			if (!context.HttpContext.Request.Query.TryGetValue("apiKey", out var apiKey))
			{
				context.Result = new ObjectResult(new { Message = "API key not provided." })
				{
					StatusCode = 400
				};
				return;
			}

			if (!await userManager.SignInByApiKeyAsync(apiKey))
			{
				context.Result = new ObjectResult(new { Message = "Unauthorized." })
				{
					StatusCode = 401
				};
				return;
			}
		}
	}
}
