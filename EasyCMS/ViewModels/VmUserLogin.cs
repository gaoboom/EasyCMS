using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.ViewModels
{
    public class VmUserLogin
    {
        [Required(ErrorMessage ="{0}必填")]
        [Display(Name ="登录名")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "{0}长度为{2}-{1}个字符")]
        public string Account { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        [StringLength(256, ErrorMessage = "{0}长度少于{1}个字符")]
        public string Password { get; set; }
    }
}