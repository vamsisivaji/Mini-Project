using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Turn;
    public GameObject Player;
    public GameObject Enemy;
    float[] x;
    float[] y;
    Transform[] check;
    int j;
    // Start is called before the first frame update
    void Start()
    {
        Turn = 1;
        x = new float[15];
        y = new float[15];
        check = new Transform[15];
        j = 0;

    }
    public int sendTurn()
    {
        return Turn;
    }
    public void endturn(int i)
    {
        if(Turn==0)
        {
            if(Player.transform.position==Enemy.transform.position)
            {
                Player.SetActive(false);
            }
            foreach(float c in x)
            {
                if(c== Enemy.transform.position.x)
                {
                    foreach (float b in y)
                    {
                        if (b == Enemy.transform.position.y)
                        {
                            Enemy.SetActive(false);
                        }
                    }
                        
                }
            }
            
        }
        if(i==1)
        {
            Turn = 2;
        }
        else if (i == 2)
        {
            Turn = 1;
        }
    }
    public void Set_Pure(Transform Pure)
    {
        print(j);
        x[j] = Pure.position.x;
        y[j] = Pure.position.y;
        check[j] = Pure;
        j++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
