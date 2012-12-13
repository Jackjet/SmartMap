using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Imaging;

namespace SmartMapTest
{
    [TestClass]
    public class LayerAreaTest
    {
        Smart.Map.LayerArea layerArea = new Smart.Map.LayerArea();

        [TestMethod]
        public void Download()
        {
            layerArea.Start = new Smart.Map.Vectory2D() { X = 10, Y = 10 };
            layerArea.End = new Smart.Map.Vectory2D() { X = 20, Y = 20 };
            layerArea.FragmentSize = new Smart.Map.Size() { Width = 128, Height = 128 };
            layerArea.UrlTemplate = "{POINTX}_{POINTY}";
            layerArea.Download();

            Assert.AreEqual(layerArea.MapFragments.Count, 0);
        }
        [TestMethod]
        public void Compose()
        {
            layerArea.Start = new Smart.Map.Vectory2D() { X = 797, Y = 255 };
            layerArea.End = new Smart.Map.Vectory2D() { X = 800, Y = 260 };
            layerArea.FragmentSize = new Smart.Map.Size() { Width = 256, Height = 256 };
            layerArea.UrlTemplate = "http://p0.go2map.com/seamless1/0/174/717/3/1/{POINTX}_{POINTY}.png";

            layerArea.Download();
            layerArea.Compose("c:\\001.Png", ImageFormat.Png);
        }
    }
}
