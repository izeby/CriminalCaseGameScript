using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public float sayi;
    public Text sayiyazi,ipucuyazi;
    public GameObject bar,ekran;
    public int ipucusayi;


    void Start()
    {
        ekran.SetActive(true);
        ipucusayi = Random.Range(0, 4); // ipucu random gelsin diye
    }

    void Update()
    {

        sayiyazi.text = "" + (int)sayi + "%";        //sayıyazının içindeki text
        bar.transform.localScale = new Vector3(sayi / 100, 1, 1); // barın dolması için
        if (sayi < 100)
        {
            sayi += Time.deltaTime * 10;         //saniyede beş artsın
        }
        if (sayi >= 100)
        {
            ekran.SetActive(false);
            sayi = 100;
        }

        if (ipucusayi == 0)
        {
            ipucuyazi.text = "İpucu : Delilleri dikkatlice incelemelisin.";
        }
        if (ipucusayi == 1)
        {
            ipucuyazi.text = "İpucu : Şüphelilerin söyledikleri çelişkili olabilir.";
        }
        if (ipucusayi == 2)
        {
            ipucuyazi.text = "İpucu : Bölüm sonundaki bulmacaları çözebilmek için ifadeleri dikkatlice oku.";
        }
        if (ipucusayi == 3)
        {
            ipucuyazi.text = "İpucu : Parmak izi tarayıcısını çalıştırmak için bulmacayı çöz.";
        }






    }
}
