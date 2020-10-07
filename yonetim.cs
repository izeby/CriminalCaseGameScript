using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetim : MonoBehaviour
{

    int yerlestirilen_parca = 0;
    int toplam_puzzle = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void  sayi_arttir()
    {
        yerlestirilen_parca++;
        if (yerlestirilen_parca ==toplam_puzzle)
        {
            Debug.Log("sonraki bolume gec");
        }



    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
