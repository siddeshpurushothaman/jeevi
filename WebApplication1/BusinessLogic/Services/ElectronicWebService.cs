using BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppSettings;

namespace BusinessLogic.Services
{
    public class ElectronicWebService : IElectronicWebService
    {
        private readonly GlobalConfiguration _globalConfiguration;
        public ElectronicWebService(GlobalConfiguration globalConfiguration) {
            _globalConfiguration = globalConfiguration;
        }

        public Task GetEmployerData()
        {
            string password = _globalConfiguration.Environment.password;
            throw new NotImplementedException();
        }
    }
}
