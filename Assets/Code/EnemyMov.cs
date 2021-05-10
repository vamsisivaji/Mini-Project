using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public Transform Player;
    float ex, px;
    float ey, py;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //print("turn" + gm.Turn);
        if (gm.Turn == 0)
        {
            print("enemy turn");
            ex = transform.position.x;
            ey = transform.position.y;
            px = Player.position.x;
            py = Player.position.y;
            print(py+""+ey);
            if ((ey - py) > 3)
            {
                transform.position = new Vector3(ex, ey + 2, 0);
                gm.Turn = 1;
                print(py - ey);
            }
            else if ((ey - py) == 2)
            {
                if ((px - ex) == 2)
                {
                    if (ex < px)
                    {
                        transform.position = new Vector3(ex + 2, ey, 0);
                        gm.Turn = 1;
                    }
                    else if (ex > px)
                    {
                        transform.position = new Vector3(ex - 2, ey, 0);
                        gm.Turn = 1;
                    }
                    else
                    {
                        transform.position = new Vector3(ex, ey-2, 0);
                        gm.Turn = 1;
                    }
                }
            }
        }
    }
}
