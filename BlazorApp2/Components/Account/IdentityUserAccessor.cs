using Microsoft.AspNetCore.Identity;
using BlazorApp2.Data;

namespace BlazorApp2.Components.Account;

internal sealed class IdentityUserAccessor(
    UserManager<Employee> userManager,
    IdentityRedirectManager redirectManager)
{
    public async Task<Employee> GetRequiredUserAsync(HttpContext context)
    {
        var user = await userManager.GetUserAsync(context.User);

        if (user is null)
        {
            redirectManager.RedirectToWithStatus("Account/InvalidUser",
                $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
        }

        return user;
    }
}