using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.BlobService
{
    public class BlobServiceProd : IBlobService
    {
        readonly BlobServiceClient _blobServiceClient;
        public BlobServiceProd(BlobServiceClient blobserviceClient)
        {
            _blobServiceClient = blobserviceClient;
        }
        public string PathToContainer => "https://diplomastorage.blob.core.windows.net/images/";

        public string SasToken => "sp=racwdli&st=2022-06-13T19:26:02Z&se=2022-09-14T03:26:02Z&sv=2021-06-08&sr=c&sig=Ys5PgJLTyx0sXiDCXHuflwYaANpP0x8In5oj0ukgIUA%3D";

        public BlobContainerClient GetEventsBlobContainerClient()
        {
            return _blobServiceClient.GetBlobContainerClient("images");
        }
    }
}
