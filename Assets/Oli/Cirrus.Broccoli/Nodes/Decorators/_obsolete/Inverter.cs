//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace Cirrus.Broccoli {
//    public class Inverter : DecoratorNode {
//        protected override void OnStart() {
//        }

//        protected override void OnStop() {
//        }

//        protected override State OnUpdate() {
//            switch (Child.Update()) {
//                case State.Running:
//                    return State.Running;
//                case State.Failure:
//                    return State.Success;
//                case State.Success:
//                    return State.Failure;
//            }
//            return State.Failure;
//        }
//    }
//}