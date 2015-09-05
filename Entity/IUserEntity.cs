using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entity
{
    public interface IUserEntity
    {
        int UserID { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        int PasswordFormat { get; set; }

        string PasswordSalt { get; set; }

        string Email { get; set; }

        string PasswordQuestion { get; set; }

        string PasswordAnswer { get; set; }

        bool IsApproved { get; set; }

        bool IsLockedOut { get; set; }

        DateTime CreateDate { get; set; }

        DateTime LastLoginDate { get; set; }

        DateTime LastPasswordChangedDate { get; set; }

        DateTime LastLockoutDate { get; set; }

        int FailedPasswordAttemptCount { get; set; }

        DateTime FailedPasswordAttemptWindowStart { get; set; }

        int FailedPasswordAnswerAttemptCount { get; set; }

        DateTime FailedPasswordAnswerWindowStart { get; set; }

        string Comment { get; set; }

        string ApplicationID { get; set; }

        string RoleName { get; set; }

    }
}
