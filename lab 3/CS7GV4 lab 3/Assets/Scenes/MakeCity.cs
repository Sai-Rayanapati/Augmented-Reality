using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCity : MonoBehaviour
{
    public GameObject myBuilding;
    public GameObject buildingPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // for (var i = -4; i<=4; i++){
        //     Vector3 newPosition = myBuilding.transform.position + new Vector3(i * 32.0f,0,0);

        //     Instantiate(
        //         myBuilding,
        //         newPosition,
        //         Quaternion.identity
        //         );
        // }
        GenerateBuildings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void GenerateBuildings()
    {
        for (int x = -160; x <= 160; x += 25)
        {
            for (int z = -28; z <= 28; z += 56)
            {
                float height = RandomHeight();
                Vector3 position = new Vector3(x, height/2.0f, z);
                GameObject building = Instantiate(buildingPrefab, position, Quaternion.identity);
                building.transform.localScale = new Vector3(16, height, 16);
                // Note: Assign texture/material in the prefab or dynamically here
            }
        }
    }

    float RandomHeight()
    {
        return 20 + (Random.Range(0, 7) * 10);
    }

}
