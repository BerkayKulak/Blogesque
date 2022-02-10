using System.Threading.Tasks;
using Blogesque.Entities.Dtos;
using Blogesque.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;

namespace Blogesque.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
