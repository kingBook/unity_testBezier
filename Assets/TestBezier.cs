using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBezier : MonoBehaviour {
    public Transform[] transforms;
    void Start () {

    }

    void Update () {
        Vector3[] points1 = BezierUtil.GetBezierPoints1(transforms[0].position, transforms[1].position, 5, true);
        DrawPoints(points1, Color.red);

        Vector3[] points2 = BezierUtil.GetBezierPoints2(transforms[0].position, transforms[1].position, transforms[2].position, 5, true);
        DrawPoints(points2, Color.green);


        Vector3[] points3 = BezierUtil.GetBezierPoints3(transforms[0].position, transforms[1].position, transforms[2].position, transforms[3].position, 5, true);
        DrawPoints(points3, Color.blue);
    }

    private void DrawPoints (Vector3[] points, Color color) {
        for (int i = 0, len = points.Length; i < len; i++) {
            if (i < len - 2) {
                Debug.DrawLine(points[i], points[i + 1], color);
            }
        }
    }

}
