using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciTakip.Common.Messages
{
    public class Messages
    {
        public static void HataMesaji(string hataMesaji)
        {
            XtraMessageBox.Show(hataMesaji, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void UyariMesaji(string uyariMesaji)
        {
            XtraMessageBox.Show(uyariMesaji, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void BilgiMesaji(string bilgiMesaji)
        {
            XtraMessageBox.Show(bilgiMesaji, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult EvetSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult HayirSeciliEvetHayir(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult EvetSeciliEvetHayirIptal(string mesaj, string baslik)
        {
            return XtraMessageBox.Show(mesaj, baslik, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult SilMesaj(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} silinecektir. Onaylıyor musunuz?", "Silme Onayı");
        }

        public static DialogResult KapanisMesaji()
        {
            return EvetSeciliEvetHayirIptal("Yapılan değişiklikler kayıt edilsin mi?", "Çıkış Onayı");
        }
        public static DialogResult KayitMesaji()
        {
            return EvetSeciliEvetHayir("Yapılan değişiklikler kayıt edilsin mi?", "Kayıt Onayı");
        }

        public static void KartSecmemeUyariMesaji()
        {
            UyariMesaji("Lütfen bir kart seçiniz.");
        }

        public static void MukerrerKayitHataMesaji(string alanAdi)
        {
            HataMesaji($"Girmiş olduğunuz {alanAdi} daha önce kullanılmıştır.");
        }

        public static void HataliVeriMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} alanına geçerli bir değer girmelisiniz.");
        }

        public static DialogResult TabloExportMesaji(string dosyaFormati)
        {
            return EvetSeciliEvetHayir($"İlgili tablo, {dosyaFormati} olarak dışarı aktarılacaktır. Onaylıyor musunuz? ", "Aktarım Onayı");
        }

        public static void KartBulunamadiMesaji(string kartTuru)
        {
            UyariMesaji($"İşlem yapılabilecek {kartTuru} bulunamadı.");
        }

        public static void TabloEksikBilgiMesaji(string tabloAdi)
        {
            UyariMesaji($"{tabloAdi}nda eksik bilgi girişi var. Lütfen kontrol ediniz.");
        }

        public static void IptalHareketSilinemezMesaji()
        {
            HataMesaji("İptal edilen hareketler silinemez.");
        }

        public static DialogResult IptalMesaji(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} iptal edilecektir. Onaylıyor musunuz?", "İptal Onayı");
        }

        public static DialogResult IptalGerialMesaji(string kartAdi)
        {
            return HayirSeciliEvetHayir($"Seçtiğiniz {kartAdi} kartına uygulanan iptal işlemi geri alınacaktır. Onaylıyor musunuz?", "İptal Geri Al Onayı");
        }

        public static void SecimHataMesaji(string alanAdi)
        {
            HataMesaji($"{alanAdi} seçimi yapmalısınız.");
        }

        public static void OdemeBelgesiSilinemezMesaji(bool dahaSonra)
        {
            UyariMesaji(dahaSonra
                ? "Ödeme belgesinin daha sonra işlem görmüş hareketleri var. Ödeme belgesi silinemez."
                : "Ödeme belgesinin işlem görmüş hareketleri var. Ödeme belgesi silinemez.");
        }

        public static DialogResult RaporuTasarimaGonderMesaji()
        {
            return HayirSeciliEvetHayir("Rapor, tasarım görünümünde açılacaktır. Onaylıyor musunuz?", "Onay");
        }

        public static DialogResult RaporuKapatmaMesaji()
        {
            return HayirSeciliEvetHayir("Rapor, kapatılacaktır. Onaylıyor musunuz?", "Onay");
        }

        public static DialogResult EmailGonderimOnayMesaji()
        {
            return HayirSeciliEvetHayir("Kullanıcı şifresi sıfırlanarak, kullanıcı bilgilerini içeren yeni bir mail gönderilecektir. Onaylıyor musunuz?", "E-mail Onayı");
        }
    }
}