// See https://aka.ms/new-console-template for more information

using OOP1;

GercekMusteri gercekMusteri1 = new GercekMusteri();
gercekMusteri1.Adi = "Halit";
gercekMusteri1.Soyadi = "KINIK";
gercekMusteri1.TcNo = "12345678910";
gercekMusteri1.Id = 1;
gercekMusteri1.MusteriNo = "123";

TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
tuzelMusteri1.SirketAdi = "KINIK HOLDİNG";
tuzelMusteri1.VergiNo = "12345";
tuzelMusteri1.MusteriNo = "321";
tuzelMusteri1.Id = 2;

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(gercekMusteri1);
musteriManager.Ekle(tuzelMusteri1);
