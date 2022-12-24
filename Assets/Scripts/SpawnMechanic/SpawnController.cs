using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject SpawnGerüst;
    private GameObject SpawnGerüstInstance;
    public Camera cam;
    public bool ObjectAusgewählt;
    public bool SpawnGerüstIsActive = false;
    Ray ray;
    RaycastHit hit;
    public string ObjectName;
    public SpawnListe SL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ObjectAusgewählt){
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit)){
                if(!SpawnGerüstIsActive){
                    SpawnGerüstInstance = Instantiate(SpawnGerüst, hit.point,Quaternion.identity);
                    SpawnGerüstIsActive = true;
                }else{
                    SpawnGerüstInstance.transform.position = hit.point;
                }
                if(Input.GetKeyDown(KeyCode.Mouse0)){
                    foreach(GameObject o in SL.SpawnObjects){
                        if(o.name.Equals(ObjectName)){
                            GameObject neu = Instantiate(o,hit.point,Quaternion.identity);
                        }
                    }
                }
            }else{
                Destroy(SpawnGerüstInstance);
                SpawnGerüstIsActive =false;
            }
        }
    }
}
