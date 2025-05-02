using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Esta clase solo se encarga de reposicionar el centro de masa
 */
public class CenterOfMass : MonoBehaviour {
    public Rigidbody body;
    public Vector3 center_of_mass = Vector3.zero;

    private void Start() {
        this.body.centerOfMass = this.center_of_mass;
    }
}
