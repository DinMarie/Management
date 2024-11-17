using Microsoft.AspNetCore.Mvc;
using KpopBL;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace ManagementAPI.Controllers
{
    [ApiController]
    [Route("api/group")]
    public class ManagementController : ControllerBase
    {
        UserGetServices getServices;
        Business transactionService;

        private readonly string _accessKey = "";
        private readonly string _secretKey = "";
        private readonly string _bucketName = "jmnaval";
        private readonly AmazonS3Client _s3Client;

        public ManagementController()
        {
            getServices = new UserGetServices();
            transactionService = new Business();
            _s3Client = new AmazonS3Client(_accessKey, _secretKey, Amazon.RegionEndpoint.USEast1);
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

        [HttpPost("Add")]
        public JsonResult AddGroup(Group request)
        {
            var result = transactionService.CreateGroup(request.GroupID, request.Name);

            return new JsonResult(result);
        }

        [HttpPatch("Update")]
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

        // New endpoint to upload a file to S3
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFileToS3(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file provided.");
            }

            var fileTransferUtility = new TransferUtility(_s3Client);

            try
            {
                using (var fileStream = file.OpenReadStream())
                {
                    var uploadRequest = new TransferUtilityUploadRequest
                    {
                        InputStream = fileStream,
                        Key = file.FileName, // S3 object key (name of the file)
                        BucketName = _bucketName,
                        ContentType = file.ContentType
                    };

                    await fileTransferUtility.UploadAsync(uploadRequest);
                }

                return Ok("File uploaded successfully.");
            }
            catch (AmazonS3Exception e)
            {
                return StatusCode(500, $"Error encountered: {e.Message}");
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Unexpected error: {e.Message}");
            }
        }
    }
}
