using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    public interface IInheritanceHandler
    {
        void InitializeOwners(Object target, Object parent); 
        
        void DisposeOwners();
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProperty"></typeparam>
    /// <typeparam name="TOwner"></typeparam>
    public abstract class InheritanceHandlerBase<TProperty, TOwner> : IInheritanceHandler
    {
        protected TOwner TargetOwner { get; set; }
        protected TOwner ParentOwner { get; set; }

        public abstract void InitializeOwners(Object target, Object parent);

        public abstract void DisposeOwners();

        public abstract bool PropertyEqualsParent(TProperty property);

        /// <summary>
        /// Get an enumerable of the properties in the target owner object.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TProperty> EnumerateTarget()
        {
            return EnumerateOwner(TargetOwner);
            
        }

        /// <summary>
        /// Gets an enumerable of the properties of the parent owner object.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TProperty> EnumerateParent()
        {
            return EnumerateOwner(TargetOwner);
        }

        protected abstract IEnumerable<TProperty> EnumerateOwner(TOwner owner);

        /// <summary>
        /// Determines whether the base owner has the specified property.
        /// </summary>
        /// <param name="property"></param>
        /// <returns><c>true</c> if the base owner has <paramref name="property"/>; otherwise, <c>false</c>.</returns>
        public abstract bool ParentHasProperty(TProperty property);

        /// <summary>
        /// Gets the string path of the specified property.
        /// </summary>
        /// <param name="property">The property to get the path from.</param>
        /// <returns>The path of <paramref name="property"/>.</returns>
        public abstract string GetPropertyPath(TProperty property);


        public abstract bool CopyFromParentIfDifferent(string propertyPath);

        /// <summary>
        /// Called after an inheritance asset is changed. Is not called for synce changes to variants.
        /// </summary>
        public virtual void OnAfterRegisteredOverrides(InheritanceData data) 
        {

        }

        /// <summary>
        /// Called before the properties of an object are synced with its base.
        /// </summary>
        public virtual void OnBeforeSyncProperties()
        {

        }

        public virtual bool OnAfterSyncProperties(InheritanceData data)
        {
            return false;
        }
    }
}
