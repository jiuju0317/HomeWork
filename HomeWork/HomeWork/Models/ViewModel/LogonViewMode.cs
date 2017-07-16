using HomeWork.ValidateAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models.ViewModel
{
    public class LoginViewModel
    {
        //驗證的順序不是依照引用順序
        //ErrorMessageResourceName與ErrorMessageResourceType是指訊息要對應的顯示多國語系，與ErrorMessage只能顯示一種

        //Client顯示訊息【RegularEmail格式錯誤】
        //Server顯示訊息【RegularEmail格式錯誤】
        //這個jiuju@mail會當作成功
        //[RegularExpression(@"\w+\@\w+", ErrorMessage = "RegularEmail格式錯誤")]

        //Client顯示訊息【Please enter a valid email address.】
        //Server顯示訊息【請在電子郵件中包含......奇怪的訊息】
        //這個使用正常但訊息不可控制
        //[DataType(DataType.EmailAddress, ErrorMessage = "DataType Email格式錯誤")]

        //Client顯示訊息【EmailEmail格式錯誤】
        //Server顯示訊息【EmailEmail格式錯誤】
        //這個最正常了
        //[Email(ErrorMessage = "EmailEmail格式錯誤")]
        
        //Client顯示訊息【Account StringLength欄位最少 10 個字，最多 20 個字】
        //Server顯示訊息【Account StringLength欄位最少 10 個字，最多 20 個字】
        //[StringLength(20, MinimumLength = 10, ErrorMessage = "{0} StringLength欄位最少 {2} 個字，最多 {1} 個字")]//最多20個字、最少4個字                                              

        //Server
        //[Required]

        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "{0} StringLength欄位最少 {2} 個字，最多 {1} 個字")]//最多20個字、最少4個字                                              
        [Display(Name = "Email")]
        [Email(ErrorMessage = "Email格式錯誤")]
        [NoIs("skilltree,demo,twMVC", ErrorMessage = "請使用別的名稱")]
        public string Account { get; set; }
        //Server
        [Required]
        public string Password { get; set; }
        public string Message { get; set; }
    }
}