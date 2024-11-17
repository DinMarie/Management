
namespace KpopBL
{
    public class validationSer
    {
        UserGetServices user = new UserGetServices();
        public bool CheckIfNameExists(string Name) //
        {
            bool result = user.GetGroup(Name) != null;
            return result;
        }
    }
}