using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;
using PhotoSharingApplication.Data;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingInitializer : DropCreateDatabaseAlways<PhotoSharingContext>

    {
        //This gets a byte array for a file at the path specified
        //The path is relative to the route of the web site
        //It is used to seed images
        private byte[] getFileBytes(string path)
        {
            FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
            byte[] fileBytes;
            using (BinaryReader br = new BinaryReader(fileOnDisk))
            {
                fileBytes = br.ReadBytes((int)fileOnDisk.Length);
            }
            return fileBytes;
        }


        /*public Seed(PhotoSharingContext context)
        {
            var photos = new List<Photo>
            {
                new Photo {
                Title = "Test Photo",
                Description = "Your Description",
                UserName = "NaokiSato",
                PhotoFile = getFileBytes
                ("\\Images\\flower.jpg"),
                ImageMimeType =
                "image/jpeg",
                CreatedDate = DateTime.Today
                }
            };
            photos.ForEach(s => context.Photos.Add(s));
            context.SaveChanges();


        }*/

    }
}