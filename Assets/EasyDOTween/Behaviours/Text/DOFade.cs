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

namespace EasyDOTween.Animation.Text
{
    using DG.Tweening;
    
    
    [UnityEngine.AddComponentMenu("EasyDOTween/Text/DOFade")]
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Text))]
    public class DOFade : EasyDOTween.Animation<UnityEngine.UI.Text>
    {
        
        [UnityEngine.SerializeField()]
        private float endValue;
        
        protected override DG.Tweening.Tween CreateTween(UnityEngine.UI.Text target, float duration)
        {
            return target.DOFade(endValue, duration);
        }
    }
}

#endif