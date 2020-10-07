using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class davabirgecisler : MonoBehaviour
{
    void Start()// Start is called before the first frame update
    {
        
    }
    void Update() // Update is called once per frame
    {
        
    }
    //bölüm bir sahne bir
    public void geri_bir()
    {
        SceneManager.LoadScene("anamenu");

    }
    public void olay_yeri()
    {
        SceneManager.LoadScene("bolumbirsahne2");

    }
    //bölüm bir sahne iki
    public void geri_iki()
    {
        SceneManager.LoadScene("bolumbirsahne1");

    }
    public void kanit_incele_iki()
    {
        SceneManager.LoadScene("bolumbirsahne3");

    }

    //bölüm bir sahne uc
    public void geri_uc()
    {
        SceneManager.LoadScene("bolumbirsahne2");

    }
    public void ileri_uc()
    {
        SceneManager.LoadScene("bolumbirsahne4");

    }
    //bölüm bir sahne dort
    public void geri_dort()
    {
        SceneManager.LoadScene("bolumbirsahne3");

    }
    public void lab_git_dort()
    {
        SceneManager.LoadScene("bolumbirsahne5");

    }
    //bölüm bir sahne bes
    public void geri_bes()
    {
        SceneManager.LoadScene("bolumbirsahne4");

    }
    public void sorguya_git_bes()
    {
        SceneManager.LoadScene("bolumbirsahne6");

    }
    //bölüm bir sahne alti
    public void geri_alti()
    {
        SceneManager.LoadScene("bolumbirsahne5");

    }
    public void sorguya_devam_et_alti()
    {
        SceneManager.LoadScene("bolumbirsahne7");

    }
    //bölüm bir sahne yedi
    public void geri_yedi()
    {
        SceneManager.LoadScene("bolumbirsahne6");

    }
    public void sorguya_devam_et_yedi()
    {
        SceneManager.LoadScene("bolumbirsahne8");

    }
    //bölüm bir sahne sekiz
    public void geri_sekiz()
    {
        SceneManager.LoadScene("bolumbirsahne7");

    }
    public void sorguya_devam_et_sekiz()
    {
        SceneManager.LoadScene("bolumbirsahne9");

    }
    //bölüm bir sahne dokuz
    public void geri_dokuz()
    {
        SceneManager.LoadScene("bolumbirsahne8");

    }
    public void sorguya_devam_et_dokuz()
    {
        SceneManager.LoadScene("bolumbirsahne10");

    }
    //bölüm bir sahne on
    public void geri_on()
    {
        SceneManager.LoadScene("bolumbirsahne9");

    }
    public void adlitip_git_on()
    {
        SceneManager.LoadScene("bolumbirsahne11");

    }
    //bölüm bir sahne on bir
    public void geri_onbir()
    {
        SceneManager.LoadScene("bolumbirsahne10");

    }
    public void katil_kim_onbir()
    {
        SceneManager.LoadScene("bolumbirsahne12");

    }
    //bölüm bir sahne on iki
    public void geri_oniki()
    {
        SceneManager.LoadScene("bolumbirsahne11");

    }
    public void katil_kim_oya() //katil değil
    {
        SceneManager.LoadScene("bolumbirsahne14");

    }
    public void katil_kim_serhat() //katil değil
    {
        SceneManager.LoadScene("bolumbirsahne14");

    }
    public void katil_kim_nicolas() //katil
    {
        SceneManager.LoadScene("bolumbirsahne13");

    }
    //bölüm bir sahne on üç
    public void yeni_dava()
    {
        SceneManager.LoadScene("bolumsonu");

    }
    //bölüm bir sahne on dört
    public void gercek_katil()
    {
        SceneManager.LoadScene("bolumbirsahne15");

    }
    //bölüm bir sahne on bes
    public void yeni_dava_1()
    {
        SceneManager.LoadScene("bolumsonu");

    }
    public void bolumsonu()
    {
        SceneManager.LoadScene("kelimeoyunu");

    }
}
