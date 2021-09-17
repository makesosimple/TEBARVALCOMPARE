using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBPortal.Resources
{
    /* Custom error describer for Identity Framework
     * 
     * @return: All methods return an IdentityError object.
     * @bind: Binded in Startup class. See: Identity configuration for more options.
     * 
     * Notes for future development: 
     * This error messages are embedded because currently
     * customer only needs one language (TR). Future development may need to extend this resource to 
     * another language so I am commenting the area on the PasswordTooShort() method to give future developer
     * some idea on how to achieve that without corrupting the code design. You need a resources class that generalizes
     * the fetch of the values from a static file(Use ASP.NET recommended resource file type!). This file must be based on 
     * (key, value) pair and keys must be same on every language file source. Additionally, you can use database to save and load
     * language data to Controllers and Views etc. but since extra data will slow down the database, I recommend using the resource file.
     * 
     * !! WARNING !!
     * If users are changing the content of the translations then using the database is a much smarter way then a static resource file.
     * Use this method in static dashboards. Content-driven CMS projects on the other hand must use a database!
     */

    public class LocalizedIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = "Bu e-posta adresi sisteme önceden kayıt edilmiştir!"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = "Bu kullanıcı adı sisteme önceden kayıt edilmiştir!"
            };
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(InvalidEmail),
                Description = "Geçersiz e-posta adresi."
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = "Bu rol sisteme önceden kayıt edilmiştir!"
            };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = "Geçersiz rol ismi."
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = "Geçersiz jeton."
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = "Geçersiz kullanıcı adı."
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = "Bağlanmaya çalıştığınız hesap zaten giriş yapmıştır. Önceki oturumunuzu kapatıp tekrar deneyin."
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = "Şifre ve Doğrulama alanları uyuşmamaktadır."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "Şifreye en az bir tane rakam girmelisiniz!"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = "Şifreye en az bir tane küçük harf girmelisiniz!"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "Şifreye en az bir tane özel karakter girmelisiniz!"
            };
        }

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = "Şifreye girdiğiniz harfler aynı olmamalıdır!"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "Şifreye en az bir tane büyük harf girmelisiniz!"
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                //Description = string.Format(LocalizedIdentityErrorMessages.PasswordTooShort, length)
                Description = "Girdiğiniz şifre çok kısa!" 
            };
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = "Kullanıcı zaten bu şifreyle sisteme kayıtlıdır!"
            };
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = "Kullanıcı zaten bu roldedir."
            };
        }

        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = "Kullanıcı bu rol içinde değildir."
            };
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = "Kullanıcı kilitleme devre dışı!"
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = nameof(RecoveryCodeRedemptionFailed),
                Description = "Kurtarma kodu başarısız oldu"
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = "Eş zamanlılık hatası!"
            };
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = "Hata! Lütfen sistem yöneticinizle görüşün"
            };
        }
    }
}
