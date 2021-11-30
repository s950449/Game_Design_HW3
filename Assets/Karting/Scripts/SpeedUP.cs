using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
public class SpeedUP : MonoBehaviour
{
    ArcadeKart playerKart;
    [SerializeField] AudioClip speedUpSound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerKart = other.gameObject.GetComponentInParent<ArcadeKart>();
            Debug.Log("Pass");
            if (playerKart != null)
            {
                playerKart.baseStats.Acceleration += 1.0f;
                playerKart.baseStats.TopSpeed += 1.0f;
                audioSource.PlayOneShot(speedUpSound);
                Debug.Log("SpeedUP");
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerKart = null;
            gameObject.SetActive(false);
        }
            
    }
}
