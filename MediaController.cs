using Domain.Shared.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstractions;

namespace Presentation.AltControllers
{
    [Route("api/[controller]")]
    public sealed class MediaController : ApiController
    {
        public MediaController(ISender sender) : base(sender)
        {
        }

        [HttpGet]
        [Route(nameof(GetMediaEntriesForEntry))]
        public async Task<IActionResult> GetMediaEntriesForEntry([FromBody] EntryIdPair parentIdPair, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(nameof(CreateMediaEntries))]
        public async Task<IActionResult> CreateMediaEntries([FromBody] List<CreateMediaEntryInfo> createMediaEntryInfos, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route(nameof(UpdateMediaEntries))]
        public async Task<IActionResult> UpdateMediaEntries([FromBody] List<UpdateMediaEntryInfo> updateMediaEntryInfos, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route(nameof(DeleteMediaEntries))]
        public async Task<IActionResult> DeleteMediaEntries([FromBody] List<DeleteMediaEntryInfo> deleteMediaEntriesInfos, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route(nameof(TransferMediaEntries))]
        public async Task<IActionResult> TransferMediaEntries([FromBody] List<TransferMediaEntryInfo> transferMediaEntriesInfos, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public class CreateMediaEntryInfo
        {
            public MediaDTO Media { get; set; }
            public EntryIdPair ParentEntryIdPair { get; set; } // Do we need EntryIdPair or just the parent entry id?
        }

        public class UpdateMediaEntryInfo
        {
            // List of modified properties? Updated DTO?
        }

        public class DeleteMediaEntryInfo
        {
            public EntryIdPair MediaEntryIdPair { get; set; }
            public EntryIdPair ParentEntryIdPair { get; set; } // Do we need EntryIdPair or just the parent entry id?
        }

        public class TransferMediaEntryInfo
        {
            public EntryIdPair MediaEntryIdPair { get; set; }
            public EntryIdPair OldParentEntryIdPair { get; set; } // Do we need EntryIdPair or just the old parent entry id?
            public EntryIdPair NewParentEntryIdPair { get; set; } // Do we need EntryIdPair or just the old parent entry id?
        }
    }
}
