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

namespace EasyDOTween.Animation.Graphic
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Graphic/DOFade")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Graphic))]
    public class DOFade : EasyDOTween.Animation<UnityEngine.UI.Graphic>
    {
        
        [UnityEngine.SerializeField()]
        private float endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.UI.Graphic target, float duration)
        {
            return target.DOFade(endValue, duration);
        }
    }
}

#endif