using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogesque.Entities.Dtos;
using Blogesque.Shared.Utilities.Results.Abstract;

namespace Blogesque.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); // alper@altu.dev
        IResult SendContactEmail(EmailSendDto emailSendDto); // alper@altu.dev info@programmersblog.com iletisim@programmersblog.com
    }
}
