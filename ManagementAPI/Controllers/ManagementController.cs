using Microsoft.AspNetCore.Mvc;
using KpopBL;

namespace ManagementAPI.Controllers
{
    [ApiController]
    [Route("api/group")]
    public class ManagementController : ControllerBase
    {
        UserGetServices getServices;
        Business transactionService;

        public ManagementController()
        {
            getServices = new UserGetServices();
            transactionService = new Business();
        }

        [HttpGet]
        public IEnumerable<ManagementAPI.Group> GetGroup()
        {
            var group = getServices.GetAllGroups();

            List<ManagementAPI.Group> cont = new List<ManagementAPI.Group>();

            foreach (var groups in group)
            {
                cont.Add(new ManagementAPI.Group { GroupID = groups.GroupID, Name = groups.Name });
            }
            return cont;
        }
        [HttpPost]
        public JsonResult AddGroup(Group request)
        {
            var result = transactionService.CreateGroup(request.GroupID, request.Name);

            return new JsonResult(result);

        }

        [HttpPatch]
        public JsonResult UpdateGroup(Group request)
        {
            var result = transactionService.UpdateGroup(request.GroupID, request.Name);

            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteRoom(ManagementAPI.Group request)
        {

            var groupToDelete = new Modelsa.Group
            {
                GroupID = request.GroupID

            };

            var result = transactionService.DeleteGroup(groupToDelete);

            return new JsonResult(result);
        }
    }
}