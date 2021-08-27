using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ImageAlbum.Domain.Entites;
using ImageAlbum.Infrastructure.Interfaces;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.AddAlbum
{
    public class AddAlbumCommandHandler: IRequestHandler<AddAlbumCommand, bool>
    {
        private readonly IImageAlbumService _service;
        private readonly IMapper _mapper;

        public AddAlbumCommandHandler(IImageAlbumService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<bool> Handle(AddAlbumCommand request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<ImageAlbumRecord>(request.ImageAlbumDto);
            return await _service.AddAlbum(item);
        }
    }
}