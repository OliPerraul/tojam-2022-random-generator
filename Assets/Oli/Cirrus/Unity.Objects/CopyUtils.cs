using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
//using Cirrus.DH.Conditions;
using UnityEngine;

namespace Cirrus.Unity.Objects
{
	public static class CopyUtils
	{
		public static void Copy(this CharacterJoint source, CharacterJoint target)
		{			
			// joint
			target.connectedBody = source.connectedBody;
			target.connectedArticulationBody = source.connectedArticulationBody;
			target.axis = source.axis;
			target.anchor = source.anchor;
			target.connectedAnchor = source.connectedAnchor;
			target.autoConfigureConnectedAnchor = source.autoConfigureConnectedAnchor;
			target.breakForce = source.breakForce;
			target.breakTorque = source.breakTorque;
			target.enableCollision = source.enableCollision;
			target.enablePreprocessing = source.enablePreprocessing;
			target.massScale = source.massScale;
			target.connectedMassScale = source.connectedMassScale;
			//target.currentForce = other.currentForce;
			//target.currentTorque = other.currentTorque;

			// CharacterJoint
			//target.targetRotation = other.targetRotation;
			//target.targetAngularVelocity = other.targetAngularVelocity;
			//target.rotationDrive = other.rotationDrive;
			target.swingAxis = source.swingAxis;
			target.twistLimitSpring = source.twistLimitSpring;
			target.swingLimitSpring = source.swingLimitSpring;
			target.lowTwistLimit = source.lowTwistLimit;
			target.highTwistLimit = source.highTwistLimit;
			target.swing1Limit = source.swing1Limit;
			target.swing2Limit = source.swing2Limit;
			target.enableProjection = source.enableProjection;
			target.projectionDistance = source.projectionDistance;
			target.projectionAngle = source.projectionAngle;
		}

		public static void Copy(this HingeJoint source, HingeJoint target)
		{
			target.connectedBody = source.connectedBody;
			target.connectedArticulationBody = source.connectedArticulationBody;
			target.axis = source.axis;
			target.anchor = source.anchor;
			target.connectedAnchor = source.connectedAnchor;
			target.autoConfigureConnectedAnchor = source.autoConfigureConnectedAnchor;
			target.breakForce = source.breakForce;
			target.breakTorque = source.breakTorque;
			target.enableCollision = source.enableCollision;
			target.enablePreprocessing = source.enablePreprocessing;
			target.massScale = source.massScale;
			target.connectedMassScale = source.connectedMassScale;

			target.motor = target.motor;
			target.limits = target.limits;
			target.spring = target.spring;
			target.useMotor = target.useMotor;
			target.useLimits = target.useLimits;
			target.useSpring = target.useSpring;
			//target.velocity = target.velocity;
			//target.angle = target.angle;
		}
	}


}
