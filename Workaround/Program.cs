using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
	class Program
	{
		static void Main(string[] args)
		{
			//Degiskenler();

			Vatandas vatandas1 = new Vatandas();
			SelamVer("Ahmet");
			SelamVer("Şükrü");
			SelamVer("Enes"); 

			int sonuc = Topla(6,58);

			string[] ogrenciler = new string[3];
			ogrenciler[0] = "Ahmet";
			ogrenciler[1] = "Engin";
			ogrenciler[2] = "Kerem";

			ogrenciler = new string[4];
			ogrenciler[3] = "ilker";

			for (int i = 0; i < ogrenciler.Length; i++)
			{
				Console.WriteLine(ogrenciler[i]);
            }

			string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
			string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

			sehirler2 = sehirler1;
			sehirler1[0] = "Adana";
			Console.WriteLine(sehirler2[0]);


			Person person1 = new Person();
			Person person2 = new Person();
			foreach (string s in sehirler1)
			{
                Console.WriteLine(s);
            }
			person1.FirstName = "AHMET";
			person1.LastName = "KAPUSIZ";
			person1.DateOfBirthYear = 2001;
			person1.NationalIdentity = 12345;
			List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
			yeniSehirler1.Add("Adana 1");
			foreach (string s in yeniSehirler1)
			{
				Console.WriteLine(s);
			}


			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person1);


			Console.ReadLine();
		}
		static void SelamVer(string isim = "isimsiz")
		{
            Console.WriteLine("Merhaba"+ isim);
        }

		static int Topla(int sayi1 = 5 , int sayi2 = 10)
		{
			int sonuc = sayi1+ sayi2;
            Console.WriteLine("Toplam"+ sonuc.ToString());
            return sonuc;
		}
		private static void Degiskenler()
		{
			string mesaj = "Merhaba";
			double tutar = 100000;
			int sayi = 100;
			bool girisYapmisMi = false;

			string ad = "Ahmet";
			string soyad = "Kapusız";
			int dogumyili = 2001;
			long tcNo = 12345678910;

			Console.WriteLine(tutar * 1.18);

			Console.WriteLine(tutar * 1.18);
		}
	}


}
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public  int DogumYili { get; set; }

    public long TcNo { get; set; }


}
