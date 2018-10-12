using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace INFOIBV
{
    public partial class INFOIBV : Form
    {
        private int currentImageWidth;
        private int currentImageHeight;
        private Bitmap InputImage;
        private Bitmap OutputImage;

        public INFOIBV()
        {
            InitializeComponent();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            histoIn.Series.Clear();
           if (openImageDialog.ShowDialog() == DialogResult.OK)             // Open File Dialog
            {
                string file = openImageDialog.FileName;                     // Get the file name
                imageFileName.Text = file;                                  // Show file name
                if (InputImage != null) InputImage.Dispose();               // Reset image
                InputImage = new Bitmap(file);                              // Create new Bitmap from file
                if (InputImage.Size.Height <= 0 || InputImage.Size.Width <= 0 ||
                    InputImage.Size.Height > 512 || InputImage.Size.Width > 512) // Dimension check
                    MessageBox.Show("Error in image dimensions (have to be > 0 and <= 512)");
                else
                {
                    pictureBox1.Image = (Image)InputImage;                    // Display input image
                    Tuple<int[], int[], int[]> result = calculateHistogramFromImage(InputImage);
                    int[] rArray = result.Item1;
                    int[] gArray = result.Item2;
                    int[] bArray = result.Item3;

                    Series rSeries = histoIn.Series.Add("RedHistogram");
                    rSeries.BorderWidth = 0;
                    rSeries.Color = Color.IndianRed;
                    Series gSeries = histoIn.Series.Add("GreenHistogram");
                    gSeries.BorderWidth = 0;
                    gSeries.Color = Color.LightSeaGreen;
                    Series bSeries = histoIn.Series.Add("BlueHistogram");
                    bSeries.BorderWidth = 0;
                    bSeries.Color = Color.DeepSkyBlue;

                    int max = 0;

                    for (int i = 0; i < 256; i++)
                    {
                        rSeries.Points.Add(new DataPoint(i, rArray[i]));
                        gSeries.Points.Add(new DataPoint(i, gArray[i]));
                        bSeries.Points.Add(new DataPoint(i, bArray[i]));
                        if (max < rArray[i])
                            max = rArray[i];
                        if (max < gArray[i])
                            max = gArray[i];
                        if (max < bArray[i])
                            max = bArray[i];

                    }
                    histoIn.ChartAreas[0].AxisX.Minimum = 0;
                    histoIn.ChartAreas[0].AxisX.Maximum = 255;

                    histoIn.ChartAreas[0].AxisY.Minimum = 0;
                    histoIn.ChartAreas[0].AxisY.Maximum = max;
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (InputImage == null) return;                                 // Get out if no input image
            if (OutputImage != null) OutputImage.Dispose();                 // Reset output image
            currentImageWidth = InputImage.Size.Width;                      //Saves the image width in a global variable, for usage later
            currentImageHeight = InputImage.Size.Height;                    ////Saves the image height in a global variable, for usage later
            OutputImage = new Bitmap(InputImage.Size.Width, InputImage.Size.Height); // Create new output image
            Color[,] Image = new Color[InputImage.Size.Width, InputImage.Size.Height]; // Create array to speed-up operations (Bitmap functions are very slow)
            
            // Copy input Bitmap to array            
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Image[x, y] = InputImage.GetPixel(x, y);                // Set pixel color in array at (x,y)
                }
            }

            // Setup progress bar
            progressBar.Visible = true;
            progressBar.Minimum = 1;
            progressBar.Maximum = InputImage.Size.Width * InputImage.Size.Height;
            progressBar.Value = 1;
            progressBar.Step = 1;

            //Create Textbox List for easy Iteration
            List<TextBox> boxes = new List<TextBox>();
            boxes.Add(matrix1);
            boxes.Add(matrix2);
            boxes.Add(matrix3);
            boxes.Add(matrix4);
            boxes.Add(matrix5);
            boxes.Add(matrix6);
            boxes.Add(matrix7);
            boxes.Add(matrix8);
            boxes.Add(matrix9);
            boxes.Add(matrix10);
            boxes.Add(matrix11);
            boxes.Add(matrix12);
            boxes.Add(matrix13);
            boxes.Add(matrix14);
            boxes.Add(matrix15);
            boxes.Add(matrix16);
            boxes.Add(matrix17);
            boxes.Add(matrix18);
            boxes.Add(matrix19);
            boxes.Add(matrix20);
            boxes.Add(matrix21);
            boxes.Add(matrix22);
            boxes.Add(matrix23);
            boxes.Add(matrix24);
            boxes.Add(matrix25);
            
            //Reads the combobox to decide which conversion should be done on the input image.
            switch (comboBox1.Text)
            {
                case "erosion":
                    break;
                case "dilation":
                    break;
                case "opening":
                    break;
                case "closing":
                    break;
                case "complement":
                    Image = conversionComplement(Image);
                    break;
                case "min":
                    break;
                case "max":
                    break;
                case "value counting":
                    break;
                case "boundary trace":
                    break;
                default:
                    Console.WriteLine("Nothing matched");
                    break;
            }


            // Copy array to output Bitmap
            for (int x = 0; x < Image.GetLength(0); x++)
            {
                for (int y = 0; y < Image.GetLength(1); y++)
                {
                    OutputImage.SetPixel(x, y, Image[x, y]);               // Set the pixel color at coordinate (x,y)
                }
            }

            pictureBox2.Image = (Image)OutputImage;                         // Display output image

            histoOut.Series.Clear();
            Tuple<int[], int[], int[]> result = calculateHistogramFromImage(OutputImage); //Calculates histogram for the output image.
            int[] rArray = result.Item1;
            int[] gArray = result.Item2;
            int[] bArray = result.Item3;

            Series rSeries = histoOut.Series.Add("RedHistogram");
            rSeries.Color = Color.IndianRed;
            Series gSeries = histoOut.Series.Add("GreenHistogram");
            gSeries.Color = Color.LightSeaGreen;
            Series bSeries = histoOut.Series.Add("BlueHistogram");
            bSeries.Color = Color.DeepSkyBlue;

            int max = 0;

            for (int i = 0; i < 256; i++)
            {
                rSeries.Points.Add(new DataPoint(i, rArray[i]));
                gSeries.Points.Add(new DataPoint(i, gArray[i]));
                bSeries.Points.Add(new DataPoint(i, bArray[i]));
                if (max < rArray[i])
                    max = rArray[i];
                if (max < gArray[i])
                    max = gArray[i];
                if (max < bArray[i])
                    max = bArray[i];

            }
            histoOut.ChartAreas[0].AxisX.Minimum = 0;
            histoOut.ChartAreas[0].AxisX.Maximum = 255;

            histoOut.ChartAreas[0].AxisY.Minimum = 0;
            histoOut.ChartAreas[0].AxisY.Maximum = histoIn.ChartAreas[0].AxisY.Maximum;

            progressBar.Visible = false;                                    // Hide progress bar
        }

        //Takes a greyscale image as input and returns its' complementary image
        private Color[,] conversionComplement(Color[,] image)
        {
            return conversionNegative(image); //It's actually the same thing, whouzies
        }

        private Color[,] conversionMin(Color[,] image1, Color[,] image2)
        {
            if (image1.GetLength(0) != image2.GetLength(0) || image1.GetLength(1) != image2.GetLength(1))  //images should be of the same size
                return null;
            Color[,] output = new Color[image1.GetLength(0), image1.GetLength(1)];

            for (int x = 0; x < image1.GetLength(0); x++)
            {
                for (int y = 0; y < image1.GetLength(1); y++)
                {
                    Color pixelColor1 = image1[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color pixelColor2 = image2[x, y];
                    Color updatedColor = Color.FromArgb(Math.Min(pixelColor1.R, pixelColor2.R),
                        Math.Min(pixelColor1.G, pixelColor2.G), Math.Min(pixelColor1.B, pixelColor2.B)); //Min valued image
                    output[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return output;
        }

        private Color[,]converstionMax(Color[,] image1, Color[,] image2)
        {
            if (image1.GetLength(0) != image2.GetLength(0) || image1.GetLength(1) != image2.GetLength(1))  //images should be of the same size
                return null;
            Color[,] output = new Color[image1.GetLength(0), image1.GetLength(1)];

            for (int x = 0; x < image1.GetLength(0); x++)
            {
                for (int y = 0; y < image1.GetLength(1); y++)
                {
                    Color pixelColor1 = image1[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color pixelColor2 = image2[x, y];
                    Color updatedColor = Color.FromArgb(Math.Max(pixelColor1.R, pixelColor2.R),
                        Math.Max(pixelColor1.G, pixelColor2.G), Math.Max(pixelColor1.B, pixelColor2.B)); //Max valued image
                    output[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return output;
        }

        //This function takes an image and outputs an image with the edge strength per pixel.
        private Color[,] conversionEdgeDetection(Color[,] image)
        {

            double[,] sobelFilterX = {{-1, 0, 1}, { -2, 0, 2 }, { -1, 0, 1 } };
            double[,] sobelFilterY = {{ -1, -2, -1 }, {0, 0, 0 }, { 1, 2, 1 } };
            int xBorder = (sobelFilterX.Length - 1)/ 2;
            int yBorder = (sobelFilterY.Length - 1)/ 2;
            Color[,] imageSobelX = applyFilterToImage(image, sobelFilterX);
            Color[,] imageSobelY = applyFilterToImage(image, sobelFilterY);

            progressBar.Value = 1;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    double newColor;
                    if (isPointerOutOfBounds(x,y,xBorder,yBorder))
                    {
                        newColor = 128.0;
                    }
                    else
                    {
                        int dx = imageSobelX[x, y].R;
                        int dy = imageSobelY[x, y].R;

                        newColor = Math.Sqrt(dx ^ 2 + dy ^ 2);
                        if ((y + x) % 100 == 0)
                        {
                            Console.WriteLine("value = " + newColor);
                        }
                        if (newColor > 255)
                        {
                            newColor = 255;
                        }
                        else if (newColor < 0)
                        {
                            newColor = 0;
                        }
                    }
                   
                    int convertedNewColor = Convert.ToInt16(newColor);
                    Color updatedColor = Color.FromArgb(convertedNewColor, convertedNewColor, convertedNewColor);
                    newImage[x,y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return newImage;
        }

        //This function takes an image and a threshold, anything below the threshold is mapped to 0 (black) anything above to 255 (white)
        private Color[,] conversionThreshold(Color[,] image, int threshold)
        {
            image = conversionGrayscale(image); // Convert image to grayscale, even though it already is a grayscale image.
            progressBar.Value = 1;
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    int newColor = pixelColor.R > threshold ? 255 : 0;      //Uses the red color to calculate the threshold, since all channels are the same.
                    Color updatedColor = Color.FromArgb(newColor, newColor, newColor); // Pixel is either 255 or 0, depending on the threshold.
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }

        //This function takes an image and outputs a grayscale image.
        private Color[,] conversionGrayscale(Color[,] image)
        {
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    int convertedRedColor = (int)(pixelColor.R * 0.299);
                    int convertedGreenColor = (int)(pixelColor.G * 0.587);
                    int convertedBlueColor = (int)(pixelColor.B * 0.114);
                    int Y = convertedRedColor + convertedGreenColor + convertedBlueColor;
                    if (Y < 0)
                    {
                        Y = 0;
                    }

                    if (Y > 255)
                    {
                        Y = 255;
                    }

                    Color updatedColor = Color.FromArgb(Y, Y, Y);
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }

        //This function takes an image and outputs a negative image
        private Color[,] conversionNegative(Color[,] image)
        {
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    Color updatedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B); // Negative image
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return image;
        }

        //This function takes an image and a percentage, and adjust the contrast based on the percentage given.
        private Color[,] conversionContrastAdjustment(Color[,] image, double percentage)
        {
            int lowR, lowG, lowB, highR, highG, highB;
            int[] histogram_red = new int[256];
            int[] histogram_green = new int[256];
            int[] histogram_blue = new int[256];
            int amount_of_pixels = InputImage.Size.Width * InputImage.Size.Height;
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    histogram_red[pixelColor.R]++;
                    histogram_green[pixelColor.G]++;
                    histogram_blue[pixelColor.B]++;
                }

            }

            int percentile = (int) (percentage * amount_of_pixels);
            Console.Out.WriteLine("the percentile is set at: " + percentile);

            lowR = getColorAtPercentileLowFromHistogram(histogram_red, percentile);
            highR = getColorAtPercentileHighFromHistogram(histogram_red, percentile);

            lowG = getColorAtPercentileLowFromHistogram(histogram_blue, percentile);
            highG = getColorAtPercentileHighFromHistogram(histogram_blue, percentile);

            lowB = getColorAtPercentileLowFromHistogram(histogram_blue, percentile);
            highB = getColorAtPercentileHighFromHistogram(histogram_blue, percentile);

            double kR = 255 / (highR - lowR);
            double kG = 255 / (highG - lowG);
            double kB = 255 / (highB - lowB);


            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = image[x, y];
                    int updatedRed = (int) (kR * (pixelColor.R - lowR));
                    int updatedGreen = (int) (kG * (pixelColor.G - lowG));
                    int updatedBlue = (int) (kG * (pixelColor.B - lowB));
                    //Clamping
                    if (updatedRed > 255) updatedRed = 255;
                    if (updatedGreen > 255) updatedGreen = 255;
                    if (updatedBlue > 255) updatedBlue = 255;
                    if (updatedRed < 0) updatedRed = 0;
                    if (updatedGreen < 0) updatedGreen = 0;
                    if (updatedBlue < 0) updatedBlue = 0;

                    Color updatedColor = Color.FromArgb(updatedRed, updatedGreen, updatedBlue);
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }
            }
            return image;
        }

        //This function takes an image, a gaussian and a kernel size. And applies a gaussian filter to the image and returns it
        private Color[,] conversionGaussian(Color[,] image, double sigma, int size)
        {
            double[,] gaussianFilter = createGaussianFilter(sigma, size);
            return applyFilterToImage(image, gaussianFilter);
        }

        //This function takes an Image, and reads the input from the user. And applies the filter to the image and returns it.
        private Color[,] conversionLinear(Color[,] image, List<TextBox> boxes)
        {
            double[,] linearFilter = createLinearFilter(boxes);
            return applyFilterToImage(image, linearFilter);
        }
        
        //This function takes an image and a kernel size. And applies a median filter to the image and returns it.
        private Color[,] conversionMedian(Color[,] image, int size)
        {
            int xBorder = (size - 1) / 2;
            int yBorder = (size - 1) / 2;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    int newColor;
                    if (isPointerOutOfBounds(x, y, xBorder, yBorder)) // If pointer is out of bounds, set value to grey. Border handling.
                    {
                        newColor = 128;
                    }

                    else
                    {
                        int[] pixelVector = new int[size * size];
                        int pixelVectorIndex = 0;
                        for (int xFilter = -xBorder; xFilter <= xBorder; xFilter++)
                        {
                            for (int yFilter = -yBorder; yFilter <= yBorder; yFilter++)
                            {
                                Color filterColor = image[x - xFilter, y - yFilter];
                                pixelVector[pixelVectorIndex] = filterColor.R;
                                pixelVectorIndex++;
                            }
                        }
                        Array.Sort(pixelVector); //Sorts the pixels
                        newColor = pixelVector[(pixelVector.Length + 1) / 2]; // Takes the middle pixel value
                    }
                    Color updatedColor = Color.FromArgb(newColor,newColor,newColor);
                    newImage[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return newImage;
        }

        //This function creates a gaussian filter based on sigma en kernel size. Returns the filter.
        private double[,] createGaussianFilter(double sigma, int size)
        {
            double[,] gaussianFilter = new double[size, size];
            double r;
            double s = 2.0 * sigma * sigma;
            double sum = 0.0;             //This is used later for normalization
            int halfSize = (size - 1) / 2;

            for (int x = -halfSize; x <= halfSize; x++)
            {
                for (int y = -halfSize; y <= halfSize; y++)
                {
                    r = Math.Sqrt(x * x + y * y);
                    int xIndice = x + halfSize;
                    int yIndice = y + halfSize;
                    double resultGaussian = (Math.Exp(-(r * r) / s)) / (Math.PI * s);
                    gaussianFilter[xIndice, yIndice] = resultGaussian;
                    sum += resultGaussian;
                }
            }

            //Normalization
            for (int i = 0; i < size; ++i)
            { 
                for (int j = 0; j < size; ++j)
                {
                    gaussianFilter[i, j] /= sum;
                }
            }
            return gaussianFilter;
        }

        //This function creates a linear filter based on the input from the user. Returns the filter
        private double[,] createLinearFilter(List<TextBox> boxes)
        {
            int i = 0, j = 0;
            double sum = 0;
            int kernel = 5;
            double[,] linearFilter = new double[kernel, kernel];
            foreach(TextBox box in boxes)
            {
                linearFilter[i, j] = Convert.ToDouble(box.Text);
                sum += linearFilter[i, j];
                if (i < kernel - 1)
                {
                    i++;
                } 
                else
                {
                    i = 0;
                    j++;
                }
            }

            for (int x = 0; x < kernel; ++x)
            {
                for (int y = 0; y < kernel; ++y)
                {
                    linearFilter[x, y] /= sum;
                }
            }
            return linearFilter;
        }

        //This function takes an image and a filter, and applies the filter. Returns the image.
        private Color[,] applyFilterToImage(Color[,] image, double[,] filter)
        {
            progressBar.Value = 1;
            int halfSize = (filter.GetLength(0) - 1) / 2;
            int xBorder = (filter.GetLength(0) - 1) / 2;
            int yBorder = (filter.GetLength(1) - 1) / 2;
            Color[,] newImage = new Color[InputImage.Size.Width, InputImage.Size.Height];
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    double updatedRed = 0.0;
                    double updatedGreen = 0.0;
                    double updatedBlue = 0.0;
                    if (isPointerOutOfBounds(x,y,xBorder,yBorder)) // If pointer is out of bounds, set value to grey. Border handling.
                    {
                        updatedBlue = 128;
                        updatedGreen = 128;
                        updatedRed = 128;

                    }
                    else
                    {   //Apply filter to image
                        for (int xFilter = -xBorder; xFilter <= xBorder; xFilter++)
                        {
                            for (int yFilter = -yBorder; yFilter <= yBorder; yFilter++)
                            {
                                Color filterColor = image[x - xFilter, y - yFilter];
                                updatedRed += filter[(xFilter + xBorder), (yFilter + yBorder)] * filterColor.R;
                                updatedGreen += filter[(xFilter + xBorder), (yFilter + yBorder)] * filterColor.G;
                                updatedBlue += filter[(xFilter + xBorder), (yFilter + yBorder)] * filterColor.B;
                            }
                        }

                        //Clamping
                        if (updatedRed > 255) updatedRed = 255;
                        if (updatedGreen > 255) updatedGreen = 255;
                        if (updatedBlue > 255) updatedBlue = 255;
                        if (updatedRed < 0) updatedRed = 0;
                        if (updatedGreen < 0) updatedGreen = 0;
                        if (updatedBlue < 0) updatedBlue = 0;

                    }
                    Color updatedColor = Color.FromArgb(Convert.ToInt32(updatedRed), Convert.ToInt32(updatedGreen), Convert.ToInt32(updatedBlue));
                    newImage[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();                              // Increment progress bar
                }

            }
            return newImage;
        }

        private Color[,] histogramEqualization(Color[,] image, Tuple<int[], int[], int[]> histogram )
        {
            double[] probabilityHistogram = new double[256];
            int[] greyHistogram = histogram.Item1;
            double amountOfPixels = InputImage.Width * InputImage.Height;
            for (int i = 0; i < 256; i++)
            {
                probabilityHistogram[i] = (greyHistogram[i] / amountOfPixels);

            }

            double[] cumulativeProbabilityHistogram = new double[256];
            cumulativeProbabilityHistogram[0] = probabilityHistogram[0];
            for (int i = 1; i < 256; i++)
            {
                cumulativeProbabilityHistogram[i] = cumulativeProbabilityHistogram[i - 1] + probabilityHistogram[i];
            }
            Console.Out.WriteLine("Cumulative is= " + cumulativeProbabilityHistogram[255]);
            int[] transferTable = new int[256];
            for (int i = 0; i < 256; i++)
            {
                transferTable[i] = (int) Math.Floor(cumulativeProbabilityHistogram[i] * 255);
            }

            for (int x = 0; x < InputImage.Width; x++)
            {
                for (int y = 0; y < InputImage.Height; y++)
                {
                    Color pixelColor = image[x, y];                         // Get the pixel color at coordinate (x,y)
                    int newColorValue = transferTable[pixelColor.R];
                    Color updatedColor = Color.FromArgb(newColorValue, newColorValue, newColorValue); // Negative image
                    image[x, y] = updatedColor;                             // Set the new pixel color at coordinate (x,y)
                    progressBar.PerformStep();
                }
            }

            return image;
        }

        //This function takes a histogram array, and a percentage. And calculates the pixel color if % of the pixels is removed. This function goes from low to high.
        private int getColorAtPercentileLowFromHistogram(int[] histogram_array, int percentile)
        {
            for (int i = 0; i < 255; i++)
            {
                percentile = percentile - histogram_array[i];
                if (percentile < 0)
                {
                    return i;
                }
            }

            return 255;
        }

        //This function takes a histogram array, and a percentage. And calculates the pixel color if % of the pixels is removed. This function goes from high to low.
        private int getColorAtPercentileHighFromHistogram(int[] histogram_array, int percentile)
        {
            for (int i = 255; 0 < i; i--)
            {
                percentile = percentile - histogram_array[i];
                if (percentile < 0)
                {
                    return i;
                }
            }

            return 0;
        }

        //This function takes the pointer, and the border definitions. Returns True if the pointer is out of bounds.
        private Boolean isPointerOutOfBounds(int x, int y, int xBorder, int yBorder)
        {
            if (x < xBorder || y < yBorder || y >= InputImage.Size.Height - yBorder ||
                x >= InputImage.Size.Width - xBorder)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This functions takes an image, and returns a tuple with histogram arrays
        private Tuple<int[], int[], int[]> calculateHistogramFromImage(Bitmap image)
        {
            Color[,] Image = new Color[image.Size.Width, image.Size.Height]; // Create array to speed-up operations (Bitmap functions are very slow)
            // Copy input Bitmap to array            
            for (int x = 0; x < image.Size.Width; x++)
            {
                for (int y = 0; y < image.Size.Height; y++)
                {
                    Image[x, y] = image.GetPixel(x, y);                // Set pixel color in array at (x,y)
                }
            }
            int[] histogramRed = new int[256];
            int[] histogramGreen = new int[256];
            int[] histogramBlue = new int[256];
            for (int x = 0; x < InputImage.Size.Width; x++)
            {
                for (int y = 0; y < InputImage.Size.Height; y++)
                {
                    Color pixelColor = Image[x, y];                         // Get the pixel color at coordinate (x,y)
                    histogramRed[pixelColor.R]++;
                    histogramGreen[pixelColor.G]++;
                    histogramBlue[pixelColor.B]++;
                }

            }
            return Tuple.Create(histogramRed, histogramGreen, histogramBlue);
        }

        //This function saves the image
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (OutputImage == null) return;                                // Get out if no output image
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
                OutputImage.Save(saveImageDialog.FileName);                 // Save the output image
        }

        //This function shows optional input if the combobox options requires that.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("erosion") || comboBox1.Text.Equals("dilation") ||
                comboBox1.Text.Equals("opening") || comboBox1.Text.Equals("closing"))
            {
                isBinaryButton.Visible = true;
            }

            else
            {
                isBinaryButton.Visible = false;
            }

        }
    }
}
