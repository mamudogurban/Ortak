using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool _pointGiven;

    public bool pointGiven
    {

        get { return _pointGiven; }

        set
        {
            pointGiven = value;

           
        }

    }

    
}