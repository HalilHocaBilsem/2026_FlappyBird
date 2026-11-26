using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class Kus : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public float ZiplamaGucu = 2f;
    public TMPro.TMP_Text puanAlani;

    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool spaceBasildi = false;

#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            spaceBasildi = true;
        }
#elif ENABLE_LEGACY_INPUT_MANAGER
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBasildi = true;
        }
#endif

        // Eğer space tuşuna basılırsa
        if (spaceBasildi)
        {
            //rigidbody'e yukarı yönlü kuvvet uygula
            rigidbody.AddForce(Vector2.up * ZiplamaGucu, ForceMode2D.Impulse);
        }

        //puanı yaz. Puan oyunun başından beri geçen saniyedir.
        if (puanAlani != null)
        {
            puanAlani.text = Time.timeSinceLevelLoad.ToString("N0");
        }

    }

    //kuş heerhangi bir şeye çarparsa
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //oyunu yeniden başlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
