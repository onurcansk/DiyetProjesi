using Base.Utilities.Interceptors;
using Castle.DynamicProxy;
using Entities.Dtos.Users;
using Entities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private UserClaims _role;
        UserLoginDTO _user;
        public SecuredOperation(UserClaims role)
        {
            _role = role;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            JsonDeserialization();
            if (_user.Claim == _role)
            {
                return;
            }
            throw new Exception("Bu işlemi yapmaya yetkiniz bulunmamaktadır");
        }

        private void JsonDeserialization()
        {
            JsonSerializer js = new JsonSerializer();
            StreamReader sr = new StreamReader($@"Serialization\user.json");
            JsonReader jsonReader = new JsonTextReader(sr);
            _user = js.Deserialize<UserLoginDTO>(jsonReader);
            jsonReader.Close();
            sr.Close();
        }
    }
}
