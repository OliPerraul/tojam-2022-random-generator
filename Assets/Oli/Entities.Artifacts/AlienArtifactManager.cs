using Cirrus.Randomness;
using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tojam2022
{
	class AlienArtifactManager : SingletonComponentBase<AlienArtifactManager>
	{

		private Timer _artifactDiscoveredTimer;

		[SerializeField]
		private Range_ _artifactDiscoveredTime = new Range_(1, 10);

		[SerializeField]
		private List<AlienArtifact> _artifacts;

		[SerializeField]
		private Renderer _discoveryZoneMesh;

		[SerializeField]
		private Bounds _discoveryZoneBounds;

		private void _OnArtifactDiscoveredTimeout()
		{
			AlienArtifact prefab = _artifacts.Choice(_artifacts.Select(x => x.Chance));
			Vector3 discoveryPosition = _discoveryZoneBounds.RandomPosition().XY_(0);
			prefab.Instantiate(discoveryPosition);

			_artifactDiscoveredTimer.Reset(_artifactDiscoveredTime.Random());
		}

		public override void Awake()
		{
			base.Awake();

			_discoveryZoneMesh.gameObject.SetActive(true);
			_discoveryZoneBounds = _discoveryZoneMesh.bounds;
			_discoveryZoneMesh.gameObject.SetActive(false);

			_artifactDiscoveredTimer = new Timer(_OnArtifactDiscoveredTimeout);	

		}

		public void DoStart()
		{
			_artifactDiscoveredTimer.Reset(_artifactDiscoveredTime.Random());
		}

		public void DoStop()
		{
			_artifactDiscoveredTimer.Stop();
		}
	}
}
