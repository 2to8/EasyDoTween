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
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Camera/DORect")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.Camera))]
    public class DORect : EasyDOTween.Animation<UnityEngine.Camera>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Rect endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.Camera target, float duration)
        {
            return target.DORect(endValue, duration);
        }
    }
}
