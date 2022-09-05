using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.BlobService
{
    public interface IBlobService
    {
        BlobContainerClient GetEventsBlobContainerClient();
        string PathToContainer { get; }
        string SasToken { get; }
    }
}
