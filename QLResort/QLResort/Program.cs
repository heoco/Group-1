using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace QLResort
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");


            bool coHieu = true;
            do
            {
                Application.Run(new frmDangNhap());
                if (!frmDangNhap.coHieu)
                {
                    return;
                }
                switch (frmDangNhap.chucVu.ToLower())
                {
                    case "giám đốc":
                        Application.Run(new frmQuanLy());
                        coHieu = frmQuanLy.coHieu;
                        break;
                    case "giám đốc nhân sự":
                        Application.Run(new frmNhanVien());
                        coHieu = frmNhanVien.coHieu;
                        break;
                    case "quản lý dịch vụ":
                        Application.Run(new frmDichVu());
                        coHieu = frmDichVu.coHieu;
                        break;
                }
            } while (coHieu);
        }
    }
}