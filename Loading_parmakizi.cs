using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading_parmakizi : MonoBehaviour
{
    public float sayi;
    public Text sayiyazi;
    public GameObject bar,ekran;
  


    void Start()
    {
        ekran.SetActive(true);
       
    }

    void Update()
    {

        sayiyazi.text = "" + (int)sayi + "%";        //sayıyazının içindeki text
        bar.transform.localScale = new Vector3(sayi / 100, 1, 1); // barın dolması için
        if (sayi < 100)
        {
            sayi += Time.deltaTime * 5;         //saniyede beş artsın
        }
        if (sayi >= 100)
        {
            ekran.SetActive(false);
            sayi = 100;
            SceneManager.LoadScene("bolumikisahne11");
        }

       




    }
}
