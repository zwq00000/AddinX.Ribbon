namespace AddinX.Core.Contract.Control.GalleryUnsize
{
    public interface IGalleryUnsizeImage
    {
        IGalleryUnsizeItemLabel ImageMso(string name);

        IGalleryUnsizeItemLabel ImagePath(string name);

        IGalleryUnsizeItemLabel NoImage();
    }
}