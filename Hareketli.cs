using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareketli : MonoBehaviour
{

    public float MinY = -1;
    public float MaxY = 1;
    public bool HareketliY = false;

    public float OlusmaX = 11;
    public float YokOlmaX = -11;

    public float Hiz = 1f;



    void Update()
    {


        //bu objenin konumunu bir değişken içine al.
        var konum = this.transform.position;

        //değişkenimizin X değerini hız kadar azalt
        konum.x = konum.x - Hiz * Time.deltaTime;

        //eğer nesne yok olma konumuna geliyorsa, başa döndür
        if (konum.x < YokOlmaX)
        {
            konum.x = OlusmaX;

            //eğer nesne yukarı aşağı hareket edecekse bunu uygula. 
            // bu durumda Y konumunu izin verilen aralıktan rastgele seçtir.
            if (HareketliY == true)
            {
                konum.y = Random.Range(MinY, MaxY);
            }

        }


        //son olarak objenin yeni konumunu ata
        this.transform.position = konum;
    }
}
