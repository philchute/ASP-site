using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace ASP_site.Pages.Servers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // Good for redirects
    [IgnoreAntiforgeryToken] // Not needed for a GET redirector
    public class ConnectModel : PageModel
    {
        // Dictionary to hold your server shortcuts and their Steam connect URLs
        // Using StringComparer.OrdinalIgnoreCase to make the shortcut case-insensitive
        private readonly Dictionary<string, string> _serverRedirects = new(StringComparer.OrdinalIgnoreCase)
        {
            { "tfpeast2", "steam://connect/104.207.129.123:27015/letsplay!" },
            { "tfpsoutheast", "steam://connect/45.77.162.42:27015/letsplay!" },
            { "tfpcentral", "steam://connect/149.28.241.217:27015/letsplay!" },
            { "tfplondon", "steam://connect/192.248.163.247:27015/letsplay!" },
            { "tfpugsnyc", "steam://connect/149.28.56.141:27015/letsplay!" },
            { "tfpugsricochet", "steam://connect/149.28.56.141:27016/letsplay!" },
            // Add more servers here as needed, e.g.:
            // { "myotherserver", "steam://connect/another.ip:port" }
        };

        public IActionResult OnGet(string serverIdentifier)
        {
            if (string.IsNullOrEmpty(serverIdentifier) || !_serverRedirects.TryGetValue(serverIdentifier, out var steamUrl))
            {
                // If the identifier is not found or empty, redirect to the main servers list
                return RedirectToPage("/Servers/Index");
            }

            // If found, redirect to the Steam connect URL
            return Redirect(steamUrl);
        }
    }
} 