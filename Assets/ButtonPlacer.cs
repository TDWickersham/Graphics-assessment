using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlacer : MonoBehaviour
{
    public GameObject[] placements;
    public Material[] change;
	

    public void PlaceHouse()
    {
        GameObject.Instantiate<GameObject>(placements[1]);
    }

    public void PlaceTree()
    {
        GameObject.Instantiate<GameObject>(placements[0]);
    }

    public void PlacePath()
    {
        GameObject.Instantiate<GameObject>(placements[2]);
    }

    public void ChangeBrick()
    {
        
    }

    public void ChangeWood()
    {

    }

    public void ChangeMetal()
    {

    }
}
