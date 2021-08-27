using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.AddAlbum
{
    public class AddAlbumCommand:IRequest<bool>
    {
        public AddAlbumCommand(ImageAlbumDto imageAlbumDto)
        {
            ImageAlbumDto = imageAlbumDto;
        }
        public ImageAlbumDto ImageAlbumDto { get; }
    }
}