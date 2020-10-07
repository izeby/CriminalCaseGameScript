using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Anamenu : MonoBehaviour
{
    void Start()// Start is called before the first frame update
    {
        
    }
    void Update()// Update is called once per frame
    {

    }
    public void oyuna_basla()
    {
        SceneManager.LoadScene("bolumbirsahne1");
    }
    public void oyundan_cik()
    {
        Application.Quit();
    }

    public void ayarlara_git()
    {
        SceneManager.LoadScene("ayarlarmenusu");
    }
}

