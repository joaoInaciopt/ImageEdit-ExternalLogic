using ImageMagick;

namespace ImageEdit;

public class ImageEdit : IImageEdit
{
	public void Crop(byte[] SourceContent, int xOffSet, int yOffSet, int Width, int Height, out byte[] NewContent)
	{
		using MagickImage magickImage = new MagickImage(SourceContent);
		MagickGeometry magickGeometry = new MagickGeometry();
		magickGeometry.Width = (uint)Width;
		magickGeometry.Height = (uint)Height;
		magickGeometry.X = xOffSet;
		magickGeometry.Y = yOffSet;
		magickImage.Crop(magickGeometry);
		NewContent = magickImage.ToByteArray();
	}

	public void Resize(byte[] SourceContent, int MaxWidth, int MaxHeight, out byte[] NewContent)
	{
		using MagickImage magickImage = new MagickImage(SourceContent);
		MagickGeometry geometry = new MagickGeometry((uint)MaxWidth, (uint)MaxHeight)
		{
			IgnoreAspectRatio = false
		};
		magickImage.Resize(geometry);
		NewContent = magickImage.ToByteArray();
	}

	public void Identify(byte[] SourceContent, out int Width, out int Height)
	{
		MagickImageInfo magickImageInfo = new MagickImageInfo(SourceContent);
		Width = (int)magickImageInfo.Width;
		Height = (int)magickImageInfo.Height;
	}
}
