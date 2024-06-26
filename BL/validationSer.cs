using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DL;
using Modelsa;
namespace BL
{
    public class validationSer
    {
        UserGetServices user = new UserGetServices();
        public bool CheckIfIDExists(string ID)
        {
            bool result = user.GetGroup(ID) != null;
            return result;
        }
        public bool CheckIfNameExists(string Name)
        {
            bool result = user.GetGroup(Name) != null;
            return result;
        }
    }
}