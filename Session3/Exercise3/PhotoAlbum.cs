using System;
namespace Exercise3
{
    public class PhotoAlbum
    {
        
        int p;
        public PhotoAlbum()
        {
            
            this.p=16;
        }
        public PhotoAlbum(int P)
        {
            this.p=P;
        }
        

        public int GetNumberOfPages()
        {
            return p;
        }
    }
}