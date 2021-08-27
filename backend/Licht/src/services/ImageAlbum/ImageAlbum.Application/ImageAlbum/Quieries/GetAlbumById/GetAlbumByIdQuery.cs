using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Quieries.GetAlbumById
{
    public class GetAlbumByIdQuery: IRequest<ImageAlbumDto>
    {
        public GetAlbumByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }
}