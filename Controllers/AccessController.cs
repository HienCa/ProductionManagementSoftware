﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLySanXuat.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using QuanLySanXuat.Service;
using System.Security.Cryptography;

namespace QuanLySanXuat.Controllers
{
    public class AccessController : Controller
    {
        private readonly ProductionManagementSoftwareContext _context;

        public AccessController(ProductionManagementSoftwareContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Phieubanhang");

            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Account account)
        {
            if (ModelState.IsValid)
            {
                Nhanvien employee = _context.Nhanvien.Where(tk => tk.Email.Equals(account.Email)).Where(tk => tk.Matkhau.Equals(account.PassWord)).FirstOrDefault();
                Khachhang customer = _context.Khachhang.Where(tk => tk.Email.Equals(account.Email)).Where(tk => tk.Matkhau.Equals(account.PassWord)).FirstOrDefault();
                if (employee != null || customer != null)
                {
                    Response.Cookies.Append("HienCaCookie", account.Email);
                    List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, account.Email),
                    new Claim("OtherProperties", "Example Role")
                };
                    ClaimsIdentity claimIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties properties = new AuthenticationProperties()
                    {
                        AllowRefresh = true,
                        IsPersistent = account.KeepLoggedIn
                    };
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimIdentity), properties);


                    return RedirectToAction("Index", "Phieubanhang");
                    //if (employee != null)
                    //{
                    //    return RedirectToAction("Index", "PhieuNhapKho");
                    //}
                    //else if (customer != null)
                    //{
                    //    return RedirectToAction("Index", "");//gắn controller cho khách hàng
                    //}

                }
                else
                {
                    ViewData["ValidateMessage"] = "Tài khoản đăng nhập không hợp lệ";

                }
            }


            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public string GenerateToken(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }
        [HttpPost]
        public IActionResult ForgotPassword(Account account)
        {

            var newPassword = GenerateToken(12);
            string errorMessage = "Email không chính xác. Vui lòng kiểm tra lại email!";


            try
            {
                Nhanvien nv = _context.Nhanvien.Where(tk => tk.Email.Equals(account.Email)).FirstOrDefault();
                Khachhang kh = _context.Khachhang.Where(tk => tk.Email.Equals(account.Email)).FirstOrDefault();

                string message = "";
                var address = account.Email;

                var subject = "Reset your password";

                var mailContent = new MailContent();
                mailContent.Subject = subject;
                if (kh != null)
                {
                    message = "Xin Chào '" + kh.Tenkh + "' Mật khẩu mới của bạn là " + newPassword;
                    kh.Matkhau = newPassword;
                    mailContent.To = kh.Email;
                }
                if (nv != null)
                {
                    message = "Xin Chào '" + nv.Tennv + "' Mật khẩu mới của bạn là " + newPassword;
                    nv.Matkhau = newPassword;
                    mailContent.To = nv.Email;
                }
                else
                {
                    ViewData["errorMessage"] = errorMessage;
                }
                mailContent.Body = "<h1>From HienCa Production</h1><br/>" + message;

                //sendmail(từ mail, đến mail, tiêu đề, nội dung, mail gửi, mật khẩu ứng dụng)


                //mailContent.To = "dtny050601@gmail.com";   



                //IConfiguration _configuration = null;

                //_configuration.GetSection("MailSettings");

                ////khai báo lấy cấu hình trong appsetting.json ra
                //IOptions<MailSettings> mailSettings = mailSettings.;
                //SendMailService c = new SendMailService(mailSettings);
                SendMailService c = new SendMailService();
                c.SendMail(mailContent);

                _context.SaveChanges();

                TempData["SuccessMessage"] = "Chúng tôi đã gửi mail xác nhận đến cho bạn. Vui lòng kiểm tra mail!";

                //return RedirectToAction("Login", "Access");


            }
            catch (Exception e)
            {
                ViewData["errorMessage"] = "Email không khả dụng " + e;
            }



            return View();
        }

        public static string RandomNumber(int numberRD)
        {
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[numberRD];
                int x;
                //that is to create the random # and add it to string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return randomStr;
        }
    }
}
