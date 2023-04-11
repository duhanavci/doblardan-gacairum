using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] sphereRef;

    [SerializeField]
    Transform leftpos, rightpos;

    private GameObject SpawnedSphere;
    private int randomIndex;
    private int randomSide;

    private void Start()
    {
        StartCoroutine(SpawnSpheres());
    }





    IEnumerator SpawnSpheres()
    {

        while (true) { 
        yield return new WaitForSeconds(Random.Range(1, 5));

        //RandomIndex = Random.Range(0, sphereRef.Length);
        randomSide = Random.Range(0, 2);
        SpawnedSphere = Instantiate(sphereRef[0]);


        if (randomSide == 0)
        {
            SpawnedSphere.transform.position = leftpos.position;
            SpawnedSphere.GetComponent<Spheres>().speed = Random.Range(4, 8);

        }
        else
        {
            SpawnedSphere.transform.position = rightpos.position;
            SpawnedSphere.GetComponent<Spheres>().speed = -Random.Range(4, 8);

        }


    }


}




}
