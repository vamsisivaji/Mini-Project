using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    //public GameObject Enemy;
    //GameObject enmref;
    public Transform Player;
    public Transform Spawner;
    float ex, px;
    float ey, py;
    public GameManager gm;
    GameObject face;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Spawner.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (gm.Turn == 2)
        {
            //face=transform.Find("Unpure Block").gameObject;
            //print(face.tag);
            ex = transform.position.x;
            ey = transform.position.y;
            px = Player.position.x;
            py = Player.position.y;
            if ((ey- py>2)||(ey - py <-2))
            {
                uY();
            }
            else if (ey==py)
            {
                if((px - ex) == 2 || (px - ex) == -2)
                {
                    uX();
                }
                else 
                {
                    uX();
                }
                
            }
            else if(((ey - py) == 2)|| ((ey - py) == -2))
            {
                if ((px - ex) == 2|| (px - ex) == -2)
                {
                    uX();
                }
                else if (ex == px)
                {
                    uY();
                }
                else if ((px - ex) > 2|| (px - ex) < -2)
                {
                    uX();
                }
            }
            gm.endturn(2);
        }
        if (ex == px && ey == py)
        {
            print("player killed");
        }
    }
    void uY()
    {
        if (ey > py)
        {
            transform.position = new Vector3(ex, ey - 2, 0);
            gm.Turn = 0;
        }
        else if (ey < py)
        {
            transform.position = new Vector3(ex, ey + 2, 0);
            gm.Turn = 0;
        }
    }
    void uX()
    {
        if (ex < px)
        {
            transform.position = new Vector3(ex + 2, ey, 0);
            gm.Turn = 0;
        }
        else if (ex > px)
        {
            transform.position = new Vector3(ex - 2, ey, 0);
            gm.Turn = 0;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            print("ground");
            //gameObject.SetActive(false);
        }
    }
}
