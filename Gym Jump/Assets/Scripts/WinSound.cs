
using UnityEngine;
using UnityEngine.Audio;
public class WinSound : MonoBehaviour
{
    public AudioSource sound;

   

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Rigidbody2D rg = collision.collider.GetComponent<Rigidbody2D>();
        if (rg != null) 
        {
            sound.Play();
        }
            
           
        
    }
}
