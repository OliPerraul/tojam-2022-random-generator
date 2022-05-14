//using System.Collections;
//using System.Collections.Generic;

////using Cirrus.Unity.Procedural;

//using UnityEngine;

//public class SamplingTester : MonoBehaviour
//{
//    public enum RadiiMode{SingleRadius, VariableRadii};
//    public RadiiMode radiiMode;
//    public float radius = 1f;
//    public List<PointInfo> pointInfo = new List<PointInfo>();
//    public Vector2 sampleRegionSize = Vector2.one;
//    public int numSamplesBeforeRejection = 30;
//    public float gizmoRadius = 0.5f;

//    private PdsResult _result;

//    void OnValidate(){
//        if(radiiMode == RadiiMode.SingleRadius){
//            //points = PoissonDiscSampling.GeneratePoints(radius, sampleRegionSize, numSamplesBeforeRejection);
//        } else {
//            float[] radii = new float[pointInfo.Count];
//            float[] ratios = new float[pointInfo.Count];
//            for(int i = 0; i < pointInfo.Count; i++){
//                radii[i] = pointInfo[i].radius;
//                ratios[i] = pointInfo[i].probability;
//            }
//            //PoissonDiscSampling.GeneratePointsVariableRadii(radii, ratios, sampleRegionSize, numSamplesBeforeRejection, out _result);
//        }
        
//    }

//    void OnDrawGizmos(){
//        Gizmos.DrawWireCube(sampleRegionSize / 2, sampleRegionSize);

//        if(_result.PointCoords != null)
//        {
//            foreach(Vector3 point in _result.PointCoords)
//            {
//                Gizmos.DrawSphere(new Vector3(point.x, point.y, 0), point.z / 2);
//            }
//        }
//    }
//}

//[System.Serializable]
//public struct PointInfo{
//    public float radius;
//    public float probability;
//}
