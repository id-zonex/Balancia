using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControler : MonoBehaviour
{
    public PlayerControler PlayerControler;
    public GameObject ParticleObj;
    public GameObject Coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerControler.Coins++;
            StartCoroutine(Particle());
            Destroy(Coin);
        }
    }

    private IEnumerator Particle()
    {
        ParticleObj.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        Destroy(transform.gameObject);
    }
}
