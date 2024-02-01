using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using UltraUserAdmin.ViewModels;
using UltraUserAdmin.Interfaces;
using Newtonsoft.Json;

namespace UltraUserAdmin.Managers
{
    public class AppManager: IAppInterface
    {
        private readonly string apiUrlValidateUser = "https://appext2.pentafon.com/UltraUserManager/api/ValidateUserMail"; // URL API ValidateUserMail
        private readonly string apiUrlGeneratePass = "https://appext2.pentafon.com/UltraUserManager/api/GeneratePassSendMail"; // URL API GeneratePassSendMail
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public ResValidateUserMailVm SendValidateUser(string appnm, string user)
        {
            ValidateUserMailVm objValidateUser = new ValidateUserMailVm();
            objValidateUser.AppName = appnm;
            objValidateUser.UserName = user;

            ResValidateUserMailVm apiResponse = new ResValidateUserMailVm();

            using (HttpClient httpClient = new HttpClient())
            {
                // Serializar el objeto Usuario a JSON
                string jsonBody = JsonConvert.SerializeObject(objValidateUser);

                // Configurar la solicitud POST
                HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST de manera síncrona
                HttpResponseMessage response = httpClient.PostAsync(apiUrlValidateUser, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Leer y deserializar la respuesta JSON de manera síncrona
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;
                    apiResponse = JsonConvert.DeserializeObject<ResValidateUserMailVm>(jsonResponse);

                    return apiResponse;
                }
                else
                {
                    // Manejar el error si la solicitud no fue exitosa
                    apiResponse.AppName = appnm;
                    apiResponse.UserName = user;
                    apiResponse.Mail = "";
                    apiResponse.Status = "0";

                    return apiResponse;
                }
            }

        }
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public ResGeneratePassSendMailVm SendResetPassword(string appnm, string user, string mail)
        {
            GeneratePassSendMailVm objResetPass = new GeneratePassSendMailVm();
            objResetPass.AppName = appnm;
            objResetPass.UserName = user;
            objResetPass.Mail = mail;

            ResGeneratePassSendMailVm apiResponse = new ResGeneratePassSendMailVm();

            using (HttpClient httpClient = new HttpClient())
            {
                // Serializar el objeto Usuario a JSON
                string jsonBody = JsonConvert.SerializeObject(objResetPass);

                // Configurar la solicitud POST
                HttpContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST de manera síncrona
                HttpResponseMessage response = httpClient.PostAsync(apiUrlGeneratePass, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Leer y deserializar la respuesta JSON de manera síncrona
                    string jsonResponse = response.Content.ReadAsStringAsync().Result;
                    apiResponse = JsonConvert.DeserializeObject<ResGeneratePassSendMailVm>(jsonResponse);

                    return apiResponse;
                }
                else
                {
                    // Manejar el error si la solicitud no fue exitosa
                    apiResponse.AppName = appnm;
                    apiResponse.UserName = user;
                    apiResponse.Mail = mail;
                    apiResponse.NwPass = "";
                    apiResponse.Status = "0";

                    return apiResponse;
                }
            }

        }
        //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

    }
}