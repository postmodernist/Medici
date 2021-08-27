using LichtDataPack.Dtos.ImageAlbum;
using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.UpdateAlbum
{
    public class UpdateAlbumCommand:IRequest<bool>
    {
        public UpdateAlbumCommand(ImageAlbumDto itemDto)
        {
            ImageAlbumDto = itemDto;
        }
        public ImageAlbumDto ImageAlbumDto { get; }
    }
}