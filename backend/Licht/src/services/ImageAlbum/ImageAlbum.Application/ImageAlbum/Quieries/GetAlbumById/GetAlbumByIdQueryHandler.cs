using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ImageAlbum.Infrastructure.Interfaces;
using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Quieries.GetAlbumById
{
    public class GetAlbumByIdQueryHandler: IRequestHandler<GetAlbumByIdQuery, ImageAlbumDto>
    {
        private readonly IImageAlbumService _service;
        private readonly IMapper _mapper;

        public GetAlbumByIdQueryHandler(IImageAlbumService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<ImageAlbumDto> Handle(GetAlbumByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _service.GetAlbumById(request.Id);
            return result != null ? _mapper.Map<ImageAlbumDto>(result) : null;
        }
    }
}