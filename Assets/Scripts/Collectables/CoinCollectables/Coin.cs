using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinPickUpSound;
    void OnTriggerEnter(Collider other) {
        coinPickUpSound.Play();
        Destroy(this.gameObject);
    }
}
