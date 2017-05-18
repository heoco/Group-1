using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLResort
{
    public class XuLyAnh
    {
        public byte[] ImageToArrayByte(Image img)
        {
            MemoryStream MmStr = new MemoryStream();
            byte[] Mpic = new byte[0];
            try
            {
                img.Save(MmStr, ImageFormat.Png);
                return Mpic = MmStr.ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Image ArrayByteToImage(byte[] Mybytes)
        {
            MemoryStream Mstr = new MemoryStream(Mybytes);
            return Image.FromStream(Mstr);
        }
    }
}
