using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seats : MonoBehaviour {
    public float probability = 0.5f;

    public List<GameObject> prefabs;

    void Start() {
        MainSystem main_system = MainSystem.Get();
        TeamsData teams_data = main_system.Component<TeamsData>();

        foreach (Transform seat_transform in this.transform) {
            if (Random.value <= this.probability) {
                int rnd_index = Random.Range(0, this.prefabs.Count);
                GameObject crowd_member_prefab = this.prefabs[rnd_index];
                GameObject crowd_member_object = Instantiate(crowd_member_prefab, seat_transform);
                TShirtChanger changer = crowd_member_object.transform.GetChild(0).GetComponent<TShirtChanger>();
                int equipment_index = Random.Range(0, teams_data.equipments.equipment.Count);
                TeamEquipment equipment = teams_data.equipments.equipment[equipment_index];
                changer.SetEquipment(equipment, false);

                //Seat seat = seat_transform.GetComponent<Seat>();
                //CrowdMember crowd_member = crowd_member_object.GetComponent<CrowdMember>();
                //seat.cloned = crowd_member;
            }
        }
    }
}
