using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoment : MonoBehaviour
{
    float x;
    float y;
    int a = 0;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.Turn==1)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                x = transform.position.x;
                y = transform.position.y + 2;
                a = 1;
                
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                x = transform.position.x;
                y = transform.position.y - 2;
                a = 1;
                
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                x = transform.position.x+2;
                y = transform.position.y;
                a = 1;
                
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                x = transform.position.x-2;
                y = transform.position.y;
                a = 1;
                
            }
            if (x>=2&&x<=6&&y>=2&&y<=10&&a==1)
            {
                transform.position = new Vector3(x, y, 0);
                a = 0;
                gm.Turn = 0;
                gm.endturn(1);

            }
            
        }
    }
    
}
