using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryManagement : MonoBehaviour
{
    [SerializeField] int numberOfRacers = 8;
    [SerializeField] GameObject factory;
    [SerializeField] Transform mainStartPos;

    Racer1Factory racer1;
    Racer2Factory racer2;
    Racer3Factory racer3;


    private void Awake() {
        racer1 = factory.GetComponent<Racer1Factory>();
        racer2 = factory.GetComponent<Racer2Factory>();
        racer3 = factory.GetComponent<Racer3Factory>();
    }

    private void Start() {
        int xOffset = 0;

        Transform newStartPos = mainStartPos;
        for(int i =0; i < numberOfRacers; i++){
            int newRand = Random.Range(0,3);
            if(newRand == 0){
                GameObject newRacer1 = racer1.RacerCreator(newStartPos);
                newRacer1.transform.position = new Vector3(newRacer1.transform.position.x + xOffset, newRacer1.transform.position.y, newRacer1.transform.position.z);
            }
            else if(newRand == 1){
                GameObject newRacer2 = racer2.RacerCreator(newStartPos);
                newRacer2.transform.position = new Vector3(newRacer2.transform.position.x + xOffset, newRacer2.transform.position.y, newRacer2.transform.position.z);
            }
            else if(newRand == 2){
                GameObject newRacer3 = racer3.RacerCreator(newStartPos);
                newRacer3.transform.position = new Vector3(newRacer3.transform.position.x + xOffset, newRacer3.transform.position.y, newRacer3.transform.position.z);
            }

            xOffset -= 5;
        }
    }
}
