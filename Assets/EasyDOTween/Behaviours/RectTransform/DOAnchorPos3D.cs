#if EasyDOTween_UI
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyDOTween.Animation.RectTransform
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/RectTransform/DOAnchorPos3D")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.RectTransform))]
    public class DOAnchorPos3D : EasyDOTween.Animation<UnityEngine.RectTransform>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Vector3 endValue;
        
        [UnityEngine.SerializeField()]
        private bool snapping = false;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.RectTransform target, float duration)
        {
            return target.DOAnchorPos3D(endValue, duration, snapping);
        }
    }
}

#endif