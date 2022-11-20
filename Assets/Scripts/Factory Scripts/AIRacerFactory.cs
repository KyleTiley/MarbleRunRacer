using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIRacerFactory : MonoBehaviour
{
    [SerializeField] GameObject racerPrefab;

    public GameObject RacerCreator(Transform startPosition){
        return Instantiate(racerPrefab, startPosition);
    }
}
