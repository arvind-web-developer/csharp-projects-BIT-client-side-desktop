using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using Entity;


namespace BusinessLogicLayer
{
    public class User
    {
        private string profileType;

        public string ProfileType
        {
            get { return profileType; }
        }


        private int userID;

        public int UserID
        {
            get { return userID; }
        }

        private string userName = "";

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        private string password = "";

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string email = "";

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private bool isApproved = false;

        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }

        private bool isLockedOut = false;

        public bool IsLockedOut
        {
            get { return isLockedOut; }
            set { isLockedOut = value; }
        }

        private DateTime lastLockoutDate;

        public DateTime LastLockoutDate
        {
            get { return lastLockoutDate; }
            set { lastLockoutDate = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public UserEntity Entity(User user)
        {
            UserEntity entity = new UserEntity();
            entity.UserID = user.UserID;
            entity.UserName = user.UserName;
            entity.Password = user.Password;
            //entity.PasswordFormat = user.PasswordFormat;
            //entity.PasswordSalt = user.PasswordSalt;
            entity.Email = user.Email;
            //entity.PasswordQuestion = user.PasswordQuestion;
            //entity.PasswordAnswer = user.PasswordAnswer;
            entity.IsApproved = user.IsApproved;
            entity.IsLockedOut = user.IsLockedOut;
            //entity.CreateDate = user.CreateDate;
            //entity.LastLoginDate = user.LastLoginDate;
            //entity.LastPasswordChangedDate = user.LastPasswordChangedDate;
            entity.LastLockoutDate = user.LastLockoutDate;
            //entity.FailedPasswordAttemptCount = user.FailedPasswordAttemptCount;
            //entity.FailedPasswordAttemptWindowStart = user.FailedPasswordAttemptWindowStart;
            //entity.FailedPasswordAnswerAttemptCount = user.FailedPasswordAnswerAttemptCount;
            //entity.FailedPasswordAnswerWindowStart = user.FailedPasswordAnswerWindowStart;
            entity.Comment = user.Comment;
            //entity.ApplicationID = user.ApplicationID;
            return entity;
        }


        public bool IsValid(User user)
        {
            IUserData userdata = new UserData();

            DataTable dt = new DataTable();
            dt = userdata.getSPUser(user.Entity(user));
            //System.Windows.Forms.MessageBox.Show("UserID:: " + dt.Rows[0]["UserID"]);

            userID = Convert.ToInt32(dt.Rows[0]["UserID"]);

            //if (dt.Rows.Count == 0)
            if (userID <= 0)
            {
                return false;
            }
            else
            {
                profileType = dt.Rows[0]["RoleName"].ToString();
                //System.Windows.Forms.MessageBox.Show("RoleID:: " + dt.Rows[0]["RoleName"]);

                return true;
            }
        }

        public static DataTable InsertUser(string userRole, string roleData, string userLogin, User user)
        {
            IUserData userData = new UserData();
            user.Password = "123456";      // default new password
            user.IsApproved = true;
            user.IsLockedOut = false;
            DataTable tb = userData.InsertUser(userRole, roleData, userLogin, user.Entity(user));
            return tb;
        }

        public static DataTable DeactivateUser(string userRole, string roleData, string userLogin, User user)
        {
            IUserData userData = new UserData();

            DataTable tb = userData.DeactivateUser(userRole, roleData, userLogin, user.Entity(user));
            return tb;
        }
    }
}
