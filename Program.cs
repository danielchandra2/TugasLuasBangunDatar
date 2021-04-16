using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLuasBangunDatar
{

	class Encapsulation
	{
		private string nama;
		private string alamat;
		private string phoneNumber;

		public void setNama(string n)
		{
			this.nama = n;
		}

		public string getNama()
		{
			return nama;
		}

		public void setAlamat(string a)
		{
			this.alamat = a;
		}

		public string getAlamat()
		{
			return alamat;
		}

		public void setPhoneNumber(string p)
		{
			this.phoneNumber = p;
		}

		public string getPhoneNumber()
		{
			return phoneNumber;
		}
	}

	interface Fruits
	{
		void rasa();
		void warna();
	}

	class Jeruk : Fruits
	{
		public void rasa()
		{
			Console.WriteLine("jeruk rasanya manis");
		}
		public void warna()
		{
			Console.WriteLine("jeruk berwarna oren");
		}
	}

	class Nanas : Fruits
	{
		public void rasa()
		{
			Console.WriteLine("nanas rasanya asem");
		}
		public void warna()
		{
			Console.WriteLine("nanas berwarna kuning");
		}
	}

	public class Animals
	{
		protected string blood;
		public virtual void suara()
		{
			Console.WriteLine("binatang memiliki suara yang berbeda-beda");
		}

		public virtual void introduce()
		{
			Console.WriteLine("binatang berdarah ");
		}
	}

	class Dog : Animals
	{
		public override void suara()
		{
			Console.WriteLine("suara anjing adalah guk guk guk");
		}
		public override void introduce()
		{
			blood = "dingin";
			Console.WriteLine("binatang berdarah " + blood);
		}
	}

	class Cat : Animals
	{
		public override void suara()
		{
			Console.WriteLine("suara kucing adalah meong meong meong");
		}
		public override void introduce()
		{
			blood = "panas";
			Console.WriteLine("binatang berdarah " + blood);
		}
	}
	class Menu : Program
	{

		public void menu()
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1. Persegi");
			Console.WriteLine("2. Persegi Panjang");
			Console.WriteLine("3. Segitiga");
			Console.WriteLine("4. Lingkaran");
			Console.WriteLine("5. Jajar Genjang");
			Console.WriteLine("6. Binatang");
			Console.WriteLine("7. Buah");
			Console.WriteLine("8. Encapsulation");
			Console.WriteLine("Masukkan Pilihan Anda :");
		}

		public void binatang()
		{
			Console.WriteLine("Macam-macam Binatang");
			Console.WriteLine("1. Anjing");
			Console.WriteLine("2. Kucing");
		}

		public void buah()
		{
			Console.WriteLine("Macam-macam Buah");
			Console.WriteLine("1. Jeruk");
			Console.WriteLine("2. Nanas");
		}
	}

	class Hitung : Menu
	{
		public void persegi(int sisi)
		{
			int luas = sisi * sisi;
			int keliling = 4 * sisi;
			Console.WriteLine("Luas persegi adalah "+luas);
			Console.WriteLine("Keliling persegi adalah " + keliling);
			
		}

		public void persegi(int panjang,int lebar)
		{
			int luas = panjang * lebar;
			int keliling = 2 * (panjang + lebar);
			Console.WriteLine("Luas persegi panjang adalah " + luas);
            Console.WriteLine("Keliling persegi panjang adalah "+keliling);
		}

		public void segitiga(int alas, int tinggi)
		{
			float luas = (float)(alas * tinggi) / 2;
			float sisiMiring = (float)Math.Sqrt(Math.Pow(Convert.ToDouble(alas), 2) + Math.Pow(Convert.ToDouble(tinggi), 2 ));
			float keliling = alas+tinggi+sisiMiring;
			Console.WriteLine("Luas segitiga sama sisi adalah " + luas);
            Console.WriteLine("Keliling segitiga sama sisi adalah "+keliling);
		}

		public void lingkaran(int ruas)
		{
			float phi = (float)3.14;
			float luas = (float)phi * (ruas * ruas);
			float keliling = (float)phi * (2 * ruas);
            Console.WriteLine("Luas Lingkaran adalah "+ luas);
            Console.WriteLine("Keliling Lingkaran adalah "+keliling);
		}

		public void jajargenjang(int alas, int tinggi, int b)
        {
			int luas = alas * tinggi;
			int keliling = 2 * (alas + b);
            Console.WriteLine("Luas Jajargenjang adalah "+luas);
			Console.WriteLine("Keliling Jajargenjang adalah " + keliling);
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Menu obj1 = new Menu();
			Hitung obj2 = new Hitung();
			obj1.menu();

		menu:
			string input = Console.ReadLine();

			if (input == "1")
			{
				Console.WriteLine("Masukkan panjang sisi persegi: ");
				string val = Console.ReadLine();
				int sisi = Convert.ToInt32(val);
				obj2.persegi(sisi);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = (Console.ReadLine()).ToLower();
				if (res == "yes")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "2")
			{
				Console.WriteLine("Masukkan panjang persegi panjang: ");
				string val = Console.ReadLine();
				int panjang = Convert.ToInt32(val);
				Console.WriteLine("Masukkan lebar persegi panjang: ");
				string val1 = Console.ReadLine();
				int lebar = Convert.ToInt32(val1);
				obj2.persegi(panjang,lebar);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "3")
			{
				Console.WriteLine("Masukkan alas segitiga: ");
				string val = Console.ReadLine();
				int alas = Convert.ToInt32(val);
				Console.WriteLine("Masukkan tinggi segitiga: ");
				string val1 = Console.ReadLine();
				int tinggi = Convert.ToInt32(val1);
				obj2.segitiga(alas,tinggi);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = (Console.ReadLine()).ToUpper();
				if (res == "YES")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "4")
			{
				Console.WriteLine("Masukkan ruas-ruas lingkaran :");
				string val = Console.ReadLine();
				int ruas = Convert.ToInt32(val);
				obj2.lingkaran(ruas);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				string res1 = res.ToLower();
				if (res1 == "yes")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}
			}
			else if (input == "5")
			{
				Console.WriteLine("Masukkan alas jajargenjang: ");
				string val = Console.ReadLine();
				int alas = Convert.ToInt32(val);
				Console.WriteLine("Masukkan sisi miring jajargenjang: ");
				string val2 = Console.ReadLine();
				int b = Convert.ToInt32(val2);
				Console.WriteLine("Masukkan tinggi jajargenjang: ");
				string val1 = Console.ReadLine();
				int tinggi = Convert.ToInt32(val1);
				obj2.jajargenjang(alas, tinggi,b);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "6")
			{
				obj1.binatang();

				Console.WriteLine("Masukkan banyak angka :");
				string val = Console.ReadLine();
				Animals obj3;
				if (val == "1")
				{
					obj3 = new Dog();
					obj3.suara();
					obj3.introduce();
				}
				else if (val == "2")
				{
					obj3 = new Cat();
					obj3.suara();
					obj3.introduce();
				}
				else
				{
					Console.WriteLine("Harap input 1-2");
				}

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "7")
			{
				obj1.buah();

				Console.WriteLine("Masukkan Pilihan :");
				string val = Console.ReadLine();

				if (val == "1")
				{
					Jeruk obj4 = new Jeruk();
					obj4.rasa();
					obj4.warna();
				}
				else if (val == "2")
				{
					Nanas obj4 = new Nanas();
					obj4.rasa();
					obj4.warna();
				}
				else
				{
					Console.WriteLine("Harap input 1-2");
				}

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "8")
			{
				Console.WriteLine("Encapsulation ");
				Console.WriteLine("Masukkan nama ");
				string nama = Console.ReadLine();
				Console.WriteLine("Masukkan alamat ");
				string alamat = Console.ReadLine();
				Console.WriteLine("Masukkan nomor telepon ");
				string phonenumber = Console.ReadLine();
				Encapsulation data1 = new Encapsulation();
				data1.setNama(nama);
				data1.setAlamat(alamat);
				data1.setPhoneNumber(phonenumber);
				Console.WriteLine("Data Private");
				Console.WriteLine("Nama adalah " + data1.getNama());
				Console.WriteLine("Alamat adalah " + data1.getAlamat());
				Console.WriteLine("Phone Number adalah " + data1.getPhoneNumber());

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else
			{
				Console.WriteLine("Harap input antara 1-8");
				obj1.menu();
				goto menu;
			}
		}
	}
}
