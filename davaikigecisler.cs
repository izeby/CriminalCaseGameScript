using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class davaikigecisler : MonoBehaviour
{
    
    void Start()// Start is called before the first frame update
    {

    }
    void Update() // Update is called once per frame
    {

    }
    //sahne bir
    public void bir_basla()
    {
        SceneManager.LoadScene("bolumikisahne2");

    }
    //sahne iki
    public void iki_ileri()
    {
        SceneManager.LoadScene("bolumikisahne3");

    }

    public void iki_geri()
    {
        SceneManager.LoadScene("bolumikisahne1");

    }
    //sahne üç
    public void uc_ileri()
    {
        SceneManager.LoadScene("bolumikisahne4");

    }
    public void uc_geri()
    {
        SceneManager.LoadScene("bolumikisahne2");

    }
    //sahne dört
    public void dort_ileri()
    {
        SceneManager.LoadScene("bolumikisahne5");

    }
    public void dort_geri()
    {
        SceneManager.LoadScene("bolumikisahne3");

    }
    //sahne beş
    public void bes_ileri()
    {
        SceneManager.LoadScene("bolumikisahne6");

    }
    public void bes_geri()
    {
        SceneManager.LoadScene("bolumikisahne4");

    }
    //sahne alti
    public void alti_ileri()
    {
        SceneManager.LoadScene("bolumikisahne7");

    }
    public void alti_geri()
    {
        SceneManager.LoadScene("bolumikisahne5");

    }
    //sahne yedi
    public void yedi_ileri()
    {
        SceneManager.LoadScene("bolumikisahne8");

    }
    public void yedi_geri()
    {
        SceneManager.LoadScene("bolumikisahne6");

    }
    //sahne sekiz
    public void sekiz_ileri()
    {
        SceneManager.LoadScene("bolumikisahne9");

    }
    public void sekiz_geri()
    {
        SceneManager.LoadScene("bolumikisahne7");

    }
    //sahne dokuz
    public void dokuz_geri()
    {
        SceneManager.LoadScene("bolumikisahne8");

    }
    public void dokuz_parmakizi()
    {
        SceneManager.LoadScene("bolumikisahne10");

    }
    //sahne on onbir ve on iki için loading ekranı eklenecek

  


    public void onbir_sonuclarigor()
    {
        SceneManager.LoadScene("bolumikisahne12");
    }
    public void oniki_sonuclarigor()
    {
        SceneManager.LoadScene("bolumikisahne13");
    }



    //sahne onüç
    public void onuc_ileri()
    {
        SceneManager.LoadScene("bolumikisahne14");

    }
    
    //sahne ondort
    public void ondort_ileri()
    {
        SceneManager.LoadScene("bolumikisahne15");

    }
    public void ondort_geri()
    {
        SceneManager.LoadScene("bolumikisahne13");

    }
    //sahne onbeş
    public void onbes_ileri()
    {
        SceneManager.LoadScene("bolumikisahne16");

    }
    public void onbes_geri()
    {
        SceneManager.LoadScene("bolumikisahne14");

    }

    //sahne onaltı

    public void onalti_ileri()
    {
        SceneManager.LoadScene("anamenu");

    }
   
}
