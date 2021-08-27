using System;
using System.Collections.Generic;
using LichtDataPack.Interfaces.Entity;

namespace Comment.DAL.Entites
{
    public class CommentaryAttachment:IEntity
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int ImageId { get; set; }
    }
}