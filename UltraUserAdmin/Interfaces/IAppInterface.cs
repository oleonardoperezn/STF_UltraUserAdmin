using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltraUserAdmin.ViewModels;

namespace UltraUserAdmin.Interfaces
{
    internal interface IAppInterface
    {
        ResValidateUserMailVm SendValidateUser(string appnm, string user);
        ResGeneratePassSendMailVm SendResetPassword(string appnm, string user, string mail);
    }
}
