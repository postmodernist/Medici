using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ImageAlbum.Infrastructure.Interfaces;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.DeleteItem
{
    public class DeleteAlbumCommandHandler:IRequestHandler<DeleteAlbumCommand, bool>
    {
        private IImageAlbumService _service;
        private IMapper _mapper;

        public DeleteAlbumCommandHandler(IImageAlbumService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            return await _service.DeleteAlbum(request.Id);
        }
    }
}