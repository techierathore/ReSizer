using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ReSizer
{
    public partial class ReSizerTool : Form
    {
        public ReSizerTool()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            var vFileOpener = new OpenFileDialog();
            vFileOpener.ShowDialog();
            lblBaseImagePath.Text = vFileOpener.FileName;   
        }
        private void TestImageCreation(string sBaseImagePath) {
            var vOutPath = AppDomain.CurrentDomain.BaseDirectory;
            var log = false; var verbose = false; var quiet = false;
            Logger.Init(vOutPath, log, verbose, quiet);
            Logger.WriteLine("Begin Resizing Images!");
            Logger.WriteVerbose("Writing files to {0}", vOutPath);
            var viOSOutputPath = vOutPath + "\\iOSImages";
            Directory.CreateDirectory(viOSOutputPath);
            Logger.WriteVerbose("Created directory {0} for iOS Images", viOSOutputPath);
            var vImageName = "58X58";
            var vWidth = 58;var vHeight=58;
            var vNewImageName = viOSOutputPath + "\\" + vImageName + ".png";          
            var vNewIMage = Scale(vWidth, vHeight, sBaseImagePath);
            vNewIMage.Save(vNewImageName);
            MessageBox.Show("Image Created");
        }

        private void CreateImages(string sBaseImagePath)
        {
            var vOutPath = AppDomain.CurrentDomain.BaseDirectory;
            var log = false;  var verbose = false;  var quiet = false;
            Logger.Init(vOutPath, log, verbose, quiet);
            Logger.WriteLine("Begin Resizing Images!");
            Logger.WriteVerbose("Writing files to {0}", vOutPath);
            if (chkiOS.Checked)
            {
                var viOSOutputPath = vOutPath + "\\iOSImages";
                Directory.CreateDirectory(viOSOutputPath);
                Logger.WriteVerbose("Created directory {0} for iOS Images", viOSOutputPath);

                var viOSizesFile = vOutPath + "\\SizeJsons\\iOSizes.json";
                var vLoadedFileJson = File.ReadAllText(viOSizesFile);
                var viOsSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vLoadedFileJson);
                foreach(var vSingleSize in viOsSizes)
                {
                    var vImageName = vSingleSize.ImageName;
                    Logger.WriteVerbose("Creating Image for {0} of iOS Images", vImageName);                    
                    var vNewImageName = viOSOutputPath + "\\" + vImageName + ".png";
                    var vNewIMage = Scale(vSingleSize.Width, vSingleSize.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of iOS Images", vImageName);
                }
                lbliOSTitle.Visible = true;
                lbliOSValue.Text = viOSOutputPath;
                lbliOSValue.Visible = true;
            }
            if (chkAndroid.Checked)
            {
                var vAndroidPath = vOutPath + "\\AndroidImages";
                Directory.CreateDirectory(vAndroidPath);
                Logger.WriteVerbose("Created directory {0} for Android Images", vAndroidPath);

                var vDroidSizesFile = vOutPath + "\\SizeJsons\\AndroidSizes.json";
                var vDroidSizeJson = File.ReadAllText(vDroidSizesFile);
                var vDroidSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vDroidSizeJson);
                foreach (var vSingleSize in vDroidSizes)
                {
                    var vImageName = vSingleSize.ImageName;
                    Logger.WriteVerbose("Creating Image for {0} of Android Images", vImageName);
                    var vNewImageName = vAndroidPath + "\\" + vImageName + ".png";
                    var vNewIMage = Scale(vSingleSize.Width, vSingleSize.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of Android Images", vImageName);
                }
                lblAndroid.Visible = true;
                lblAndroidValue.Text = vAndroidPath;
                lblAndroidValue.Visible = true;
            }
            if (chkUwp.Checked)
            {
                var vUwpPath = vOutPath + "\\UwpImages";
                Directory.CreateDirectory(vUwpPath);
                Logger.WriteVerbose("Created directory {0} for Uwp Images", vUwpPath);

                var vUwpSizesFile = vOutPath + "\\SizeJsons\\UwpSizes.json";
                var vUwpSizeJson = File.ReadAllText(vUwpSizesFile);
                var vUwpSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vUwpSizeJson);
                foreach (var vSingleSize in vUwpSizes)
                {
                    var vImageName = vSingleSize.ImageName;
                    Logger.WriteVerbose("Creating Image for {0} of Android Images", vImageName);
                    var vNewImageName = vUwpPath + "\\" + vImageName + ".png";
                    var vNewIMage = Scale(vSingleSize.Width, vSingleSize.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of Android Images", vImageName);
                }
                lblUWPTitle.Visible = true;
                lblUWPValues.Text = vUwpPath;
                lblUWPValues.Visible = true;
            }
        }

        public Image Scale(int newWidth, int newHeight, string stPhotoPath)
        {
            using (var imgPhoto = Image.FromFile(stPhotoPath))
            {
                var sourceWidth = imgPhoto.Width;
                var sourceHeight = imgPhoto.Height;

                const int sourceX = 0;
                const int sourceY = 0;
                int destinationX = 0, destinationY = 0;

                float nPercent;
                var nPercentW = newWidth / (float)sourceWidth;
                var nPercentH = newHeight / (float)sourceHeight;
                if (nPercentH < nPercentW)
                {
                    nPercent = nPercentH;
                    destinationX = Convert.ToInt16((newWidth -
                                                    sourceWidth * nPercent) / 2);
                }
                else
                {
                    nPercent = nPercentW;
                    destinationY = Convert.ToInt16((newHeight -
                                                    sourceHeight * nPercent) / 2);
                }

                var destinationWidth = (int)(sourceWidth * nPercent);
                var destinationHeight = (int)(sourceHeight * nPercent);


                var bmPhoto = new Bitmap(newWidth, newHeight);
                bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                    imgPhoto.VerticalResolution);

                using (var grPhoto = Graphics.FromImage(bmPhoto))
                {
                    grPhoto.SmoothingMode = SmoothingMode.HighQuality;
                    grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    grPhoto.DrawImage(imgPhoto,
                        new Rectangle(destinationX, destinationY, destinationWidth, destinationHeight),
                        new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                        GraphicsUnit.Pixel);
                }
                return bmPhoto;
            }
        }


        private static string SerializeToXML<T>(T obj)
        {
            var serializer = new XmlSerializer(obj.GetType());
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
        private static T DeserializeFromXML<T>(string xml)
        {
            T result;
            var ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (!chkAndroid.Checked && !chkiOS.Checked && !chkUwp.Checked)
            {
                MessageBox.Show("Please Select the Mobile OS");
            }
            else
            {
                CreateImages(lblBaseImagePath.Text.Trim());
                MessageBox.Show("All Images Created");
            }
        }
    }

    [Serializable]
    public class AppImage
    {
        public string ImageName { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public string Scale { get; set; }
    }
 }
