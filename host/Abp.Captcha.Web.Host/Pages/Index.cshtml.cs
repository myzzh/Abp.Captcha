﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Abp.Captcha.Pages
{
    public class IndexModel : CaptchaPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}