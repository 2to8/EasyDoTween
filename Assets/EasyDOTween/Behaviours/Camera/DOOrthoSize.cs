//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyDOTween.Animation.Camera
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Camera/DOOrthoSize")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.Camera))]
    public class DOOrthoSize : EasyDOTween.Animation<UnityEngine.Camera>
    {
        
        [UnityEngine.SerializeField()]
        private float endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.Camera target, float duration)
        {
            return target.DOOrthoSize(endValue, duration);
        }
    }
}
