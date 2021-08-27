using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ImageAlbum.Infrastructure.Interfaces;
using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Quieries.GetAlbums
{
    public class GetAllAlbumsQueryHandler: IRequestHandler<GetAllAlbumsQuery, IEnumerable<ImageAlbumDto>>
    {
        private readonly IImageAlbumService _service;
        private readonly IMapper _mapper;

        public GetAllAlbumsQueryHandler(IImageAlbumService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ImageAlbumDto>> Handle(GetAllAlbumsQuery request,
            CancellationToken cancellationToken)
        {
            var result = await _service.GetAllAlbums();
            return _mapper.Map<IEnumerable<ImageAlbumDto>>(result);
        }
    }
}