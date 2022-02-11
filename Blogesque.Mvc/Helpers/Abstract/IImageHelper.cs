using System.Threading.Tasks;
using Blogesque.Entities.ComplexTypes;
using Blogesque.Entities.Dtos;
using Blogesque.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;

namespace Blogesque.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
