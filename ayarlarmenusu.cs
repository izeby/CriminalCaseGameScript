using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ayarlarmenusu : MonoBehaviour
{
    void Start()// Start is called before the first frame update
    {
        
    }

    void Update()// Update is called once per frame
    {   
    }

    public void nasil_oynanir()
    {
        SceneManager.LoadScene("nasiloynanir");

    }
    public void ayarlar_kariyer()
    {
        SceneManager.LoadScene("ayarlarkariyer");

    }
    public void geri_butonu()
    {
        SceneManager.LoadScene("anamenu");

    }

    public void kariyer_geri()
    {
        SceneManager.LoadScene("ayarlarmenusu");

    }
}
