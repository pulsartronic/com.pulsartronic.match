using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TeamEquipments", menuName = "ScriptableObjects/TeamEquipments")]
public class TeamEquipments : ScriptableObject {
    public List<TeamEquipment> equipment;
}
