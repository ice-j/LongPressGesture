using Android.Views;
using Xamarin.Forms;
using LongTapRecognition;
using LongTapRecognition.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace LongTapRecognition.Droid
{
    public class CustomImageRenderer : ImageRenderer
    {
        private readonly GestureDetector.SimpleOnGestureListener _listener;
        private readonly GestureDetector _detector;

        public CustomImageRenderer()
        {
            _listener = new GestureDetector.SimpleOnGestureListener();
            _detector = new GestureDetector(_listener);
            _detector.IsLongpressEnabled = true;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
            {
                this.GenericMotion -= HandleGenericMotion;
                this.LongClick -= HandleLongClick;
            }

            if (e.OldElement == null)
            {
                this.GenericMotion += HandleGenericMotion;
                this.LongClick += HandleLongClick;
            }
        }

        void HandleLongClick(object sender, LongClickEventArgs e)
        {
            ((CustomImage)Element).InvokeLongPressedEvent();
        }

        void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            _detector.OnTouchEvent(e.Event);
        }

    }
}