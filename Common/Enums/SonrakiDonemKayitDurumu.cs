using System.ComponentModel;

namespace OgrenciTakip.Common.Enums
{
    public enum SonrakiDonemKayitDurumu : byte
    {
        [Description("Kayıt Yenileyecek")]
        KayitYenileyecek = 1,
        [Description("Şartlı Kayıt Yenileyecek")]
        SartliKayitYenileyecek = 2,
        [Description("Kayıt Yenileyemeyecek")]
        KayitYenilemeyecek = 3,
        [Description("Kurum Tarafından Kaydı Yenilenyemeyecek")]
        KurumTarafindanKaydiYenilenmeyecek = 4,
    }
}