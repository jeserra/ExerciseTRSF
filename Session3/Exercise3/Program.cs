using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PhotoAlbum photo=new PhotoAlbum();
            PhotoAlbum photo1=new PhotoAlbum(24);
            BigPhotoAlbum photo2= new BigPhotoAlbum(64);

            Console.WriteLine(photo.GetNumberOfPages());
            Console.WriteLine(photo1.GetNumberOfPages());
            Console.WriteLine(photo2.GetNumberOfPages());
        }
    }
}
