using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.BlobService
{
    public class BlobServiceLocal : IBlobService
    {
        readonly BlobServiceClient _blobServiceClient;
        public BlobServiceLocal(BlobServiceClient blobserviceClient)
        {
            _blobServiceClient = blobserviceClient;
        }
        public string PathToContainer => "http://127.0.0.1:10000/devstoreaccount1/eventsimages/";

        public string SasToken => "?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D";

        public BlobContainerClient GetEventsBlobContainerClient()
        {
            return _blobServiceClient.GetBlobContainerClient("eventsimages");
        }
    }
}
