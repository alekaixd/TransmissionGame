using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public float movespeed = 5f;
    public Transform movePoint;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null; //Est‰‰ movepointin liikkumisen pelaajan mukana
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, movespeed * Time.deltaTime); //pelaaja liikkuu

        if (Vector3.Distance(transform.position, movePoint.position) <= .05f )
        {
            if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f) //Palauttaa itseisarvon horisontaalisesta liikkumisesta (k‰yt‰nnˆss‰ siis tarkistaa ett‰ pelaaja liikkuu 100% yhteensuuntaan)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f) //Sama kuin ylempi, mutta t‰ll‰ kertaa vertikaaliseen liikkumiseen
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
    }
}
