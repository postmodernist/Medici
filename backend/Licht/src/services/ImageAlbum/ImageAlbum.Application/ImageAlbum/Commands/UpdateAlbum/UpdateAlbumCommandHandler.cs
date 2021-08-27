using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ImageAlbum.Domain.Entites;
using ImageAlbum.Infrastructure.Interfaces;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.UpdateAlbum
{
    public class UpdateAlbumCommandHandler: IRequestHandler<UpdateAlbumCommand,bool>
    {
        private readonly IImageAlbumService _service;
        private readonly IMapper _mapper;

        public UpdateAlbumCommandHandler(IImageAlbumService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        public async Task<bool> Handle(UpdateAlbumCommand request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<ImageAlbumRecord>(request.ImageAlbumDto);
            return await _service.UpdateAlbum(item);
        }
    }
}