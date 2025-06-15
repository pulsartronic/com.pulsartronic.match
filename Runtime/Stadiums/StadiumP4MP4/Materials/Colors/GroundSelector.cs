using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSelector : MonoBehaviour {
    public List<StadiumColors> stadium_colors;

    public Renderer outside_field;
    public Renderer inside_grass;

    public List<Renderer> seats_01;
    public List<Renderer> seats_10;

    public int index = 0;

    void OnEnable() {
        this.ChangeColors();
    }

    public void ChangeColors() {
        //int index = Random.Range(0, this.stadium_colors.Count);
        StadiumColors colors = this.stadium_colors[index];

        Material[] outside_field_materials = this.outside_field.materials;
        outside_field_materials[0] = colors.dark_color;
        outside_field_materials[1] = colors.light_color;
        this.outside_field.materials = outside_field_materials;

        Material[] inside_grass_materials = this.inside_grass.materials;
        inside_grass_materials[0] = colors.dark_color;
        inside_grass_materials[1] = colors.light_color;
        this.inside_grass.materials = inside_grass_materials;

        for (int i = 0; i < this.seats_01.Count; i++) {
            Material[] seat_1_materials = this.seats_01[i].materials;
            seat_1_materials[1] = colors.seat_color_01;
            seat_1_materials[2] = colors.seat_color_02;
            this.seats_01[i].materials = seat_1_materials;
        }

        for (int i = 0; i < this.seats_10.Count; i++) {
            Material[] seat_1_materials = this.seats_10[i].materials;
            seat_1_materials[2] = colors.seat_color_01;
            seat_1_materials[1] = colors.seat_color_02;
            this.seats_10[i].materials = seat_1_materials;
        }
    }
}
