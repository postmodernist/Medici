using System.Collections.Generic;
using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Quieries.GetAlbums
{
    public class GetAllAlbumsQuery: IRequest<IEnumerable<ImageAlbumDto>>
    {
        
    }
}