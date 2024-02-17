using System;
using System.Drawing;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            // Load the original image
            Bitmap originalBitmap = new Bitmap(file);

            // Invert the colors of the image
            InvertColors(originalBitmap);

            // Save the inverted image
            string outputFileName = GetOutputFileName(file);
            originalBitmap.Save(outputFileName);
            Console.WriteLine($"Inverse image saved: {outputFileName}");

            // Dispose the original image to release resources
            originalBitmap.Dispose();
        }
    }

    private static void InvertColors(Bitmap bitmap)
    {
        // Loop through all pixels of the image
        for (int y = 0; y < bitmap.Height; y++)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                // Get the color of the current pixel
                Color pixelColor = bitmap.GetPixel(x, y);

                // Invert the color by subtracting each component from 255
                Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                // Set the inverted color to the current pixel
                bitmap.SetPixel(x, y, invertedColor);
            }
        }
    }

    private static string GetOutputFileName(string originalFileName)
    {
        // Extract the directory, file name without extension, and extension
        string directory = System.IO.Path.GetDirectoryName(originalFileName);
        string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(originalFileName);
        string fileExtension = System.IO.Path.GetExtension(originalFileName);

        // Generate the output file name with "_inverse" appended before the extension
        string outputFileName = $"{fileNameWithoutExtension}_inverse{fileExtension}";

        // Combine directory and output file name to get the full output file path
        return System.IO.Path.Combine(directory, outputFileName);
    }
}
