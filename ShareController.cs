using Application.Commands;
using Domain.Shared.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstractions;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public sealed class ShareController : ApiController
    {
        public ShareController(ISender sender) : base(sender)
        {
        }

        [HttpGet]
        [Route(nameof(GetShares))]
        public async Task<IActionResult> GetShares(CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route(nameof(GetShares))]
        public async Task<IActionResult> UnlinkShare(ObjectIdAndCreatedByUserIdDTO shareIdPair, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Takes in an array of ShareFolderDTOs, which individually allow sharing of one folder to multiple users
        /// </summary>
        [HttpPost]
        [Route(nameof(ShareFolders))]
        public  Task<IActionResult> ShareFolders(ShareFolderDTO[] incomingShares)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Takes in an array of ShareMediaBTOs, which individually allow sharing of multiple media to multiple users
        /// </summary>
        [HttpPost]
        [Route(nameof(ShareMedias))]
        public Task<IActionResult> ShareMedias(ShareMediasDTO[] incomingShares)
        {
            throw new NotImplementedException();
        }

        public class ShareFolderDTO
        {
            public ShareFolderDTO(Guid[] shareToUserIds, ObjectIdAndCreatedByUserIdDTO folderDetails)
            {
                SharedToUserIds = shareToUserIds;
                FediaDetails = folderDetails;
            }

            public Guid[] SharedToUserIds { get; set; }

            public ObjectIdAndCreatedByUserIdDTO FediaDetails { get; set; }
        }

        public class ShareMediasDTO
        {
            public ShareMediasDTO(Guid[] shareToUserIds, ObjectIdAndCreatedByUserIdDTO[] mediaDetails)
            {
                SharedToUserIds = shareToUserIds;
                MediaDetails = mediaDetails;
            }

            public Guid[] SharedToUserIds { get; set; }

            public ObjectIdAndCreatedByUserIdDTO[] MediaDetails { get; set; }
        }
    }
}
