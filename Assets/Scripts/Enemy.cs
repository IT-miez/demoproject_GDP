using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int boxesDestroyed = 0;

    [SerializeField] private Text boxesText;

    //[SerializeField] private AudioSource collectionSoundEffect;

    public void TakeDamage()
    {

        //collectionSoundEffect.Play();
        Destroy(gameObject);
        boxesDestroyed++;
        boxesText.text = "Boxes destroyed: " + boxesDestroyed;
    }
}
