using MediatR;

namespace ImageAlbum.Application.ImageAlbum.Commands.DeleteItem
{
    public class DeleteAlbumCommand:IRequest<bool>
    {
        public DeleteAlbumCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}