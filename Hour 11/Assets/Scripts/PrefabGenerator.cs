using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float spacing = 5.0f;  // Distance between each lamp

    // Start is called before the first frame update
    void Start()
    {
        // Looping the 10 street lamps
        for (int i = 0; i < 10; i++)
        {
            // making sure lamps are in correct spot
            Vector3 position = new Vector3(i * spacing, 0, 0);
            
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // spawning "Cooler Lamp"
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        // Spawning the "Cooler Lamp" in a line
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
