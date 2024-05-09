using Microsoft.AspNetCore.Mvc;
using VehicleRegistrationBE.Entities;
using VehicleRegistrationBE.Helper;
using VehicleRegistrationBE.Models.Request;
using VehicleRegistrationBE.Models.Response;
using VehicleRegistrationBE.Repositories;

namespace VehicleRegistrationBE.Controllers
{
    [Route("document")]
    public class DocumentController : Controller
    {
        //repository
        private readonly DocumentRepository _repositoryDocument;

        public DocumentController(
            //repository
            DocumentRepository repositoryDocument
            )
        {
            //repository
            _repositoryDocument = repositoryDocument;
        }

        /* create bpkb
        * @param object CreateDocumentRequest request
        */
        [HttpPost("")]
        public IActionResult CreateDocument([FromBody] CreateDocumentRequest request)
        {
            try 
            {
                var dataInsert = new TrBPKB
                {
                    AgreementNumber = request.AgreementNumber,
                    BPKBNo = request.BPKBNo,
                    BranchId = request.BranchId,
                    BPKBDate = request.BPKBDate,
                    FakturNo = request.FakturNo,
                    FakturDate = request.FakturDate,
                    LocationId = request.LocationId,
                    PoliceNo = request.PoliceNo,
                    BPKBDateIn = request.BPKBDateIn,
                    CreatedAt = DateTime.Now,
                    CreatedBy = request.CreatedBy
                };

                _repositoryDocument.Create(dataInsert);
                return Ok(ResponseBuilder.SuccessResponse("success create data document", dataInsert));
            }
            catch (Exception ex) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResponseBuilder.ErrorResponse(500, "Internal Server Error", ex.Message));
            }
        }
    }
}
