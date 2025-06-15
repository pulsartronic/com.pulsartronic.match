using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StadiumColors", menuName = "ScriptableObjects/StadiumColors")]
public class StadiumColors : ScriptableObject {
    public Material light_color;
    public Material dark_color;
    public Material seat_color_01;
    public Material seat_color_02;
}
