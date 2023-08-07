using Domain.Shared.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstractions;

namespace Presentation.AltControllers
{
    [Route("api/[controller]")]
    public sealed class FolderController : ApiController
    {
        public FolderController(ISender sender) : base(sender)
        {
        }

        [HttpGet]
        [Route(nameof(GetFoldersForUser))]
        public async Task<IActionResult> GetCurrentUserFolders(CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        // Used for refreshing. Do we need this?
        [HttpGet]
        [Route(nameof(GetFolder))]
        public async Task<IActionResult> GetFolder(EntryIdPair entryIdPair, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(nameof(CreateFolders))]
        public async Task<IActionResult> CreateFolders([FromBody] List<FolderDTO> folders, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route(nameof(UpdateFolders))]
        public async Task<IActionResult> UpdateFolders([FromBody] List<UpdateFolderInfo> updateFolderInfos, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route(nameof(DeleteFolders))]
        public async Task<IActionResult> DeleteFolders([FromBody] List<EntryIdPair> folders, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route(nameof(AddToMyNightOuts))]
        public async Task<IActionResult> AddToMyNightOuts([FromBody] List<EntryIdPair> folders, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public class UpdateFolderInfo
        {
            // List of modified properties? Updated DTO?
        }

    }
}
