using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouvement : MonoBehaviour {

    public float Vitesse;
    public float DistanceParcourue;
    public int UnitParcouru;
    private float x;

    private void Start()
    {
        UnitParcouru = 22;
    }

    private void Update()
    {
        x = Vitesse / 800;
    }

    private void FixedUpdate()
    {
        transform.Translate(x, 0f, 0f);
        DistanceParcourue = DistanceParcourue + x;
        if(DistanceParcourue >= 1)
        {
            UnitParcouru = UnitParcouru + 1;
            DistanceParcourue = 0;
        }

    }
    

}
