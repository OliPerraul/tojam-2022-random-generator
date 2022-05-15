using Cirrus.Randomness;
using Cirrus.Unity.Numerics;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tojam2022
{
	class DecorationManager : SingletonComponentBase<DecorationManager>
	{
		//[SerializeField]
		//private List<AlienArtifactBase> _artifacts;

		[SerializeField]
		private Renderer _decorationZoneMesh;

		[SerializeField]
		private Bounds _decorationZoneMeshBounds;

		private void _OnShopItemBought(Deco deco)
		{
			//AlienArtifactBase prefab = _artifacts.Choice(_artifacts.Select(x => x.Chance));
			Vector3 discoveryPosition = _decorationZoneMeshBounds.RandomPosition().XY_(0);
			deco.Instantiate(null, discoveryPosition);

			//_artifactDiscoveredTimer.Reset(_artifactDiscoveredTime.Random());
		}

		public override void Awake()
		{
			base.Awake();

			_decorationZoneMesh.gameObject.SetActive(true);
			_decorationZoneMeshBounds = _decorationZoneMesh.bounds;
			_decorationZoneMesh.gameObject.SetActive(false);

			ShopUi.Instance.OnShopItemBoughtEvent += _OnShopItemBought;

			//_artifactDiscoveredTimer = new Timer(_OnArtifactDiscoveredTimeout);

		}

		//public void DoStart()
		//{
		//	//_artifactDiscoveredTimer.Reset(_artifactDiscoveredTime.Random());
		//}

		//public void DoStop()
		//{
		//	//_artifactDiscoveredTimer.Stop();
		//}
	}
}
