using OutSystems.ExternalLibraries.SDK;

namespace ImageEdit;

[OSInterface(Description = "Utilities to crop, identify, and resize images. This library uses ImageMagick for .Net.", IconResourceName = "ImageEdit.resources.ImageMagick_logo.png")]
public interface IImageEdit
{
	[OSAction(Description = "Crops the image", IconResourceName = "ImageEdit.resources.ImageMagick_logo.png")]
	void Crop([OSParameter(DataType = OSDataType.BinaryData, Description = "The source binary content")] byte[] SourceContent, [OSParameter(DataType = OSDataType.Integer, Description = "Offset to the x horizontal axis")] int xOffSet, [OSParameter(DataType = OSDataType.Integer, Description = "Offset to the y vertical axis")] int yOffSet, [OSParameter(DataType = OSDataType.Integer, Description = "Width in number of pixels")] int Width, [OSParameter(DataType = OSDataType.Integer, Description = "Height in number of pixels")] int Height, [OSParameter(DataType = OSDataType.BinaryData, Description = "The processed binary content")] out byte[] NewContent);

	[OSAction(Description = "This action will resize the image maintaining original geometry", IconResourceName = "ImageEdit.resources.ImageMagick_logo.png")]
	void Resize([OSParameter(DataType = OSDataType.BinaryData, Description = "The source binary content")] byte[] SourceContent, [OSParameter(DataType = OSDataType.Integer, Description = "Maximum width allowed")] int MaxWidth, [OSParameter(DataType = OSDataType.Integer, Description = "Maximum height allowed")] int MaxHeight, [OSParameter(DataType = OSDataType.BinaryData, Description = "The processed binary content")] out byte[] NewContent);

	[OSAction(Description = "Verify image width and height", IconResourceName = "ImageEdit.resources.ImageMagick_logo.png")]
	void Identify([OSParameter(DataType = OSDataType.BinaryData, Description = "The source binary content")] byte[] SourceContent, [OSParameter(DataType = OSDataType.Integer, Description = "Image width in pixels")] out int Width, [OSParameter(DataType = OSDataType.Integer, Description = "Image height in pixels")] out int Height);
}
