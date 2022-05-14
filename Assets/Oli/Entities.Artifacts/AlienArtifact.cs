using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
    public enum ArtifactType
    { 
        Unknown,
        Harmful,
        Valuable
    }

    public class AlienArtifact : EntityBase
    {
        [SerializeField]
        public float Chance = 0.5f;

        [SerializeField]
        public float Price = 10;

        [SerializeField]
        public ArtifactType Type = ArtifactType.Valuable;
    }
    
}
