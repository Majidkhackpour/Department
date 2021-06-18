using Nito.AsyncEx;
using Services;
using Services.AndroidViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DepartmentDal.Classes.Building
{
    public class clsBuilding
    {
        public static async Task<List<BuildingListViewModel>> GetListAsync(string hSerial)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var res = await client.GetStringAsync(Utilities.WebApi + "/Buildings_GetLastList/" + hSerial);
                    var user = res.FromJson<List<BuildingListViewModel>>();
                    return user;
                }
            }
            catch (Exception ex)
            {
                WebErrorLog.ErrorInstence.StartErrorLog(ex);
                return null;
            }
        }
        public static List<BuildingListViewModel> GetList(string hSerial) => AsyncContext.Run(() => GetListAsync(hSerial));
    }
}
