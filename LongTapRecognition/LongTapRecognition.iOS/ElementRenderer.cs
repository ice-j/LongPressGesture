using LongTapRecognition;
using LongTapRecognition.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace LongTapRecognition.iOS
{
    public class CustomImageRenderer : ImageRenderer
    {
        UILongPressGestureRecognizer longPressGestureRecognizer;
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            longPressGestureRecognizer = new UILongPressGestureRecognizer(() => ((CustomImage)Element).InvokeLongPressedEvent());

            if (e.NewElement != null)
                RemoveGestureRecognizer(longPressGestureRecognizer);

            if (e.OldElement != null)
                AddGestureRecognizer(longPressGestureRecognizer);
        }
    }
}
