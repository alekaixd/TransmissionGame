using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorScript : MonoBehaviour
{
    public Collider2D generatorCollider;
    public ActiveScript activeScript;
    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        activeScript = GetComponent<ActiveScript>();
        active = activeScript.isActive;
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("collision!");
        collision.gameObject.GetComponent<ActiveScript>().isActive = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter!");
    }
}
