using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TShirtChanger : MonoBehaviour {
    public List<Renderer> skin_renderers;
    public List<Renderer> tshirt_0_renderers;
    public List<Renderer> tshirt_1_renderers;


    public void SetTShirtMaterial(Material material) {
        foreach(Renderer renderer in this.tshirt_0_renderers) {
            renderer.material = material;
        }
    }

    public void SetEquipment(TeamEquipment equipment, bool secondary_tshirt) {
        foreach (Renderer renderer in this.skin_renderers) {
            renderer.material = equipment.skin;
        }

        foreach (Renderer renderer in secondary_tshirt ? this.tshirt_1_renderers : this.tshirt_0_renderers) {
            renderer.material = equipment.tshirt_0;
        }

        foreach (Renderer renderer in secondary_tshirt ? this.tshirt_0_renderers : this.tshirt_1_renderers) {
            renderer.material = equipment.tshirt_1;
        }
    }
}
