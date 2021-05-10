using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawn : MonoBehaviour
{
    public GameObject Block;
    public float offset;
    GameObject[] BlockArray;
    float x;
    float y;
    float x1;
    void Start()
    {
        BlockArray = new GameObject[10];
        x1 = transform.position.x;
        x = transform.position.x;
        y = transform.position.y;
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<3;j++)
            {
                transform.position = new Vector3(x, y, 0);
                BlockArray[i + j] = Instantiate(Block, transform.position, Quaternion.identity);
                x += 2;
            }
            x = x1;
            y += 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
