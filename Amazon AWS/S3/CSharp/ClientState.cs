using System;

using Amazon.S3;

namespace AWSS3Storage
{
    public class ClientState
    {
        AmazonS3Client client;
        DateTime startTime;

        public AmazonS3Client Client { get; set; }

        public DateTime Start { get; set; }
            
    }
}
