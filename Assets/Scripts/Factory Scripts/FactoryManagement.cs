using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManagement : MonoBehaviour
{
    [SerializeField] int numberOfRacers = 7;
    [SerializeField] GameObject factory;
    [SerializeField] Transform mainStartPos;

    Racer1Factory racer1;
    Racer2Factory racer2;
    Racer3Factory racer3;
    Racer4Factory racer4;
    Racer5Factory racer5;


    private void Awake() {
        racer1 = factory.GetComponent<Racer1Factory>();
        racer2 = factory.GetComponent<Racer2Factory>();
        racer3 = factory.GetComponent<Racer3Factory>();
        racer4 = factory.GetComponent<Racer4Factory>();
        racer5 = factory.GetComponent<Racer5Factory>();
    }

    private void Start() {
        int zOffset = 0;

        Transform newStartPos = mainStartPos;
        for(int i =0; i < numberOfRacers; i++){
            int newRand = Random.Range(0,5);
            if(newRand == 0){
                GameObject newRacer1 = racer1.RacerCreator(newStartPos);
                newRacer1.transform.position = new Vector3(newRacer1.transform.position.x, newRacer1.transform.position.y, newRacer1.transform.position.z+zOffset);
            }
            else if(newRand == 1){
                GameObject newRacer2 = racer2.RacerCreator(newStartPos);
                newRacer2.transform.position = new Vector3(newRacer2.transform.position.x, newRacer2.transform.position.y, newRacer2.transform.position.z+zOffset);
            }
            else if(newRand == 2){
                GameObject newRacer3 = racer3.RacerCreator(newStartPos);
                newRacer3.transform.position = new Vector3(newRacer3.transform.position.x, newRacer3.transform.position.y, newRacer3.transform.position.z+zOffset);
            }
            else if(newRand == 3){
                GameObject newRacer4 = racer4.RacerCreator(newStartPos);
                newRacer4.transform.position = new Vector3(newRacer4.transform.position.x, newRacer4.transform.position.y, newRacer4.transform.position.z+zOffset);
            }
            else if(newRand == 4){
                GameObject newRacer5 = racer5.RacerCreator(newStartPos);
                newRacer5.transform.position = new Vector3(newRacer5.transform.position.x, newRacer5.transform.position.y, newRacer5.transform.position.z+zOffset);
            }

            zOffset += 2;
        }
    }
}
