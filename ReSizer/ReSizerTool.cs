using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
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
        private void ReSizerTool_Load(object sender, EventArgs e)
        {
            var vOutPath = AppDomain.CurrentDomain.BaseDirectory;
            var viOSizesFile = vOutPath + @"\SizeJsons\iOSizes.json";
            var vLoadedFileJson = File.ReadAllText(viOSizesFile);
            var viOsSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vLoadedFileJson);
            foreach (var vSingleSize in viOsSizes)
            { chkLstiOS.Items.Add(vSingleSize.ImageName);}
            var vDroidSizesFile = vOutPath + @"\SizeJsons\AndroidSizes.json";
            var vDroidSizeJson = File.ReadAllText(vDroidSizesFile);
            var vDroidSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vDroidSizeJson);
            foreach (var vSingleSize in vDroidSizes)
            { chlLstAndroid.Items.Add(vSingleSize.ImageName); }
            var vUwpSizesFile = vOutPath + @"\SizeJsons\UwpSizes.json";
            var vUwpSizeJson = File.ReadAllText(vUwpSizesFile);
            var vUwpSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vUwpSizeJson);
            foreach (var vSingleSize in vUwpSizes)
            { chkLstUwp.Items.Add(vSingleSize.ImageName); }
        }
        private void btnReSizeCustom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCustomImgPath.Text.Trim()))
            { MessageBox.Show("Please Select the Base Image it's Mandatory"); }
            else if(string.IsNullOrEmpty(txtCustomWidth.Text.Trim()))
            {
                MessageBox.Show("Please Enter Width it's Mandatory");
            }
            else if (string.IsNullOrEmpty(txtCusomHeight.Text.Trim()))
            {
                MessageBox.Show("Please Enter Height it's Mandatory");
            }
             
            var sBaseImagePath = lblCustomImgPath.Text.Trim();
            var vOutPath = AppDomain.CurrentDomain.BaseDirectory;
            var vFileName = Path.GetFileNameWithoutExtension(sBaseImagePath);
            var vImageOutPath = vOutPath + @"\" + vFileName;
            var vNewWidth = Convert.ToInt16(txtCustomWidth.Text.Trim());
            var vNewHeight = Convert.ToInt16(txtCusomHeight.Text.Trim());
            var vNewImageName = vOutPath + "\\" + vFileName + "CustomReSize.png";
            var vNewIMage = Scale(vNewWidth, vNewHeight, sBaseImagePath);
            vNewIMage.Save(vNewImageName);
            lblNewImagePath.Visible = true;
            lblNewImagePathValue.Text = vNewImageName;
            lblNewImagePathValue.Visible = true;
            MessageBox.Show("Custom Re-Sized Image Created");
        }

        private void btnSelectCustomImage_Click(object sender, EventArgs e)
        {
            var vFileOpener = new OpenFileDialog();
            vFileOpener.ShowDialog();
            lblCustomImgPath.Text = vFileOpener.FileName;

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
            var vFileName = Path.GetFileNameWithoutExtension(sBaseImagePath);
            var vImageOutPath = vOutPath + @"\" + vFileName;
            Directory.CreateDirectory(vOutPath);
            var log = false;  var verbose = false;  var quiet = false;
            Logger.Init(vOutPath, log, verbose, quiet);
            Logger.WriteLine("Begin Resizing Images!");
            Logger.WriteVerbose("Writing files to {0}", vOutPath);
            if (chkiOS.Checked)
            {
                var viOSOutputPath = vImageOutPath + @"\iOSImages";
                Directory.CreateDirectory(viOSOutputPath);
                Logger.WriteVerbose("Created directory {0} for iOS Images", viOSOutputPath);

                var viOSizesFile = vOutPath + @"\SizeJsons\iOSizes.json";
                var vLoadedFileJson = File.ReadAllText(viOSizesFile);
                var viOsSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vLoadedFileJson);
                for (int iCount = 0; iCount < chkLstiOS.CheckedItems.Count; iCount++)
                {
                    var vSelSize = chkLstiOS.CheckedItems[iCount].ToString();
                    var vSelectedImage = (from SelImage in viOsSizes where SelImage.ImageName == vSelSize
                                          select SelImage).SingleOrDefault();
                    Logger.WriteVerbose("Creating Image for {0} of iOS Images", vSelSize);
                    var vNewImageName = viOSOutputPath + "\\" + vSelSize + ".png";
                    var vNewIMage = Scale(vSelectedImage.Width, vSelectedImage.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of iOS Images", vSelSize);
                }           
                lbliOSTitle.Visible = true;
                lbliOSValue.Text = viOSOutputPath;
                lbliOSValue.Visible = true;
            }
            if (chkAndroid.Checked)
            {
                var vAndroidPath = vImageOutPath + @"\AndroidImages";
                Directory.CreateDirectory(vAndroidPath);
                Logger.WriteVerbose("Created directory {0} for Android Images", vAndroidPath);

                var vDroidSizesFile = vOutPath + @"\SizeJsons\AndroidSizes.json";
                var vDroidSizeJson = File.ReadAllText(vDroidSizesFile);
                var vDroidSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vDroidSizeJson);
                for (int iCount = 0; iCount < chlLstAndroid.CheckedItems.Count; iCount++)
                {
                    var vSelSize = chlLstAndroid.CheckedItems[iCount].ToString();
                    var vSelectedImage = (from SelImage in vDroidSizes
                                          where SelImage.ImageName == vSelSize
                                          select SelImage).SingleOrDefault();
                    Logger.WriteVerbose("Creating Image for {0} of Android Images", vSelSize);
                    var vNewImageName = vAndroidPath + "\\" + vSelSize + ".png";
                    var vNewIMage = Scale(vSelectedImage.Width, vSelectedImage.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of Android Images", vSelSize);
                }     
                lblAndroid.Visible = true;
                lblAndroidValue.Text = vAndroidPath;
                lblAndroidValue.Visible = true;
            }
            if (chkUwp.Checked)
            {
                var vUwpPath = vImageOutPath + @"\UwpImages";
                Directory.CreateDirectory(vUwpPath);
                Logger.WriteVerbose("Created directory {0} for Uwp Images", vUwpPath);

                var vUwpSizesFile = vOutPath + @"\SizeJsons\UwpSizes.json";
                var vUwpSizeJson = File.ReadAllText(vUwpSizesFile);
                var vUwpSizes = JsonConvert.DeserializeObject<IEnumerable<AppImage>>(vUwpSizeJson);
                for (int iCount = 0; iCount < chkLstUwp.CheckedItems.Count; iCount++)
                {
                    var vSelSize = chkLstUwp.CheckedItems[iCount].ToString();
                    var vSelectedImage = (from SelImage in vUwpSizes
                                          where SelImage.ImageName == vSelSize
                                          select SelImage).SingleOrDefault();
                    Logger.WriteVerbose("Creating Image for {0} of UWP Images", vSelSize);
                    var vNewImageName = vUwpPath + "\\" + vSelSize + ".png";
                    var vNewIMage = Scale(vSelectedImage.Width, vSelectedImage.Height, sBaseImagePath);
                    vNewIMage.Save(vNewImageName);
                    Logger.WriteVerbose("Created Image for {0} of UWP Images", vSelSize);
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
