//   ------------------------------------ 3. HAFTA ------------------------------------

//using System;
//class Program1
//{
//    static void Main(string[] args)
//    {
//        int a = 2;
//        int b = 3;
//        int c = 6;
//        int d = 1;

//        Console.WriteLine("(a<b)&&(c<d) --->" + ((a < b) && (c < d)));
//        Console.WriteLine("(a<b)||(c<d) --->" + ((a < b) || (c < d)));
//        Console.WriteLine("!(a<b) --->" + (!(a < b)));
//        Console.WriteLine("(a<b)&(c<d) --->" + ((a < b) & (c < d)));
//        Console.WriteLine("(a<b)|(c<d) --->" + ((a < b) | (c < d)));
//        Console.WriteLine("(a<b)^(c<d) --->" + ((a < b) ^ (c < d)));
//    }
//}


//using System;
//class Program2
//{
//    static void Main(string[] args)
//    {
//        int a = 2;
//        int b = 3;
//        int c = 6;

//        Console.WriteLine("(a & b) ---> " + (a & b));
//        Console.WriteLine("(a | b) ---> " + (a | b));
//        Console.WriteLine("(a ^ b) ---> " + (a ^ b));
//        Console.WriteLine("( ~a ) ---> " + (~a));
//        Console.WriteLine("( ~b ) ---> " + (~b));
//        Console.WriteLine("( ~c ) ---> " + (~c));
//    }
//}


//using System;
//class Program3
//{
//    static void Main(string[] args)
//    {
//        int i = 0;
//        while (i < 5)
//        {
//            Console.WriteLine("i= " + i);
//            i++;
//        }
//    }
//}


//using System;
//class Program4
//{
//    static void Main(string[] args)
//    {
//        int i = 0;
//        do
//        {
//            Console.WriteLine("i= " + i);
//            i++;
//        }
//        while (i < 0);
//    }
//}


//using System;
//class Program5
//{
//    static void Main(string[] args)
//    {
//        int secim;

//        do
//        {
//            Console.WriteLine("İşlemler\n********************");
//            Console.WriteLine("1) Toplama");
//            Console.WriteLine("2) Çıkarma");
//            Console.WriteLine("3) Çarpma");
//            Console.WriteLine("4) Bölme");
//            Console.WriteLine("0) Çıkış\n");
//            Console.Write("İşleminizi seçiniz = ");
//            secim = Convert.ToInt32(Console.ReadLine());
//            switch (secim)
//            {
//                case 1:
//                    Console.WriteLine("Toplama seçildi");
//                    break;
//                case 2:
//                    Console.WriteLine("Çıkarma seçildi");
//                    break;
//                case 3:
//                    Console.WriteLine("Çarpma seçildi");
//                    break;
//                case 4:
//                    Console.WriteLine("Bölme seçildi");
//                    break;
//                case 0:
//                    Console.WriteLine("Çıkış seçildi");
//                    break;
//                default:
//                    Console.WriteLine("Yanlış seçim");
//                    break;

//            }

//        } while (secim != 0);

//    }
//}


//using System;
//class Program6
//{
//    static void Main(string[] args)
//    {
//        for (int i = 0, j = 0; i < 20; i++, j++)
//        {
//            i *= j;
//            Console.WriteLine("i= " + i + " j= " + j);
//        }
//    }
//}


//using System;
//class Program7
//{
//    static void Main(string[] args)
//    {
//        string s;

//        for (s = Console.ReadLine(); s != "Çıkış"; s = Console.ReadLine())
//            Console.WriteLine(s);
//    }
//}


//using System;
//class Program8
//{
//    static void Main(string[] args)
//    {
//        int i = 0, a, n;

//        Console.Write("Bir sayı girin : ");
//        n = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Artım miktarı : ");
//        a = Convert.ToInt32(Console.ReadLine());

//        for (; i < n;)
//        {
//            Console.Write("{0} ", i);
//            i += a;
//        }
//    }
//}


//using System;
//class Program9
//{
//    static void Main(string[] args)
//    {
//        int k, t, toplam, n1, n2;

//        Console.WriteLine("Aralık başlangıcı = ");
//        n1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Aralık sonu = ");
//        n2 = Convert.ToInt32(Console.ReadLine());

//        if (n1 <= n2)
//        {
//            for (k = n1; k <= n2; k++)
//            {
//                toplam = 0;
//                for (t = 1; t <= k; t++)
//                {
//                    if (k % t == 0)
//                    {
//                        toplam += t;
//                    }
//                }
//                if (toplam == k + 1)
//                {
//                    Console.WriteLine(k);
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Geçerli bir aralık giriniz...");
//        }

//    }
//}


//using System;
//class Program10
//{
//    static void Main(string[] args)
//    {
//        int sayi;

//        Console.WriteLine("Bir tam sayı giriniz = ");
//        sayi = Convert.ToInt32(Console.ReadLine());

//        for (int bit = 3; bit >= 1; bit--)
//        {
//            Console.Write("{0}", (sayi >> bit - 1) & 1);
//        }
//        Console.WriteLine();
//    }
//}


//   ------------------------------------ 4. HAFTA ------------------------------------

//using System;
//class Program1
//{
//    static void Main(string[] args)
//    {
//        Random r = new Random();
//        int[] dizi = new int[20];
//        char[] chr = new char[20];

//        for (int i = 0; i < 20; i++)
//        {
//            dizi[i] = r.Next(1, 51);
//            chr[i] = (char)r.Next(20, 126);
//        }
//        for (int i = 0; i < 20; i++)
//        {
//            Console.WriteLine("{0,2}. değer {1,2} -> ", i, dizi[i]);
//            for (int j = 0; j < dizi[i]; j++)
//            {
//                Console.WriteLine(chr[i]);
//            }
//            Console.WriteLine();
//        }
//    }
//}


//using System;
//class Program2
//{
//    static void Main(string[] args)
//    {
//        int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                Console.WriteLine(dizi[i, j]);
//            }
//        }
//    }
//}


//using System;
//class Program3
//{
//    static void Main(string[] args)
//    {
//        int[][] dizi = new int[3][];

//        dizi[0] = new int[] { 1, 2 };
//        dizi[1] = new int[] { 3, 4, 5, 6, 7 };
//        dizi[2] = new int[] { 8, 9, 0 };

//        foreach (int[] boyut in dizi)
//        {
//            foreach (int eleman in boyut)
//            {
//                Console.Write("{0,3}", eleman);
//            }
//            Console.WriteLine();
//        }
//    }
//}


//   ------------------------------------ 5. HAFTA ------------------------------------

//using System;
//class Metotlar
//{
//    static float Fonksiyon(float x)
//    {
//        return 2 * x + 5;
//    }
//    static float TersFonksiyon(float x)
//    {
//        return (x - 5) / 2;
//    }
//    static void Main()
//    {
//        float x = 10;
//        Console.WriteLine(Fonksiyon(x));
//        Console.WriteLine(TersFonksiyon(x));
//        Console.WriteLine(Fonksiyon(TersFonksiyon(x)));
//    }
//}


//using System;
//class Ogrenci
//{
//    public ulong OgrenciNo;
//    public string Ad;
//    public string Soyad;
//    public string Bolum;
//    public byte Sinif;
//}
//class Program
//{
//    static void Main()
//    {
//        Ogrenci ogr = new Ogrenci();

//        Console.WriteLine(ogr.OgrenciNo);
//        Console.WriteLine(ogr.Ad);
//        Console.WriteLine(ogr.Soyad);
//        Console.WriteLine(ogr.Bolum);
//        Console.WriteLine(ogr.Sinif);
//    }
//}


//using System;
//class KrediHesabi
//{
//    public ulong HesapNo;
//}
//class AnaSinif
//{
//    static void Main()
//    {
//        KrediHesabi hesap1 = new KrediHesabi();
//        KrediHesabi hesap2 = new KrediHesabi();

//        hesap1.HesapNo = 12345;
//        hesap2.HesapNo = 98765;

//        Console.WriteLine(hesap1.HesapNo);
//        Console.WriteLine(hesap2.HesapNo);
//    }
//}


//using System;
//class SinifIsmi
//{
//    public int ozellik1 = 55;
//    public string ozellik2 = "deneme";
//    public float ozellik3 = 123.78F;

//    public int metot1(int a, int b)
//    {
//        return a + b;
//    }
//    public void metot2(string a)
//    {
//        Console.WriteLine(a);
//    }
//}
//class EsasSinif
//{
//    static void Main()
//    {
//        SinifIsmi nesne = new SinifIsmi();
//        Console.WriteLine(nesne.ozellik1);
//        Console.WriteLine(nesne.ozellik2);
//        Console.WriteLine(nesne.ozellik3);
//        Console.WriteLine(nesne.metot1(2, 5));
//        nesne.metot2("deneme");
//    }
//}


//using System;
//class Dortgen
//{
//    public int En;
//    public int Boy;
//    public int Alan()
//    {
//        int Alan = En * Boy;
//        return Alan;
//    }
//    public void EnBoyBelirle(int en, int boy)
//    {
//        En = en;
//        Boy = boy;
//    }
//    public void Yaz()
//    {
//        Console.WriteLine("******************");
//        Console.WriteLine("En:{0,5}", En);
//        Console.WriteLine("Boy:{0,5}", Boy);
//        Console.WriteLine("Alan:{0,5}", Alan());
//        Console.WriteLine("******************");
//    }
//}
//class AnaSinif
//{
//    static void Main()
//    {
//        Dortgen d1 = new Dortgen();
//        d1.EnBoyBelirle(20, 50);
//        d1.Yaz();
//        Dortgen d2 = new Dortgen();
//        d2.EnBoyBelirle(25, 12);
//        d2.Yaz();
//    }
//}


//using System;
//class Topla
//{
//    public int tpl;

//    public Topla(int toplam)
//    {
//        tpl = toplam;
//    }
//    public int Toplama
//    {
//        get
//        {
//            return tpl;
//        }
//        set
//        {
//            tpl = value + tpl;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Topla ekle = new Topla(0);
//        Console.WriteLine("Başlangıç değeri ->" + ekle.Toplama);
//        for (int i = 1; i < 100; i++)
//        {
//            ekle.Toplama = i;
//        }
//        Console.WriteLine("Sayıların toplamı : " + ekle.Toplama);
//    }
//}


//using System;
//class Toplama
//{
//    public int X;
//    public int Y;

//    public Toplama(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//    public Toplama() : this(-1, -1)
//    {
//    }
//    public Toplama(int x) : this(x, -1)
//    {
//    }
//    public int Islem()
//    {
//        return X + Y;
//    }
//    public void Yaz()
//    {
//        Console.WriteLine("X = {0}", X);
//        Console.WriteLine("Y = {0}", Y);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Toplama t = new Toplama(5, 6);
//        t.Yaz();
//        Toplama y = new Toplama();
//        y.Yaz();
//        Toplama u = new Toplama(7);
//        u.Yaz();
//    }
//}


//   ------------------------------------ 6. HAFTA ------------------------------------

//using System;
//class Zaman
//{
//    public int Saat;
//    public int Dakika;
//    public int Saniye;
//    public Zaman(int saat, int dakika, int saniye)
//    {
//        Dakika = dakika + saniye / 60;
//        Saniye = saniye % 60;
//        Saat = saat + Dakika / 60;
//        Dakika = Dakika % 60;
//    }
//    public static Zaman operator +(Zaman a, Zaman b)
//    {
//        int ToplamSaniye = a.Saniye + b.Saniye;
//        int ToplamDakika = a.Dakika + b.Dakika;
//        int ToplamSaat = a.Saat + b.Saat;
//        return new Zaman(ToplamSaat, ToplamDakika, ToplamSaniye);
//    }
//}
//class AnaProgram
//{
//    static void Main()
//    {
//        Zaman zaman1 = new Zaman(5, 59, 60);
//        Zaman zaman2 = new Zaman(1, 0, 120);
//        Zaman zaman3 = zaman1 + zaman2;

//        Console.WriteLine("{0}.{1}.{2}", zaman3.Saat, zaman3.Dakika, zaman3.Saniye);
//    }
//}


//using System;
//class indexleyici
//{
//    public double rakam;
//    public double this[double index]
//    {
//        get
//        {
//            return Math.Pow(index, 2);
//        }
//        set
//        {
//            rakam = value;
//        }
//    }
//}
//class indexleyicistart
//{
//    static void Main()
//    {
//        indexleyici i = new indexleyici();
//        Console.WriteLine("i[3.4]={0}", i[3.4]);
//        i[10] = 10;
//        Console.WriteLine(i.rakam);
//        i[10] = 15;
//        Console.WriteLine(i.rakam);
//        Console.WriteLine("i[10]={0}", i[10]);
//    }
//}


//using System;
//class Yapilar
//{
//    struct Ogrenci
//    {
//        public int Numara;
//        public string Ad;
//        public string Soyad;
//    }
//    static void Main()
//    {
//        Ogrenci ogr1 = new Ogrenci();

//        ogr1.Numara = 123;
//        ogr1.Ad = "Ali";
//        ogr1.Soyad = "Türk";

//        Ogrenci ogr2 = new Ogrenci();

//        ogr2.Numara = 456;

//        Console.WriteLine("{0} {1} {2}", ogr1.Numara, ogr1.Ad, ogr1.Soyad);
//        Console.WriteLine("{0} {1} {2}", ogr2.Numara, ogr2.Ad, ogr2.Soyad);
//    }
//}


//using System;
//struct üniversite
//{
//    public string fakulte;
//    public string bolum;
//    public string Ogr_gor;
//    public üniversite(string a, string b, string c)
//    {
//        fakulte = a;
//        bolum = b;
//        Ogr_gor = c;
//    }
//}
//class structornek
//{
//    public static void Main()
//    {
//        üniversite k1 = new üniversite("Teknoloji Fakültesi", "Yazılım Mühendisliği", "2.sınıf");

//        üniversite k2;
//        Console.WriteLine(k1.fakulte);
//        Console.WriteLine(k1.bolum);
//        Console.WriteLine(k1.Ogr_gor);
//        k2.fakulte = "Tıp Fakultesi";
//        Console.WriteLine();
//        Console.WriteLine(k2.fakulte);
//    }
//}


//using System;
//enum GUNLER : byte
//{
//    PAZARTESİ,
//    SALI,
//    ÇARŞAMBA,
//    PERŞEMBE,
//    CUMA,
//    CUMARTESİ,
//    PAZAR
//}
//class Numaralandirma
//{
//    static void Main()
//    {
//        Console.WriteLine((int)GUNLER.PAZARTESİ);
//        Console.WriteLine((int)GUNLER.PAZAR);
//    }
//}


//using System;
//enum GUNLER : byte
//{
//    PAZARTESİ,
//    SALI,
//    ÇARŞAMBA,
//    PERŞEMBE,
//    CUMA,
//    CUMARTESİ,
//    PAZAR
//}
//class Numaralandirma
//{
//    static void Main()
//    {
//        string[] sabitler = Enum.GetNames(typeof(GUNLER));
//        foreach (string s in sabitler)
//            Console.WriteLine(s);
//    }
//}


//   ------------------------------------ 7. HAFTA ------------------------------------

//using System;
//namespace PrgDil3
//{
//    class Deneme
//    {
//        public int a;
//        public int b;

//        public Deneme(int a, int b)
//        {
//            this.a = a;
//            this.b = b;
//        }
//        public static int Topla(int x, int y)
//        {
//            return x + y;
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        PrgDil3.Deneme d = new PrgDil3.Deneme(1, 2);
//        Console.WriteLine(d.a);
//        Console.WriteLine(PrgDil3.Deneme.Topla(2, 3));
//    }
//}


//using System;
//namespace isimalan1
//{
//    class Deneme
//    {
//        public Deneme()
//        {
//            Console.WriteLine("Deneme 1");
//        }
//    }
//}
//namespace isimalan2
//{
//    class Deneme
//    {
//        public Deneme()
//        {
//            Console.WriteLine("Deneme 2");
//        }
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        isimalan1.Deneme d1 = new isimalan1.Deneme();
//        isimalan2.Deneme d2 = new isimalan2.Deneme();
//    }
//}


//   ------------------------------------ 8. HAFTA ------------------------------------

//using System;
//class Program
//{
//    static void Main()
//    {
//        if (BitConverter.IsLittleEndian)
//            Console.WriteLine("Little Endian");
//        else
//            Console.WriteLine("Big Endian");

//        int a = 46513;
//        byte[] b = BitConverter.GetBytes(a);

//        foreach (byte x in b)
//            Console.WriteLine(x);
//    }
//}


//using System;
//class Program
//{
//    static void Main()
//    {
//        byte[] kaynak = { 1, 2, 0, 1 };
//        short[] hedef = new short[5];

//        Buffer.BlockCopy(kaynak, 0, hedef, 0, 4);

//        foreach (short s in hedef)
//            Console.Write(s + " ");

//        Console.WriteLine("\n" + Buffer.GetByte(hedef, 0));
//        Buffer.SetByte(hedef, 5, 3);

//        foreach (short s in hedef)
//            Console.Write(s + " ");

//        Console.WriteLine();
//        Console.WriteLine(Buffer.ByteLength(kaynak));
//        Console.WriteLine(Buffer.ByteLength(hedef));
//    }
//}


//   ------------------------------------ 9. HAFTA ------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApplication9
//{
//    class oto
//    {
//        protected double boy = 5;
//        protected double agirlik = 800;
//        protected string renk = "Sarı";

//        public void goster()
//        {
//            Console.WriteLine("Boy=" + boy);
//            Console.WriteLine("Ağırlık=" + agirlik);
//            Console.WriteLine("Renk=" + renk);
//        }
//    }
//    class model1 : oto
//    {
//        public string tur;
//        public int silindir_sayisi;
//        public int subap_sayisi;
//        public int tork;
//        public int guc;

//        public void ozellikyaz()
//        {
//            Console.WriteLine("Tür=" + tur);
//            Console.WriteLine("Boy=" + boy);
//            Console.WriteLine("Ağırlık=" + agirlik);
//            Console.WriteLine("Renk=" + renk);
//            Console.WriteLine("Silindir sayısı=" + silindir_sayisi);
//            Console.WriteLine("Subap sayısı=" + subap_sayisi);
//            Console.WriteLine("Tork=" + tork);
//            Console.WriteLine("Güç=" + guc);
//        }
//    }
//    class model2 : oto
//    {
//        public double model2_boy
//        {
//            get
//            {
//                return boy;
//            }
//            set
//            {
//                boy = value;
//            }
//        }
//        public double model2_agirlik
//        {
//            get
//            {
//                return agirlik;
//            }
//            set
//            {
//                agirlik = value;
//            }
//        }
//        public string model2_renk
//        {
//            get
//            {
//                return renk;
//            }
//            set
//            {
//                renk = value;
//            }
//        }
//        public string tur = "Hatchback";
//        public int silindir_sayisi = 8;
//        public int subap_sayisi = 16;
//        public int tork = 300;
//        public int guc = 210;

//        public void ozellikyaz()
//        {
//            Console.WriteLine("Tür=" + tur);
//            Console.WriteLine("Boy=" + model2_boy);
//            Console.WriteLine("Ağırlık=" + model2_agirlik);
//            Console.WriteLine("Renk=" + model2_renk);
//            Console.WriteLine("Silindir sayısı=" + silindir_sayisi);
//            Console.WriteLine("Subap sayısı=" + subap_sayisi);
//            Console.WriteLine("Tork=" + tork);
//            Console.WriteLine("Güç=" + guc);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            model1 oto1 = new model1();
//            model2 oto2 = new model2();

//            oto1.tur = "Sedan";
//            oto1.silindir_sayisi = 4;
//            oto1.subap_sayisi = 8;
//            oto1.guc = 75;
//            oto1.tork = 100;
//            oto1.ozellikyaz();
//            Console.WriteLine("**************************************");
//            oto2.model2_boy = 6;
//            oto2.model2_agirlik = 900;
//            oto2.model2_renk = "Kırmızı";
//            oto2.ozellikyaz();
//            Console.WriteLine("**************************************");
//            oto2.goster();
//            Console.WriteLine("**************************************");
//            oto1.goster();
//        }
//    }
//}


//using System;
//class Kedi
//{
//    protected int ayakSayisi = 4;
//    public void yakalaAv()
//    {
//        Console.WriteLine("Kedi sinifi Av yakaladi");
//    }
//}
//class Kaplan : Kedi
//{
//    public Kaplan()
//    {
//        Console.WriteLine("Ayak Sayisi = " + ayakSayisi);
//    }
//}
//class deneme
//{
//    public static void Main(string[] args)
//    {
//        Kedi kd = new Kedi();
//        kd.yakalaAv();
//        Kaplan kp = new Kaplan();
//        kp.yakalaAv();
//    }
//}


//using System;
//public class Hayvan
//{
//    protected String a = "Hayvan.a";
//    String b = "Hayvan.b";
//    private String c = "Hayvan.c";
//    public String d = "Hayvan.d";
//}
//public class Kedi : Hayvan
//{
//    public Kedi()
//    {
//        Console.WriteLine("Kedi olusturuluyor");
//        Console.WriteLine(a);
//        //Console.WriteLine(b); Hata erişemez
//        //Console.WriteLine(c); Hata erişemez
//        Console.WriteLine(d);
//    }
//}
//class deneme
//{
//    public static void Main(string[] args)
//    {
//        Kedi k = new Kedi();
//    }
//}


//using System;
//class X
//{
//    protected int a;
//    public X(int a)
//    {
//        Console.WriteLine("X " + a);
//        this.a = a;
//    }
//    public int A
//    {
//        get
//        {
//            Console.WriteLine("X Sınıfı=" + a);
//            return a;
//        }
//    }
//}
//class Y : X
//{
//    protected int b;
//    public Y(int a) : base(a)
//    {
//        Console.WriteLine("Y " + a);
//        this.b = a;
//    }
//    new public int A
//    {
//        get
//        {
//            Console.WriteLine("Y sınıfı=" + b);
//            return b;
//        }
//    }
//}
//class tarih
//{
//    static void Main()
//    {
//        Y y = new Y(5);
//        X yy = new X(6);
//        int deneme = y.A;
//        int deneme2 = yy.A;
//    }
//}


//using System;
//abstract class Ogr_not
//{
//    public int vize;
//    public int final;
//    public Ogr_not(int v, int f)
//    {
//        vize = v;
//        final = f;
//    }
//}

//class ögr : Ogr_not
//{
//    public string str;
//    public ögr(string ad, int vize, int final) : base(vize, final)
//    {
//        str = ad;
//    }
//    public void ad_göster()
//    {
//        Console.WriteLine("Öğrenci Adı : " + str);
//        Console.WriteLine("Vize notu:" + vize + "\n" + "Final notu:" + final);
//    }
//}
//class Ana_sınıf
//{
//    static void Main()
//    {
//        ögr d = new ögr("Erkan TANYILDIZI", 77, 98);
//        d.ad_göster();
//    }
//}


//using System;
//class A
//{
//    public void Metot1()
//    {
//        Metot2();
//    }
//    public void Metot2()
//    {
//        Console.WriteLine("A sınıfı");
//    }
//}
//class B : A
//{
//    public new void Metot2()
//    {
//        Console.WriteLine("B sınıfı");
//    }
//}
//class Ana
//{
//    static void Main()
//    {
//        B b = new B();
//        b.Metot1();
//    }
//}


//using System;
//class A
//{
//    public void Metot1()
//    {
//        Metot2();
//    }
//    public void Metot2()
//    {
//        Console.WriteLine("A sınıfı");
//    }
//}
//class B : A
//{
//    public new void Metot1()
//    {
//        Metot2();
//    }
//    public new void Metot2()
//    {
//        Console.WriteLine("B sınıfı");
//    }
//}
//class Ana
//{
//    static void Main()
//    {
//        B b = new B();
//        b.Metot1();
//    }
//}


//using System;
//class A
//{
//    public void Metot1()
//    {
//        Metot2();
//    }
//    virtual public void Metot2()
//    {
//        Console.WriteLine("A sınıfı");
//    }
//}
//class B : A
//{
//    override public void Metot2()
//    {
//        Console.WriteLine("B sınıfı");
//    }
//}
//class Ana
//{
//    static void Main()
//    {
//        B b = new B();
//        b.Metot1();
//    }
//}


//using System;
//class A
//{
//    public int OzellikA;
//    public A(int a)
//    {
//        OzellikA = a;
//    }
//}
//class B : A
//{
//    public int OzellikB
//;
//    public B(int b, int a) : base(a)
//    {
//        OzellikB = b;
//    }
//}
//class C : B
//{
//    public int OzellikC
//;
//    public C(int c, int b, int a) : base(b, a)
//    {
//        OzellikC = c;
//    }
//    static void Main()
//    {
//        C nesne = new C(12, 56, 23);
//        Console.WriteLine(nesne.OzellikA + " " + nesne.OzellikB + " " + nesne.OzellikC);
//    }
//}


//using System;
//using System.Collections;
//class Koleksiyon : IEnumerable
//{
//    int[] Dizi;
//    public Koleksiyon(int[] dizi)
//    {
//        this.Dizi = dizi;
//    }
//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return new ENumaralandırma(this);
//    }
//    class ENumaralandırma : IEnumerator
//    {
//        int indeks;
//        Koleksiyon koleksiyon;
//        public ENumaralandırma(Koleksiyon koleksiyon)
//        {
//            this.koleksiyon = koleksiyon;
//            indeks = -1;
//        }
//        public void Reset()
//        {
//            indeks = -1;
//        }
//        public bool MoveNext()
//        {
//            indeks++;

//            if (indeks < koleksiyon.Dizi.Length)
//                return true;
//            else
//                return false;
//        }
//        object IEnumerator.Current
//        {
//            get
//            {
//                return (koleksiyon.Dizi[indeks]);
//            }
//        }
//    }
//}
//class MainMetodu
//{
//    static void Main()
//    {
//        int[] dizi = { 1, 2, 3, 8, 6, 9, 7 };
//        Koleksiyon k = new Koleksiyon(dizi);
//        foreach (int i in k)
//            Console.Write(i + " ");
//    }
//}