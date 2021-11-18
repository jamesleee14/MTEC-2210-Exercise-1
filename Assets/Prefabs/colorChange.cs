using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Hair;
    public Sprite HairSprite;
    public Color HairColor;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Debug.Log("“Let's-a-go!");
            GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            Debug.Log("It's-a me, Mario");
            GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I'm back.");
            GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}