using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cirrus.Unity.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	public class NetTool : ToolBase
	{
		protected override void _Use(IEnumerable<EntityBase> entities)
		{
			foreach (var ent in entities)
			{
				if (ent is AlienArtifact art)
				{
					_Capture(art);
				}
			}
		}

		private void _Capture(AlienArtifact ent)
		{
			switch (ent.Type)
			{
				case ArtifactType.Valuable:
					Player.Instance.UpdateMoney(ent.Value);
					break;
				
				case ArtifactType.Harmful:
					Player.Instance.UpdateHealth(-ent.Value);
					break;
			}

			ent.gameObject.Destroy();
		}
	}
}
