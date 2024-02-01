using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UltraUserAdmin.ViewModels
{
    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public class ValidateUserMailVm
    {
        public string AppName { get; set; }
        public string UserName { get; set; }
    }
    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -    
    public class ResValidateUserMailVm
    {
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Status { get; set; }
    }
    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public class GeneratePassSendMailVm
    {
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
    }
    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
    public class ResGeneratePassSendMailVm
    {
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string NwPass { get; set; }
        public string Status { get; set; }
    }
    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
}