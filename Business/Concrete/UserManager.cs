using Base.Aspects.Autofac.Validation;
using Base.Utilities.Encryption;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Exceptions;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using Entities.Dtos.Users;
using Entities.Enums;
using Entities.VMs.UserVMs;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        
        public void ChangePassword(UserChangePasswordDTO userChangePassword)
        {
            User registeredUser = _userDal.Get(u => u.UserName == userChangePassword.UserName);
            if (registeredUser == null)
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }

            if (HashingHelper.VerifyPasswordHash(userChangePassword.OldPassword, registeredUser.PasswordHash))
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }

            byte[] newHashedPassword;
            HashingHelper.CreatePasswordHash(userChangePassword.NewPassword, out newHashedPassword);
            registeredUser.PasswordHash = newHashedPassword;
            _userDal.Update(registeredUser);

        }

        [SecuredOperation(UserClaims.Admin)]
        public UserVm Get(string id)
        {
            User user = _userDal.Get(u => u.UserName == id);
            UserVm userVm = new UserVm()
            {
                UserName = user.UserName,
                UserClaim = user.UserClaim,
                RegisterDate = user.RegisterTime,
                BirthDate = user.BirthDate
            };
            return userVm;
        }

        [SecuredOperation(UserClaims.Admin)]
        public List<UserVm> GetAll()
        {
            List<User> userList = _userDal.GetAll();
            List<UserVm> userVmList = new List<UserVm>();
            foreach (User item in userList)
            {
                UserVm userVm = new UserVm()
                {
                    BirthDate = item.BirthDate,
                    RegisterDate = item.RegisterTime,
                    UserClaim = item.UserClaim,
                    UserName = item.UserName
                };
                userVmList.Add(userVm);
            }

            return userVmList;
        }

        public UserVm Login(UserLoginDTO user)
        {
            User registeredUser = _userDal.Get(u => u.UserName == user.UserName);
            if (registeredUser == null)
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }
            if (HashingHelper.VerifyPasswordHash(user.Password, registeredUser.PasswordHash))
            {
                throw new LoginFailedException("Kullanıcı adı veya şifre hatalı.");
            }

            UserVm userVm = new UserVm()
            {
                UserClaim = registeredUser.UserClaim,
                UserName = registeredUser.UserName,
            };

            return userVm;
        }

        [ValidationAspect(typeof(UserValidator))]
        public void Register(UserCreateDTO user)
        {
            if (_userDal.Get(u => u.UserName == user.UserName) != null)
            {
                throw new AlreadyExistsException("Bu kullanıcı adı daha önce alınmış");
            }

            byte[] password;
            HashingHelper.CreatePasswordHash(user.Password, out password);
            User newUser = new User()
            {
                BirthDate = user.BirthDate,
                UserName = user.UserName,
                PasswordHash = password,
                RegisterTime = DateTime.Now,
                UserClaim = UserClaims.User
            };

            _userDal.Add(newUser);
        }


    }

}
