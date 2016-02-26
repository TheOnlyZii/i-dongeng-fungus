using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class UImanager : MonoBehaviour {

	/// <summary>
	/// MENGATUR UI SEPERTI NARASI DKK HAL2 YANG BERHUBUNGAN DENGAN UI SECARA GENERAL
	/// </summary>

	int scene;
	int subscene;

	public GameObject EP1;
	float timer;

	public Text narasiText;

	// Use this for initialization
	void Start () 
	{
		timer = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{

		////////////////////////////////////// subscene mulai dari 2 karena nilai transisi per subscene yang langsung di tambah 1
		if(staticVal.scene == 1)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Suatu pagi tanpa ada yang mengetahui, seorang kakek kera duduk manis di atas pohon, ia menggambar dan menikmati pemandangan di sekitarnya. Sang kakek sangat senang untuk bepergian dan menuliskan pengalamannya di dalam sebuah buku yang akan ia turunkan kepada cucu-cucunya.";
			}

			if(staticVal.subscene == 3)
			{
				narasiText.text = "Kakeek!! Kakeek, ayo turun.. ceritakanlah sebuah cerita kepada kami keekk!!.";
			}

			if(staticVal.subscene == 4)
			{
				narasiText.text = "Aduh, hehe, iya iya iya, sebentar ya sebentar.";
			}

			if(staticVal.subscene == 5)
			{
				narasiText.text = "Cepat kek.";
			}
		}

		if(staticVal.scene == 2)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Kalian memang ingin diceritakan apa? Kalian ini mengganggu kakek saja. hehehehe";
			}
			
			if(staticVal.subscene == 3)
			{
				narasiText.text = "Emmhh.. lihat buku kakek dulu, nanti aku pilih ceritanya.";
			}
		}

		if(staticVal.scene == 3)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Ini saja, kek.. yang ada gambar air terjunnya! Warnanya bagus sekali!!.";
			}
			
			if(staticVal.subscene == 3)
			{
				narasiText.text = "Wow, pilihan bagus! ini adalah cerita yang paling kakek suka.";
			}

			if(staticVal.subscene == 4)
			{
				narasiText.text = "Kenapa kakek suka cerita ini?.";
			}
		}

		if(staticVal.scene == 4)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Hmm… biarkan kakek bercerita dulu ya, nanti kalian akan tahu sendiri kenapa cerita ini jadi yang paling istimewa.";

				timer-=Time.deltaTime;

				if(timer <= 0)
				{
					narasiText.text = "Jadii..Dulu, di Hutan Dalam raya ini ada sebuah tempat yang luar biasa, yaitu air terjun Banyusuci.. di   sana, selain air terjunnya yang tinggi dan indah, konon katanya airnya juga bisa menyembuhkan berbagai macam penyakit.Hewan-hewan di hutan ini, tidak banyak yang mengetahui keberadaan air terjun tersebut. Keindahan air terjun ini hanya menjadi buah bibir para warga hutan.. banyak dari mereka yang berlomba-lomba mencari keberadaan air terjun ini, salah satunya adalah kelompok anak-anak hewan yang sekarang akan kakek ceritakan..";
				}
			}
		}

		if(staticVal.scene == 5)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Teman- teman, bagaimana persiapan petualangan kita hari ini? Apa sudah siap semua? Kita akan mengukir sejarah dengan penemuan Banyusuci! Hahahaha…";
			}

			if(staticVal.subscene == 3)
			{
				narasiText.text = "Sebentar Galia, Asa belum datang.";
			}

			if(staticVal.subscene == 4)
			{
				narasiText.text = "Aduh, kemana sih si Asa itu? Dia bilang tidak akan terlambat.";
			}

			if(staticVal.subscene == 5)
			{
				narasiText.text = "Tidak tahu. Mungkin sedang rebutan pisang dengan kakaknya. Hahaha";
			}

			if(staticVal.subscene == 6)
			{
				narasiText.text = "Nah, itu dia si Asa datang!";
			}

			if(staticVal.subscene == 7)
			{
				narasiText.text = "Asa! Kamu lama sekali, sih! dari mana?";
			}

			if(staticVal.subscene == 8)
			{
				narasiText.text = "Hahaha, maaf maaf.. kalian menunggu lama ya? Aku habis rebutan pisang  dengan kakakku hehehe. Aku juga bawa untuk kalian, satu orang mendapat satu pisang. Jadi, berapa pisang yang kita butuhkan? Ayo berhitung!";
			}
		}

		if(staticVal.scene == 6)
		{
			if(staticVal.subscene == 2)
			{
				narasiText.text = "Nah sudah ya, ayo sekarang kita pilih ketua kelompok ekspedisi ini! Ehem ehem.. siapa yang mau?";
			}

			if(staticVal.subscene == 3)
			{
				narasiText.text = "Bagaimana kalau…";
			}

			if(staticVal.subscene == 4)
			{
				narasiText.text = "Hhahaa.. baiklah Tigis, aku akan bersedia menjadi pemimpin kelompok ini! Terima kasih atas kepercayaanmu kepadaku yah. Hehehe";
			}

			if(staticVal.subscene == 5)
			{
				narasiText.text = "Ngggg. baiklah, Galia saja";
			}

			if(staticVal.subscene == 6)
			{
				narasiText.text = "Okee.. berarti mulai sekarang sampai kita kembali ke rumah, kalian harus mematuhiku karena aku yang memimpin kalian. Oke??";
			}

			if(staticVal.subscene == 7)
			{
				narasiText.text = "Okee!!";
			}

			if(staticVal.subscene == 8)
			{
				narasiText.text = "Tigis, kamu membawa kompasmu kan?";
			}

			if(staticVal.subscene == 9)
			{
				narasiText.text = "Tidak Asa.. kompasku sedang  rusak. jadi kutinggal di rumah.";
			}

			if(staticVal.subscene == 10)
			{
				narasiText.text = " Galia, sepertinya kita perlu membawa kompas";
			}

			if(staticVal.subscene == 11)
			{
				narasiText.text = "Ah, sudah tidak perlu membawa kompas.. Kita bisa kok menentukan arah mata angin tanpa membawa kompas. Ayo kita langsung jalan saja";
			}
		}
	}

	public void UISceneToggle(int val)
	{
		for(int i = 0; i <= 8; i++)
		{
			EP1.transform.GetChild(i).gameObject.SetActive(false);
		}

		EP1.transform.GetChild(val).gameObject.SetActive(true);
	}

	public void recordPanelOptionToggle()
	{
		if(staticVal.scene == 5 || staticVal.scene == 6)
		{
			if(EP1.transform.GetChild(staticVal.scene).GetChild(0).gameObject.activeInHierarchy == false)
			{
				EP1.transform.GetChild(staticVal.scene).GetChild(0).gameObject.SetActive(true);
			}
			else
			{
				EP1.transform.GetChild(staticVal.scene).GetChild(0).gameObject.SetActive(false);
			}
		}
		else
		{
			if(EP1.transform.GetChild(staticVal.scene - 1).GetChild(0).gameObject.activeInHierarchy == false)
			{
				EP1.transform.GetChild(staticVal.scene - 1).GetChild(0).gameObject.SetActive(true);
			}
			else
			{
				EP1.transform.GetChild(staticVal.scene - 1).GetChild(0).gameObject.SetActive(false);
			}
		}

	}

	public void openCloseParticularRecordPanel(GameObject val)
	{
		if(val.gameObject.activeInHierarchy == false)
		{
			val.gameObject.SetActive(true);
		}
		else
		{
			val.gameObject.SetActive(false);
		}
	}

}
