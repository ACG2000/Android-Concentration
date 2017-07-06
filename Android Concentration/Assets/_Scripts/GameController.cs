using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    // Use this for initialization
    bool match;
    int cards;
    int cardsUp;
    int gridX = 6;
    int gridY = 9;
    float vSpacing = 1F;
    float hSpacing = 1;
    GameObject[] blocks;
        
    void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("Card");
        for (float y = 0; y < gridY; y++)
        {
            for (float x = 0; x < gridX; x++)
            {
                Instantiate(blocks[Random.Range(0, blocks.Length)], transform.position = new Vector3(x * vSpacing - 2.5F, y * hSpacing - 4F, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
