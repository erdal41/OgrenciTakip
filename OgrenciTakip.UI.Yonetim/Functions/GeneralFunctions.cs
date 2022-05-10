using DevExpress.XtraSplashScreen;
using OgrenciTakip.Common.Messages;
using OgrenciTakip.UI.Yonetim.Forms.GenelForms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciTakip.UI.Yonetim.Functions
{
    class GeneralFunctions
    {
        //Burada yni kurum eklerken yeni database ekleneceği için eklerken geçen her işlemi yapıyoruz. Yani ekleme sırasında gelecek olan bekleme işleminde ekrana çıkacak olan formdaki başlık ve açıklamayı girmemiz gerek değişkenler. Ayrıca ekleme onayı için mesaj kutusu ve son olarak database oluşturma sonunda olacak bilgi mesajı.
        protected internal static bool CreateDatabase<TContext>(string splashCaption, string splashDescription, string onayMesaji, string bilgiMesaji) where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (con.Database.Exists()) return true;
                if (Messages.EvetSeciliEvetHayir(onayMesaji, "Onay") != DialogResult.Yes) return false;

                var splashForm = new SplashScreenManager(Form.ActiveForm, typeof(BekleForm), true, true);
                SplashBaslat(splashForm);

                splashForm.SetWaitFormCaption(splashCaption);
                splashForm.SetWaitFormDescription(splashDescription);

                try
                {
                    if (con.Database.CreateIfNotExists())
                    {
                        SplashDurdur(splashForm);
                        Messages.BilgiMesaji(bilgiMesaji);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    SplashDurdur(splashForm);

                    switch (ex.Number)
                    {
                        case 5170:
                            Messages.HataMesaji("Veritabanı dosyalarının yükleneceği klasörde aynı isimde dosya zaten var. Lütfen kontrol ediniz.\n\n" + ex.Message);
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }

        private static void SplashBaslat(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
                manager.ShowWaitForm();
            }
            else
            {
                manager.ShowWaitForm();
            }
        }

        private static void SplashDurdur(SplashScreenManager manager)
        {
            if (manager.IsSplashFormVisible)
            {
                manager.CloseWaitForm();
            }
        }

        protected internal static bool DeleteDatabase<TContext>() where TContext : DbContext, new()
        {
            using (var con = new TContext())
            {
                con.Database.Connection.ConnectionString = Bll.Functions.GeneralFunctions.GetConnectionString();

                if (Messages.HayirSeciliEvetHayir("Seçtiğiniz kurum ve kurum işlemlerinin tamamını içeren kurum veritabanı(Veritabanı dosyaları dahil) tamamen silenecektir. onaylıyor musunuz?", "Sil Onayı") != DialogResult.Yes) return false;
                if (Messages.HayirSeciliEvetHayir("Bu işlem geri alınamaz. Tekrar onaylıyor musunuz?", "Sil Onayı") != DialogResult.Yes) return false;

                try
                {
                    if (con.Database.Delete())
                    {
                        Messages.BilgiMesaji("Kurum silme işlemi başarılı bir şekilde tamamlanmıştır.");
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 3702:
                            Messages.HataMesaji("Veritabanı kullanımda olduğu için silinemedi. Lütfen veritabanına yapılan tüm bağlantıları sonlandırdıktan sonra tekrar deneyiniz.");
                            break;
                        default:
                            Messages.HataMesaji(ex.Message);
                            break;
                    }
                }

                return false;
            }
        }
    }
}