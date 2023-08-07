using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Abstractions;

namespace Presentation.AltControllers
{
    [Route("api/[controller]")]
    public sealed class CommentsController : ApiController
    {
        public CommentsController(ISender sender) : base(sender)
        {
        }

        [HttpGet]
        [Route(nameof(GetCommentsForEntry))]
        public async Task<IActionResult> GetCommentsForEntry(EntryIdPair entryIdPair)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(nameof(AddComments))]
        public async Task<IActionResult> AddComments(List<Comment> comments)
        {
            throw new NotImplementedException();
        }
    }
}
