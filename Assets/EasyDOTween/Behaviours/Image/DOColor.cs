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

namespace EasyDOTween.Animation.Image
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Image/DOColor")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Image))]
    public class DOColor : EasyDOTween.Animation<UnityEngine.UI.Image>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Color endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.UI.Image target, float duration)
        {
            return target.DOColor(endValue, duration);
        }
    }
}

#endif