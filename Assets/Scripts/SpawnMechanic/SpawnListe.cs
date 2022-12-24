using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnListe : MonoBehaviour
{
    public GameObject[] SpawnObjects;
    public LinkedList<GameObject> SpawnObjectsList;


    // Start is called before the first frame update
    private void Start()
    {
        SpawnObjectsList = new LinkedList<GameObject>();
        foreach(GameObject o in SpawnObjects){
            SpawnObjectsList.AddLast(o);
        }
    }
}
