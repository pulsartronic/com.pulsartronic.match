using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TeamEquipment", menuName = "ScriptableObjects/TeamEquipment")]
public class TeamEquipment : ScriptableObject {
    public string color;
    public Material hair;
    public Material skin;
    public Material tshirt_0;
    public Material tshirt_1;
    public Material shorts;
    public Material shoes;
}
