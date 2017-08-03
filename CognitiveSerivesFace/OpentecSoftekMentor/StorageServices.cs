using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.ServiceRuntime;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;
using System.Configuration;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.WebKey;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using System.Web.Configuration;


namespace OpentecSoftekMentor
{
    public class StorageServices
    {
        //String connectionString;
        //Method to reference blob storage
        public CloudBlobContainer GetCloudBlobContainer()
        {
            
            string connString = "DefaultEndpointsProtocol=https;AccountName=imagenestest;AccountKey=kpQZigzHv8YzBJwWStbPHbcQcntcIjeHKY4PeFjM4gFT7SCP0PE7FzhL945aXMeUDwFZegphkOSUfJvYbfU96g==;EndpointSuffix=core.windows.net";
            string destContainer = "faces";
 
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connString);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer blobContainer = blobClient.GetContainerReference(destContainer);
            if (blobContainer.CreateIfNotExists())
            {
                blobContainer.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
        });

            }
            return blobContainer;

        }

      


    }
}