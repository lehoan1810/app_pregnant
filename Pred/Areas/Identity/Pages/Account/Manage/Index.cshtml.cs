using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pred.Models;

namespace Pred.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Số điện thoại")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Họ và tên")]
            public string Name { get; set; }

            [Display(Name = "Ngày sinh")]
            public string BirthDate { get; set; }

            [Display(Name = "Giới tính")]
            public bool Sex { get; set; }

            [Display(Name = "Công việc")]
            public string Job { get; set; }

            [Display(Name = "Địa chỉ")]
            public string Address { get; set; }


            [Display(Name = "Số tuần thai")]
            [Range(0,36, ErrorMessage = "Phải trong khoảng từ 0 tới 36 tuần")]
            public int Week { get; set; }

            public byte[] ProfilePic { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var sex = user.Sex;
            var address = user.Address;
            var job = user.Job;
            var birthdate = "2017-06-01";
            var profilepic = user.ProfilePicture;
            var name = user.Name;
            var week = user.Week;

            Username = userName;

            Input = new InputModel
            {
                Name = name,
                ProfilePic = profilepic,
                PhoneNumber = phoneNumber,
                Sex = sex,
                Address = address,
                Job = job,
                BirthDate = birthdate,
                Week = week,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    user.ProfilePicture = dataStream.ToArray();
                }
                await _userManager.UpdateAsync(user);
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            var name = user.Name;
            if (Input.Name != name)
            {
                user.Name = Input.Name;
                await _userManager.UpdateAsync(user);
            }

            var address = user.Address;
            if (Input.Address != address)
            {
                user.Address = Input.Address;
                await _userManager.UpdateAsync(user);
            }

            var job = user.Job;
            if (Input.Job != job)
            {
                user.Job = Input.Job;
                await _userManager.UpdateAsync(user);
            }

            var birthdate = "2017-06-01";
            if (Input.BirthDate != birthdate)
            {
                //user.BirthDate = Input.BirthDate;
                await _userManager.UpdateAsync(user);
            }

            var sex = user.Sex;
            if (Input.Sex != sex)
            {
                user.Sex = Input.Sex;
                await _userManager.UpdateAsync(user);
            }

            var week = user.Week;
            if (Input.Week != week)
            {
                user.Week = Input.Week;
                await _userManager.UpdateAsync(user);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Cập nhật thành công";
            return RedirectToPage();
        }
    }
}
