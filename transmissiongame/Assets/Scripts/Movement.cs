using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float movespeed = 5f;
    public Transform movePoint;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null; //Estää movepointin liikkumisen pelaajan mukana
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(Input.GetAxisRaw("horizontal")) == 1f) //Palauttaa itseisarvon horisontaalisesta liikkumisesta (käytännössä siis tarkistaa että pelaaja liikkuu 100% yhteensuuntaan)
        {
            movePoint.position = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        }
        if (Mathf.Abs(Input.GetAxisRaw("vertical")) == 1f) //Sama kuin ylempi, mutta tällä kertaa vertikaaliseen liikkumiseen
        {
            movePoint.position = new Vector3(0f,Input.GetAxisRaw("Vertical"), 0f);
        }

    }
}
