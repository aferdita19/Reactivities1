using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Photos;
using Microsoft.AspNetCore.Http;

namespace Application.Interfaces
{
    public interface IPhotoAccessor
    {
        public Task<PhotoUploadResult> AddPhoto(IFormFile file);
        public Task<string> DeletePhoto(string publicId);
    }
}