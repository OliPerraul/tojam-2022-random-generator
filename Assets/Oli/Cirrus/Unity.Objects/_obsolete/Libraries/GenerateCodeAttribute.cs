using System;

namespace Cirrus.Content
{
    
    public enum GenerateCodeOptions
    { 
        None = 0,
        GenerateMonoBehaviour = 1 << 0
    }

    // TODO: Generate code on class
    /// <summary>
    /// Used to generate mcontent stored within library mainly for debugging/preproduction purpose
    /// TODO: Final content should be fitted alongside the resource and it's assets (e.g. sprites dialogues etc.)
    /// into it's personalised component/asset instead. e.g. Weapon_BeginnerStaff should be manually created.
    /// 
    /// The only problem with this approach is that new component needed to be created for minor variations..
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class)]    
    public class GenerateCodeAttribute : System.Attribute
    {
        public GenerateCodeOptions Options;
        public GenerateCodeAttribute(GenerateCodeOptions options = GenerateCodeOptions.None)
        {
            Options = options;
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class)]
    public class SkipCodeGenAttribute : System.Attribute
    {

        public SkipCodeGenAttribute()
        {
        }
    }
}
