using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonPlacer : MonoBehaviour
{
    public GameObject[] placements;

	

    public void PlaceHouse()
    {
        Placement place = GetComponent<Placement>();
        place.placer = placements[1];
        
    }

    public void PlaceTree()
    {
        Placement place = GetComponent<Placement>();
        place.placer = placements[0];
    }

    public void PlacePath()
    {
        Placement place = GetComponent<Placement>();
        place.placer = placements[2];
    }

 
}
