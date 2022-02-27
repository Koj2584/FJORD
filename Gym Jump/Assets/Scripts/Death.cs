using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;
    public Transform camera;

    bool jednou = true;

    void Update()
    {
        if ((player.transform.position.y <= gameObject.transform.position.y && jednou) || Input.GetKeyDown(KeyCode.R)) 
        {
            jednou = false;

            // Co se stane po smrti
            Debug.Log("Die");
            player.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
