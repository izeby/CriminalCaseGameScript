using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nasiloynanir : MonoBehaviour
{  
    //nasil oynanir anamenu için
    public void geri()
    {
        SceneManager.LoadScene("ayarlarmenusu");

    }
    public void ileri()
    {
        SceneManager.LoadScene("nasiloynanir1");

    }
    //nasil oynanir birinci bölüm için
    public void geri_bir()
    {
        SceneManager.LoadScene("nasiloynanir");

    }
    public void ileri_bir()
    {
        SceneManager.LoadScene("nasiloynanir2");

    }
    //nasil oynanir ikinci bölüm için
    public void geri_iki()
    {
        SceneManager.LoadScene("nasiloynanir1");

    }
    public void ileri_iki()
    {
        SceneManager.LoadScene("nasiloynanir3");

    }

    //nasil oynanir üçüncü bölüm için
    public void geri_uc()
    {
        SceneManager.LoadScene("nasiloynanir2");

    }
    public void ileri_uc()
    {
        SceneManager.LoadScene("nasiloynanir4");

    }
    //nasil oynanir dördüncü bölüm için
    public void geri_dort()
    {
        SceneManager.LoadScene("nasiloynanir3");

    }
    public void ileri_dort()
    {
        SceneManager.LoadScene("nasiloynanir5");

    }
    //nasil oynanir besinci bölüm için
    public void geri_bes()
    {
        SceneManager.LoadScene("nasiloynanir4");

    }
    public void basla()
    {
        SceneManager.LoadScene("bolumbirsahne1");

    }

}

