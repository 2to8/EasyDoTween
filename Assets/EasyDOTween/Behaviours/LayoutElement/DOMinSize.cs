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

namespace EasyDOTween.Animation.LayoutElement
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/LayoutElement/DOMinSize")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.LayoutElement))]
    public class DOMinSize : EasyDOTween.Animation<UnityEngine.UI.LayoutElement>
    {
        
        [UnityEngine.SerializeField()]
        private UnityEngine.Vector2 endValue;
        
        [UnityEngine.SerializeField()]
        private bool snapping = false;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.UI.LayoutElement target, float duration)
        {
            return target.DOMinSize(endValue, duration, snapping);
        }
    }
}

#endif