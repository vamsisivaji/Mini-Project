using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConq : MonoBehaviour
{

    SpriteRenderer sr;
    public Sprite pure;
    GameObject player;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        sr = gameObject.GetComponent<SpriteRenderer>();
        gm = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(player.transform.position==gameObject.transform.position)
            {
                gm.Set_Pure(gameObject.transform);
                sr.sprite = pure;
                gameObject.tag = "Pure";
            }
        }
    }
   
}
