using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldLimits : MonoBehaviour {

    public Color gizmos_color = Color.yellow;

    void OnDrawGizmos() {
        Gizmos.color = this.gizmos_color;
        foreach (Transform point in this.transform) {
            Gizmos.DrawSphere(point.position, 1);
        }
    }

    public Vector3 GetNearestPoint(Vector3 point) {
        foreach (Transform limit in this.transform) {
            Vector3 relative_point = point - limit.position;
            float dot = Vector3.Dot(relative_point, limit.forward);
            if (dot < 0f) {
                point = point - dot * limit.forward;
            }
        }
        return point;
    }

    public Vector3 GetLineoutPoint(Vector3 point) {
        Transform plane_0 = this.transform.GetChild(0);
        Transform plane_1 = this.transform.GetChild(2);

        float d_0 = Math3D.PointLineDistance(plane_0.right, plane_0.position, point);
        float d_1 = Math3D.PointLineDistance(plane_1.right, plane_1.position, point);
        Transform nearest_plane = (d_0 < d_1) ? plane_0 : plane_1;

        Math3D.LinePlaneIntersection(out point, point, nearest_plane.forward, nearest_plane.forward, nearest_plane.position);

        point = Vector3.ProjectOnPlane(point, Vector3.up);
        return GetNearestPoint(point);
    }

    public bool IsInside(Vector3 point) {
        bool inside = true;
        foreach (Transform limit in this.transform) {
            Vector3 relative_point = point - limit.position;
            float dot = Vector3.Dot(relative_point, limit.forward);
            inside = inside && (dot >= 0f); // This >= is what includes (or not) tli limits them selves
        }
        return inside;
    }
}
