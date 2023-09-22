using Microsoft.Maui.Controls.Platform;

namespace MauiAndroidEffectBug
{
    public class NoBackgroundEffect : RoutingEffect
    {
    }

#if ANDROID
    public class NoBackgroundEffectPlatform : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is AndroidX.AppCompat.Widget.AppCompatEditText editText)
                editText.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        protected override void OnDetached()
        { }
    }
#elif IOS
    public class NoBackgroundEffectPlatform : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UIKit.UITextField textField)
            {
                textField.BackgroundColor = UIKit.UIColor.Clear;
                textField.BorderStyle = UIKit.UITextBorderStyle.None;
            }
        }

        protected override void OnDetached()
        { }
    }
#endif
}
